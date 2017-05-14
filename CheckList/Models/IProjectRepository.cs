using System.Collections.Generic;

namespace CheckList.Models
{
    public interface IProjectRepository
    {
        IEnumerable<Project> Projects { get; }
        Project Load(Project project);
    }
}
