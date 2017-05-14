using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheckList.Models;
using CheckList.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckList.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectRepository _projectRepository;

        public HomeController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            ProjectsListViewModel projectListViewModel = new ProjectsListViewModel();
            projectListViewModel.Projects = _projectRepository.Projects;

            return View(projectListViewModel);
        }

        // GET: /<controller>/Templates/Id
        public ViewResult Templates(int? id)
        {
            TemplatesListViewModel templatesListViewModel = new TemplatesListViewModel();
            Project project = _projectRepository.Load(_projectRepository.Projects.Where(p => p.ProjectId == id).FirstOrDefault());

            ViewBag.ProjectName = project.ProjectName;
            templatesListViewModel.Templates = project.Templates;
            return View(templatesListViewModel);
        }

        // GET: /<controller>/CheckLists/Id
        public ViewResult CheckLists(int? id)
        {
            ChkListListViewModel chkListViewModel = new ChkListListViewModel();
            Project project = _projectRepository.Load(_projectRepository.Projects.Where(p => p.ProjectId == id).FirstOrDefault());

            ViewBag.ProjectName = project.ProjectName;
            chkListViewModel.ChkLists = project.ChkLists;
            return View(chkListViewModel);
        }
    }
}
