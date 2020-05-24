using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
			return View(db.Todoes.
				Include(todo => todo.User).
				Include(todo => todo.Group).
				ToList());
		}
	}
}
