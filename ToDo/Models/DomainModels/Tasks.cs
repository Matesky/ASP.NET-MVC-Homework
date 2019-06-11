using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models.DomainModels
{
    public class Tasks
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Importance Importance  { get; set; }
        public Status Status { get; set; }
        public TypeOfTask Type  { get; set; }
        public List<SubTask> SubTasks { get; set; }
    }
    public enum Importance
    {
        Important = 1,
        MediumImportance,
        NotImportant
    }
    public enum Status
    {
        NotFinished,
        InProgress,
        Finished
    }
    public enum TypeOfTask
    {
        Work,
        Personal,
        Hobby
    }
}
