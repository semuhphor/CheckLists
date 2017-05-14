using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace CheckList.Models
{
    public class DBInitialiser
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(Projects.Select(c => c.Value));
            }

            if (!context.Templates.Any())
            {
                context.AddRange
                (
                    new Template { TemplateName = "As of 05.01.2017", Project = Projects["VW Push"], Json = @"{""chklist"":[{""type"":""H"", ""name"":""PushChecklist""},{""type"":""C"", ""name"":""Pushed button"", ""checked"":""false""}, {""type"":""C"", ""name"":""Tested System"", ""checked"":""true""} ] }" },
                    new Template { TemplateName = "As of 05.07.2017", Project = Projects["VW Push"], Json = @"{""chklist"":[{""type"":""H"", ""name"":""Another push checklist""},{""type"":""C"", ""name"":""Typed name"", ""checked"":""false""}, {""type"":""C"", ""name"":""Sent Email"", ""checked"":""true""} ] }" },
                    new Template { TemplateName = "Check ready to push", Project = Projects["Push Checklist"], Json = @"{""chklist"":[{""type"":""H"", ""name"":""Ready to push""},{""type"":""C"", ""name"":""Tom say yes"", ""checked"":""false""}, {""type"":""C"", ""name"":""Mark says yes"", ""checked"":""false""} ] }" }
                );
            }

            if (!context.ChkLists.Any())
            {
                context.AddRange
                (
                    new ChkList { ChkListName = "VW Push 05.02.2017", FromTemplate = "As of 05.01.2017", Project = Projects["VW Push"], Json = @"{""chklist"":[{""type"":""H"", ""name"":""PushChecklist""},{""type"":""C"", ""name"":""Pushed button"", ""checked"":""false""}, {""type"":""C"", ""name"":""Tested System"", ""checked"":""false""} ] }" },
                    new ChkList { ChkListName = "Check if deploay ready 05.21.2017", FromTemplate = "Check ready to push", Project = Projects["Push Checklist"], Json = @"{ ""chklist"":[{ ""type"":""H"", ""name"":""Ready to push"" }, { ""type"":""C"", ""name"":""Tom say yes"", ""checked"":""false"" }, { ""type"":""C"", ""name"":""Mark says yes"", ""checked"":""false"" } ] }" }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Project> projects;
        public static Dictionary<string, Project> Projects
        {
            get
            {
                if (projects == null)
                {
                    var projectList = new Project[]
                    {
                        new Project { ProjectName = "VW Push" },
                        new Project { ProjectName = "Push Checklist" }
                    };

                    projects = new Dictionary<string, Project>();

                    foreach (Project project in projectList)
                    {
                        projects.Add(project.ProjectName, project);
                    }
                }

                return projects;
            }
        }
    }
}
