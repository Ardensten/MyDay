using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDay.Models
{
    internal class Routine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeOnly TimeOfDay { get; set; }
        public DateOnly Date { get; set; }
        public List<Activity>? Activities { get; set; }
    }
}
