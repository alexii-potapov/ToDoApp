using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
	public class TodoContext : DbContext
	{
		public DbSet<Todo> Todoes { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<User> Users { get; set; }

		public TodoContext(DbContextOptions<TodoContext> options)
			: base(options)
		{
			Database.EnsureCreated();
		}
	}
}
