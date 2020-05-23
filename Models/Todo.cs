using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Duedate { get; set; }
        public Fibonachi Complexity { get; set; }
        public bool Archive { get; set; }
        public bool Deleted { get; set; }
        public Group Group { get; set; }

    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum Fibonachi : ushort
    {
        P1 = 1,
        P2 = 1,
        P3 = 3,
        P5 = 5,
        P8 = 8,
        P13 = 13,
        P21 = 21,
        P50 = 50,
        P100 = 100
    }
}
