using AutoMapper;
using Scrumer.Infrastrucutre.Context;
using Scrumer.Infrastrucutre.Entities;
using Scrumer.Models.SprintViewModel;
using Scrumer.Models.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrumer.Controllers
{
    public class SprintController : Controller
    {
        ScrumerContext context;
        IMapper mapper;

        public SprintController(ScrumerContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        // GET: Sprint
        public ActionResult Index()
        {
            var sprintEntities = context.Sprints;
            var sprintViewModels = mapper.Map<IEnumerable<Sprint>, IEnumerable<SprintViewModel>>(sprintEntities);
            return View(sprintViewModels);
        }

        // GET: Sprint/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sprint/Create
        public ActionResult Create()
        {
            var model = new AddSprintViewModel();
            var userEntities = context.Users;
            var userViewModels = mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(userEntities);
            model.StartDate = DateTime.Now;
            model.Users = userViewModels;
            return View(model);
        }

        // POST: Sprint/Create
        [HttpPost]
        public ActionResult Create(AddSprintViewModel addSprintViewModel)
        {
            if (ModelState.IsValid)
            {
                var addSprintEntity = mapper.Map<AddSprintViewModel, Sprint>(addSprintViewModel);
                var users = new List<User>();

                foreach (var id in addSprintViewModel.SelectedUsersForSprint)
                {
                    var user = context.Users.Where(u => u.UserID == id).FirstOrDefault();
                    users.Add(user);
                }
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Sprint/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new EditSprintViewModel();
            var sprintEntity = context.Sprints.Where(s => s.SprintID == id).FirstOrDefault();
            model = mapper.Map<Sprint, EditSprintViewModel>(sprintEntity);

            var usersEntities = context.Users;
            var usersViewModel = mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(usersEntities);


            model.Users = usersViewModel;
            model.SelectedUsers = sprintEntity.Users.Select(u => u.UserID);

            return View(model);
        }

        // POST: Sprint/Edit/5
        [HttpPost]
        public ActionResult Edit(EditSprintViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var entitySprint = mapper.Map<EditSprintViewModel, Sprint>(model);

                    entitySprint.Users.Where(m => !model.SelectedUsers.Contains(m.UserID)).ToList().ForEach(user => entitySprint.Users.Remove(user));

                    var selectedUsers = entitySprint.Users.Select(m => m.UserID);
                    context.Users.Where(m => !model.SelectedUsers.Except(selectedUsers).Contains(m.UserID)).ToList()
                        .ForEach(user => entitySprint.Users.Add(user));


                    entitySprint.StartDate = model.StartDate;
                    entitySprint.EndDate = model.EndDate;
                    entitySprint.ScrumGoal = model.ScrumGoal;
                    entitySprint.ProjectID = model.ProjectID;
                    context.SaveChanges();

                    return RedirectToAction("Index");
                }

                var entitySprintUsers = context.Users;
                var sprintViewModelUsers = mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(entitySprintUsers);

                model.Users = sprintViewModelUsers;
                
                return View(model); 
            }
            catch
            {
                return View();
            }
        }

        // GET: Sprint/Delete/5
       

      
    }
}
