using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    // Інтерфейс для представлення завдання
    public interface ITask
    {
        string Title { get; }
        bool IsCompleted { get; }
        void Complete();
    }

    // Клас, що представляє завдання
    public class Assignment : ITask
    {
        public string Title { get; private set; }
        public bool IsCompleted { get; private set; }

        public Assignment(string title)
        {
            Title = title;
            IsCompleted = false;
        }

        public void Complete()
        {
            IsCompleted = true;
        }
    }

    // Інтерфейс для менеджера завдань
    public interface ITaskManager
    {
        void AddTask(ITask task);
        void MarkTaskAsCompleted(ITask task);
        void ListTasks();
        Assignment FindTask(string title);
        bool RemoveTask(string title);
    }

    // Клас, що реалізує функціональність управління завданнями
    public class TaskManager : ITaskManager
    {
        public List<ITask> tasks;

        public TaskManager()
        {
            tasks = new List<ITask>();
        }

        public event EventHandler<TaskCompleteEventArgs> TaskComplete;
        public void AddTask(ITask task)
        {
            tasks.Add(task);
        }

        public void MarkTaskAsCompleted(ITask task)
        {
            task.Complete();
            OnTaskComplete(new TaskCompleteEventArgs(task));
        }

        public void ListTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Title} - {(task.IsCompleted ? "Completed" : "Not Completed")}");
            }
        }

        public Assignment FindTask(string title)
        {
            return tasks.OfType<Assignment>().FirstOrDefault(task => task.Title == title);
        }

        public bool RemoveTask(string title)
        {
            var taskToRemove = tasks.OfType<Assignment>().FirstOrDefault(task => task.Title == title);
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                return true;
            }
            return false;
        }

        protected virtual void OnTaskComplete(TaskCompleteEventArgs e)
        {
            TaskComplete?.Invoke(this, e);
        }
    }

    public class TaskCompleteEventArgs : EventArgs
    {
        public ITask TaskComplete { get; }

        public TaskCompleteEventArgs(ITask task)
        {
            TaskComplete = task;
        }
    }
}