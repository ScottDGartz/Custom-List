using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big would you like the initial list to be?");

            CustomList dataList = new CustomList(Math.Abs(int.Parse(Console.ReadLine())));

            string response = null;

            while (response != "done")
            {
                Console.WriteLine("Enter a command from the list: done, print, indexOf, contains, removeAt, remove, insert, clear, set, get");
                response = Console.ReadLine();
                if (response == "print")
                {
                    dataList.Print();
                }
                else if (response == "indexOf")
                {
                    Console.WriteLine("What would you like to search for?");
                    int tempInt = dataList.IndexOf(Console.ReadLine());
                    if (tempInt!=-1)
                    {
                        Console.WriteLine("The Index is " + tempInt);
                    }
                    else
                    {
                        Console.WriteLine("That string does not exist within this list.");
                    }
                }
                else if (response == "contains")
                {
                    Console.WriteLine("What string would you like to look for?");

                    if(dataList.Contains(Console.ReadLine())== true)
                    {
                        Console.WriteLine("The string is contained within this list.");
                    }
                    else
                    {
                        Console.WriteLine("The string is not contained within this list.");
                    }
                }
                else if (response == "removeAt")
                {
                    Console.WriteLine("What index would you like to remove data at?");
                    dataList.RemoveAt(int.Parse(Console.ReadLine()));
                }
                else if (response == "remove")
                {
                    Console.WriteLine("What string would like to attempt to remove?");
                    if (dataList.Remove(Console.ReadLine())== true)
                    {
                        Console.WriteLine("The string was successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("The string was not successfully removed.");
                    }
                }
                else if (response == "insert")
                {
                    Console.WriteLine("Enter a string you want to insert");
                    string tempString = Console.ReadLine();

                    Console.WriteLine("Enter the index you would like to insert it at");
                    int tempInt = int.Parse(Console.ReadLine());

                    dataList.Insert(tempInt, tempString);
                }
                else if (response == "clear")
                {
                    dataList.Clear();
                }
                else if (response == "set")
                {
                    Console.WriteLine("Enter a string");
                    string tempString = Console.ReadLine();

                    Console.WriteLine("Enter the index you would like to insert the data at");
                    int tempInt = int.Parse(Console.ReadLine());

                    dataList.SetData(tempInt, tempString);
                }
                else if (response == "get")
                {
                    
                    Console.WriteLine("Enter the index you want data from");

                    string tempstring = dataList.GetData(int.Parse(Console.ReadLine()));
                    Console.WriteLine("The data at the index you wanted is " + tempstring);
                }
                else
                {
                    dataList.Add(response);
                }

            }
            
        }
    }
}
