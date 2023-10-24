//Console.WriteLine("Hello, f*king World!");
//Task перенести в окрему папку зробити shopper так само і тд
using Pharmacy.Models;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Task Manager");
            Console.WriteLine("2. Shopper Manager");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int globalmenu))
            {
                switch (globalmenu)
                {
                    case 1:
                        ITaskManager taskManager = new TaskManager();
                        if (taskManager is TaskManager taskManagerImpl)
                        {
                            taskManagerImpl.TaskComplete += (sender, e) =>
                            {
                                Console.WriteLine($"Завдання \"{e.TaskComplete.Title}\" відзначено як виконане.");
                            };
                        }

                        while (true)
                        {
                            Console.WriteLine("1. Add Task");
                            Console.WriteLine("2. Mark Task as Completed");
                            Console.WriteLine("3. List Tasks");
                            Console.WriteLine("4. Find Task");
                            Console.WriteLine("5. Remove Task");
                            Console.WriteLine("6. Exit");
                            Console.Write("Enter your choice: ");
                            if (int.TryParse(Console.ReadLine(), out int taskmenu))
                            {
                                switch (taskmenu)
                                {
                                    case 1:
                                        Console.Write("Enter task title: ");
                                        string title = Console.ReadLine();
                                        ITask newTask = new Assignment(title);
                                        taskManager.AddTask(newTask);
                                        Console.WriteLine("Task added.");
                                        break;
                                    case 2:
                                        Console.Write("Enter task title to mark as completed: ");
                                        string taskTitle = Console.ReadLine();
                                        var taskToComplete = taskManager as TaskManager;
                                        var task = taskToComplete?.tasks.Find(t => t.Title == taskTitle);
                                        if (task != null)
                                        {
                                            taskManager.MarkTaskAsCompleted(task);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Task not found.");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Tasks:");
                                        taskManager.ListTasks();
                                        break;
                                    case 4:
                                        Console.Write("Enter task title to find: ");
                                        string titleToFind = Console.ReadLine();
                                        Assignment foundTask = taskManager.FindTask(titleToFind);
                                        if (foundTask != null)
                                        {
                                            Console.WriteLine($"Task found: {foundTask.Title}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Task not found.");
                                        }
                                        break;
                                    case 5:
                                        Console.Write("Enter task title to remove: ");
                                        string titleToRemove = Console.ReadLine();
                                        bool removed = taskManager.RemoveTask(titleToRemove);
                                        if (removed)
                                        {
                                            Console.WriteLine("Task removed.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Task not found.");
                                        }
                                        break;
                                    default:
                                        if (taskmenu == 4)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid choice.");
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                            if(taskmenu == 6)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }  
                        }
                        break;
                    case 2:
                        ShopperManager shopperManager = new ShopperManager();

                        while(true)
                        {
                            Console.WriteLine("1. Add Shopper");
                            Console.WriteLine("2. Remove Shopper");
                            Console.WriteLine("3. List Shoppers");
                            Console.WriteLine("4. Exit");
                            Console.Write("Enter your choice: ");

                            if (int.TryParse(Console.ReadLine(), out int shoppermenu))
                            {
                                switch (shoppermenu)
                                {
                                    case 1:
                                        Console.Write("Enter phone number: ");
                                        string phoneNum = Console.ReadLine();
                                        Console.Write("Enter discount value: ");
                                        float discountValue = float.Parse(Console.ReadLine());
                                        Console.Write("Enter discount card ID: ");
                                        string discountCardID = Console.ReadLine();

                                        var shopper = new Shopper
                                        {
                                            PhoneNum = phoneNum,
                                            DiscountValue = discountValue,
                                            IDDiscountCard = discountCardID
                                        };

                                        shopperManager.AddShopper(shopper);
                                        Console.WriteLine("Shopper added.");
                                        break;
                                    case 2:
                                        Console.Write("Enter phone number to remove: ");
                                        string phoneToRemove = Console.ReadLine();
                                        bool removed = shopperManager.RemoveShopper(phoneToRemove);
                                        if (removed)
                                        {
                                            Console.WriteLine("Shopper removed.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Shopper not found.");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Shoppers:");
                                        foreach (var Customer in shopperManager.GetAllShoppers())
                                        {
                                            Console.WriteLine($"Phone: {Customer.PhoneNum}, Discount: {Customer.DiscountValue}, Card ID: {Customer.IDDiscountCard}");
                                        }
                                        break;
                                    default:
                                        if(shoppermenu == 4)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid choice.");
                                            break;
                                        }
                                    case 4:
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                            if (shoppermenu == 4)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}