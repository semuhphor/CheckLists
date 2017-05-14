using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckList.Models;

namespace CheckList.ViewModels
{
    public class ProjectsListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
    }
}
