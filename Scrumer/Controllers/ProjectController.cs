using AutoMapper;
using Scrumer.Infrastrucutre.Context;
using Scrumer.Infrastrucutre.Entities;
using Scrumer.Models.ProjectViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrumer.Controllers
{
    public class ProjectController : Controller
    {

        ScrumerContext context;
        IMapper mapper;

        public ProjectController(ScrumerContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        // GET: Project
        public ActionResult Index()
        {
            var projectEntities = context.Projects;
            var projectViewModels = mapper.Map<IEnumerable<Project>, IEnumerable<ProjectViewModel>>(projectEntities);
            return View(projectViewModels);

        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {

            var projectEntity = context.Projects.Find(id);
            var projectViewModel = mapper.Map<Project, DetailsProjectViewModel>(projectEntity);
            return View();
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            var newProjectViewModel = new AddProjectViewModel();
            return View("AddProject", newProjectViewModel);
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(AddProjectViewModel newProjectViewModel)
        {
            try
            {
                // TODO: Add insert logic here
                var addProjectEntity = mapper.Map<AddProjectViewModel, Project>(newProjectViewModel);
                context.Projects.Add(addProjectEntity);
                context.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            var projectEditEntity = context.Projects.Find(id);
            var projectEditViewModel = mapper.Map<Project, EditProjectViewModel>(projectEditEntity);
            return View("EditProject", projectEditViewModel);
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(AddProjectViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var projectEntity = mapper.Map<AddProjectViewModel, Project>(model);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch
            {
                return View("EditProject");
            }
        }
        
    }
}
