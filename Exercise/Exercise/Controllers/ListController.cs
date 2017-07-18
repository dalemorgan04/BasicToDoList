using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise.Models;
using Exercise.Models.ViewModels;
using Exercise.Models.BusinessLayer;

namespace Exercise.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            //I will prepopulate the list with default data
            //Although this wasn't asked for in the test, I wanted to show how I would use
            //a model/ viewmodel

            //Populate view model
            ListBusinessLayer listBl = new ListBusinessLayer();
            ListViewModel vm = new ListViewModel();
            vm.taskList = listBl.GetDefaultTaskList();

            ViewBag.Title = "To Do List";
            ViewBag.Heading = "To Do List";
            return View(vm);
        }
    }
}