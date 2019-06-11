using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models.DomainModels
{
    public class SubTask
    {
        public string Task { get; set; }
        public string Description { get; set; }
        public StatusSubTask Status { get; set; }
    }
    public enum StatusSubTask
    {
        Finished,
        NotFinished
    }
}
