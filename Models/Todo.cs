using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
	public class Todo
	{
		public int TodoId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime Duedate { get; set; }
		public Fibonachi Complexity { get; set; }
		public bool Archive { get; set; }
		public bool Deleted { get; set; }
		public Group Group { get; set; }
		public User User { get; set; }

	}

	public class Group
	{
		public int GroupId { get; set; }
		public string Name { get; set; }
		public ICollection<Todo> Todoes { get; set; }
		public User User { get; set; }
	}

	public class User
	{
		public int UserId { get; set; }
		public string Name { get; set; }
		public string About { get; set; }
		public ICollection<Todo> Todoes { get; set; }
		public ICollection<Group> Groups{ get; set; }

	}

	public enum Fibonachi : ushort
	{
		P0 = 0,
		P1 = 1,
		P2 = 2,
		P3 = 3,
		P5 = 5,
		P8 = 8,
		P13 = 13,
		P21 = 21,
		P50 = 50,
		P100 = 100
	}
}
