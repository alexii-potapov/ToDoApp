using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
	public class SampleData
	{
		public static void Initialize(TodoContext context)
		{
			if (!context.Users.Any())
			{
				context.Users.Add(
					new User
					{
						Name = "Aleksey",
						About = "Master"
					});
				context.SaveChanges();
			}
			User user = context.Users.First();

			if (!context.Groups.Any())
			{
				context.Groups.Add(
					new Group
					{
						Name = "Main group",
						User = user
					});
				context.SaveChanges();
			}
			Group group = context.Groups.First();

			if (!context.Todoes.Any())
			{
				context.Todoes.AddRange(
					new Todo
					{
						Name = "Create sample list",
						Description = "Very important step to start",
						User = user,
						Complexity = Fibonachi.P3,
						Duedate = DateTime.Now,
						Group = group
					},
					new Todo
					{
						Name = "Create complex list",
						Description = "Optional task",
						User = user,
						Complexity = Fibonachi.P2,
						Duedate = DateTime.Now,
						Group = group
					}
					);

				context.SaveChanges();
			}
		}
	}
}
