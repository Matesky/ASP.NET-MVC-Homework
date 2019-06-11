using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;
using ToDo.Models.DomainModels;

namespace ToDo.Controllers
{
    public class TasksController : Controller
    {
        public List<Tasks> _tasks;
        public List<SubTask> _subtasks;
        public List<User> _users;

        public TasksController()
        {
            SubTask FirstSubTask = new SubTask()
            {
                Task = "Do the laundry",
                Description = "Wash clothes",
                Status = StatusSubTask.NotFinished,
            };
            SubTask SecondSubTask = new SubTask()
            {
                Task = "Fix the light",
                Description = "Change the light bulb",
                Status = StatusSubTask.NotFinished,
            };
            SubTask ThirdSubTask = new SubTask()
            {
                Task = "Dust",
                Description = "Wipe the dust",
                Status = StatusSubTask.NotFinished,
            };
            SubTask ForthSubTask = new SubTask()
            {
                Task = "Wash the car",
                Description = "Take the car to the car wash",
                Status = StatusSubTask.Finished,
            };
            SubTask FifthSubTask = new SubTask()
            {
                Task = "Write homework",
                Description = "Make a ToDo app",
                Status = StatusSubTask.Finished,
            };
            SubTask SixthSubTask = new SubTask()
            {
                Task = "Go to Class",
                Description = "Go to SEDC Academy on 11.06",
                Status = StatusSubTask.NotFinished,
            };
            SubTask SeventhSubTask = new SubTask()
            {
                Task = "Watch Chernobyl",
                Description = "Watch all 5 episodes",
                Status = StatusSubTask.NotFinished,
            };
            SubTask EighthSubTask = new SubTask()
            {
                Task = "Register the car",
                Description = "Take the car for registration",
                Status = StatusSubTask.Finished,
            };

            _subtasks = new List<SubTask>() { FirstSubTask, SecondSubTask, ThirdSubTask, ForthSubTask, FifthSubTask, SixthSubTask, SeventhSubTask };

            Tasks FirstTask = new Tasks()
            {
                Title = "Housework",
                Description = "Do some work around the house",
                Importance = Importance.Important,
                Status = Status.InProgress,
                Type = TypeOfTask.Personal
            };
            FirstTask.SubTasks.Add(FirstSubTask);
            FirstTask.SubTasks.Add(SecondSubTask);
            FirstTask.SubTasks.Add(ThirdSubTask);

            Tasks SecondTask = new Tasks()
            {
                Title = "Homework",
                Description = "Write homework to be prepared for the SEDC class",
                Importance = Importance.MediumImportance,
                Status = Status.InProgress,
                Type = TypeOfTask.Work
            };
            SecondTask.SubTasks.Add(FifthSubTask);
            SecondTask.SubTasks.Add(SixthSubTask);

            Tasks ThirdTask = new Tasks()
            {
                Title = "Car",
                Description = "Take care about the car",
                Importance = Importance.Important,
                Status = Status.Finished,
                Type = TypeOfTask.Personal
            };
            ThirdTask.SubTasks.Add(ForthSubTask);
            ThirdTask.SubTasks.Add(EighthSubTask);

            Tasks ForthTask = new Tasks()
            {
                Title = "Series",
                Description = "Watching TV series",
                Importance = Importance.NotImportant,
                Status = Status.NotFinished,
                Type = TypeOfTask.Hobby
            };
            ForthTask.SubTasks.Add(SeventhSubTask);

            _tasks = new List<Tasks>() { FirstTask, SecondTask, ThirdTask, ForthTask, };

            User FirstUser = new User()
            {
                Id = 1,
                FirstName = "Kristijan",
                LastName = "Mateski",
                Age = 21,
                AverageFreeTime = 25,
            };
            FirstUser.CreatedTasks.Add(SecondTask);
            FirstUser.CreatedTasks.Add(ForthTask);

            User SecondUser = new User()
            {
                Id = 2,
                FirstName = "Cvetko",
                LastName = "Cvetkovski",
                Age = 54,
                AverageFreeTime = 18,
            };
            SecondUser.CreatedTasks.Add(ThirdTask);
            SecondUser.CreatedTasks.Add(FirstTask);


            User ThirdUser = new User()
            {
                Id = 3,
                FirstName = "Marija",
                LastName = "Marjanovska",
                Age = 39,
                AverageFreeTime = 10,
            };
            ThirdUser.CreatedTasks.Add(FirstTask);

            _users = new List<User>() { FirstUser, SecondUser, ThirdUser };

        }
        public IActionResult NotFinishedTasks(int? id)
        {
            User user = _users.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult InProgressTasks(int? id)
        {
            User user = _users.FirstOrDefault(x => x.Id == id);
            return View(user);
        }
        public IActionResult FinishedTasks(int? id)
        {
            User user = _users.FirstOrDefault(x => x.Id == id);
            return View(user);
        }
        public IActionResult UserStatistics(int? id)
        {
            User user = _users.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult CreateTask()
        {
            return View();
        }
    }
}