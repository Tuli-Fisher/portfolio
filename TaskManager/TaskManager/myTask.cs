using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public enum Status
    {
        todo,
        inProgress,
        completed
    }
    public enum Priority
    {
        low,
        medium,
        high
    }
    public class myTask
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime datetime { get; set; }
        public Status status { get; set; }
        public Priority priority { get; set; }
        public myTask() { }

        public myTask(string name, string description)
        {
            Name = name;
            Description = description;
            
            datetime = DateTime.Now.AddDays(30); // check on this
        }

        public myTask(string name, string description, DateTime dateTime, Status status, Priority priority) : this(name, description)
        {
            this.datetime = dateTime;
            this.status = status;
            this.priority = priority;
        }

      
        public void CompletedTask(myTask task)
        {
          
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            myTask task = (myTask)obj;
            return Name == task.Name &&
                Description == task.Description &&
                datetime == task.datetime &&
                status == task.status &&
                priority == task.priority;
        }

        public override int GetHashCode()
        {
            return (Name,Description).GetHashCode();
        }

        public override string? ToString()
        {
            return $" Name: {Name} , Description: {Description} , DueDate: {datetime} , Priority: {priority} , Status: {status}";
        }
    }
}
