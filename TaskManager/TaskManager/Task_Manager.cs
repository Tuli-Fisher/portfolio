using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Task_Manager
    {
        //public List<Task> tasks;
        public Dictionary<Status,List<myTask>> statusList = new();
        public Task_Manager()
        {
            foreach(Status status in Enum.GetValues(typeof(Status))) {
                statusList[status] = new List<myTask>();
            }
            //tasks = new List<Task>();
           

            //var t1 = new myTask("grocery", "bread and milk");
            //var t2 = new myTask("store", "books");
            //var t3 = new myTask("go", "home", DateTime.Now, Status.todo, Priority.medium);
            //SetStatus(t2, Status.completed);
            //AddTask(t1);
            //AddTask(t2);
            //AddTask(t3);
            //SetPriority(t1, Priority.high);
            //SetStatus(t1, Status.inProgress);

            //SetPriority(t2, Priority.low);
            //PrintTasks();
            //RemoveTask(t1);
            //Console.WriteLine("               ---------------");

           // PrintTasks();
           // PrintCompletedTasks();
        }
        public void AddTask(myTask task)
        {
            statusList[task.status].Add(task);


            //if (task.status == Status.completed) {
            //    completedList.Add(task);
            //}
            //else {
            //    tasks.Add(task);
            //}
        }
        public void SetStatus(myTask task, Status status)
        {
            if (task.status == status) {
                return;
            }
            statusList[task.status].Remove(task);
            task.status = status;
            statusList[task.status].Add(task);


            //task.status = status;
            //if (status == Status.completed) {
            //    RemoveTask(task);
            //    completedList.Add(task);
            //}
        }
        public void SetPriority(myTask task, Priority priority)
        {
            task.priority = priority;
        }
        public void UpdateTask(myTask task,string name, string description, DateTime dateTime, Status status, Priority priority)
        {
            task.Name = name;
            task.Description = description;
            task.datetime = dateTime;
            SetStatus(task, status);
            task.priority = priority;
        }
        public void SetStatusAndPriority(myTask task, Status status, Priority priority)
        {
            SetStatus(task, status);
            //if (task.status == Status.completed) {
            //    RemoveTask(task);
            //    completedList.Add(task);
            //}
            SetPriority(task, priority);
        }
        public void RemoveTask(myTask task)
        {
            statusList[task.status].Remove(task);
        }
        public void PrintInOrder(Dictionary<Status, List<myTask>> list, Func<myTask,bool> filter = null)
        {
            foreach (var key in list) {
               
                Console.WriteLine($"    ------------{key.Key}-----------------  ");

                foreach (var task in key.Value) {

                    // potentially sort by priority
                    Console.WriteLine($"  - {task}");
                }
            }
        }
        public void PrintTasks()
        {
            Console.WriteLine("          ------      Tasks       ------");
            PrintInOrder(statusList);
        }
        //public void PrintCompletedTasks()
        //{
        //    Console.WriteLine("------ Completed Tasks ------");
        //    foreach (var task in completedList) {
        //        Console.WriteLine(task);
        //    }
        //}
    }
}
