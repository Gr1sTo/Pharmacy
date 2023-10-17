using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.Task
{
   /* // Інтерфейс для представлення завдання
    public interface ITask
    {
        string Title { get; }
        bool IsCompleted { get; }
        void Complete();
    }

    // Клас, що представляє завдання
    public class Task : ITask
    {
        public string Title { get; private set; }
        public bool IsCompleted { get; private set; }

        public Task(string title)
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
    }

    // Клас, що реалізує функціональність управління завданнями
    public class TaskManager : ITaskManager
    {
        public List<ITask> tasks;
        public List<Shopper> Shoppers { get; private set; }

        public TaskManager()
        {
            tasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            tasks.Add(task);
        }

        public void MarkTaskAsCompleted(ITask task)
        {
            task.Complete();
        }

        public void ListTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Title} - {(task.IsCompleted ? "Completed" : "Not Completed")}");
            }
        }
    }*/
}
