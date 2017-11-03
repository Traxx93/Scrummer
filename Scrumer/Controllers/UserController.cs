using AutoMapper;
using Scrumer.Infrastrucutre.Context;
using Scrumer.Infrastrucutre.Entities;
using Scrumer.Models.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrumer.Controllers
{
    public class UserController : Controller
    {
        ScrumerContext context;
        IMapper mapper;

        public UserController(ScrumerContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        
        // GET: Member
        public ActionResult Index()
        {
            return View(nameof(Index));
        }

        // GET: Member/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create(AddUserViewModel newUserViewModel)
        {
            if (ModelState.IsValid) {
                var newUserEntity = mapper.Map<AddUserViewModel, User>(newUserViewModel);
                context.Users.Add(newUserEntity);
                context.SaveChanges();

                return View("Index");
            }
            else
            {
                return View();
            }


        }

        // GET: Member/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Member/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
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
