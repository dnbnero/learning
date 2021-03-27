using System;
using System.Collections.Generic;
{
var tasks = new List<string>();
while (true)
    {
        Console.Clear();
        Console.WriteLine("Меню");
        Console.WriteLine("1 - добавить задачу");
        Console.WriteLine("2 - удалить задачу");
        Console.WriteLine("3 - просмотреть все задачи");
        string choise = Console.ReadLine();
        switch (choise)
        {
        case "1":
            Console.WriteLine("Введите задачу\n");
            string task = Console.ReadLine();
            tasks.Add(task);
            break;
        case "2":
            Console.WriteLine("Какую задачу удалить?\n");
            foreach (string i in tasks)
            {
                Console.WriteLine(tasks.IndexOf(i) + ". --- " + i);
            }
            tasks.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            break;
        case "3":
            foreach (string i in tasks)
            {
                Console.WriteLine(tasks.IndexOf(i) + ". --- " + i);
            }
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Error");
            Console.ReadKey();
            break;
        }
    }
}
