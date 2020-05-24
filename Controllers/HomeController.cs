using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
		TodoContext db;
		public HomeController(TodoContext context)
		{
			db = context;
		}
        public IActionResult Index()
        {
            return View(db.Todoes.ToList());
        }
    }
}
