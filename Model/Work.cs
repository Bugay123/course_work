using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Model
{
    public class Work
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Discipline { get; set; }
        public string Topic { get; set; }
        public string StudentName { get; set; }
        public string SupervisorName { get; set; }
        public string Group { get; set; }
        public int YearOfDefense { get; set; }
        public int Grade { get; set; }

        public virtual void Display() { }
    }
}
