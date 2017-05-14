using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Models
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProjectRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Project> Projects => _appDbContext.Projects;

        public Project Load(Project project)
        {
            _appDbContext.Entry(project).Collection(p => p.Templates).Load();
            _appDbContext.Entry(project).Collection(p => p.ChkLists).Load();
            return project;
        }
    }
}
