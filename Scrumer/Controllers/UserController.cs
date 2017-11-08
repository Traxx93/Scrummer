using AutoMapper;
using Scrumer.Infrastrucutre.Context;
using Scrumer.Infrastrucutre.Entities;
using Scrumer.Models.UserViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrumer.Controllers
{
    public class UserController : Controller
    {
        ScrumerContext context;
        IMapper mapper;

        public UserController() { }

        public UserController(ScrumerContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

        }

        

        // GET: Member
        [HttpGet]
        public ActionResult Index()
        {
            var userEntities = context.Users;
            var userViewModel = mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(userEntities);
            return View(userViewModel);
        }

        // GET: Member/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            var model = new AddUserViewModel();
            return View(model);
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create(AddUserViewModel newUserViewModel)
        {
            if (ModelState.IsValid)
            {
                var newUserEntity = mapper.Map<AddUserViewModel, User>(newUserViewModel);
                context.Users.Add(newUserEntity);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var editUserEntity = context.Users.Find(id);
            var editUserViewModel = mapper.Map<User, EditUserViewModel>(editUserEntity);
            return View(editUserViewModel);
        }

        [HttpPost]
        public ActionResult Edit(EditUserViewModel editUserViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var editUserEntity = mapper.Map<EditUserViewModel, User>(editUserViewModel);
                    context.Entry(editUserEntity).State = EntityState.Modified;
                    context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Member/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Member/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
