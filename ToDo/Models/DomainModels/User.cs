using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models.DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AverageFreeTime { get; set; }
        public string  Email { get; set; }
        public List<Tasks> CreatedTasks { get; set; }

       
        }
    }

