using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTController.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public Student(int i, string n, string c)
        {
            Id = i;
            Name = n;
            Class = c;
        }
    }
}