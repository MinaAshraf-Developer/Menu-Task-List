using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Task_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            char selection = ' ';
            do
            {
                Console.WriteLine("\n------------------------");
                Console.WriteLine("  - P. Print Numbers");
                Console.WriteLine("  - A. Add Number");
                Console.WriteLine("  - M. Display mean of the numbers");
                Console.WriteLine("  - S. Display the smallest number");
                Console.WriteLine("  - L. Display the largest number");
                Console.WriteLine("  - F. Find a number");
                Console.WriteLine("  - C. Clear the whole list");
                Console.WriteLine("  - Q. Quit");
                Console.Write("\n  - Enter your selection: ");
                selection = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.WriteLine("\n------------------------");
                Console.WriteLine("\n                        ");
              
                                    



                if (selection == 'P')
                {
                    if (numList.Count > 0)
                    {
                        Console.Write("[");
                        for (int i = 0; i < numList.Count; i++)

                            Console.Write($" {numList[i]} ");
                        Console.Write("]");
                    }
                    else
                    {
                        Console.WriteLine("The List is Empty!!");
                    }
                    
                }
               
                else if (selection == 'A')
                {
                    Console.Write("Add number : ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    numList.Add(num);
                }

                else if (selection == 'M')
                {
                    double sum = 0;
              
                    for(int i = 0; i < numList.Count; i++)
                    {
                        sum = sum + numList[i];
                    }
                  double mean = sum / numList.Count;
                    Console.WriteLine("\n------------------------");
                    Console.WriteLine($"The mean of the numbers is {mean}");
                    Console.WriteLine("\n------------------------");

                }
                else if (selection == 'S')
                {
                    
                        double minValue = numList[0];

                        for (int i = 1; i < numList.Count; i++)
                        {
                            if (numList[i] < minValue)
                            {
                                minValue = numList[i];
                            }
                        }
                        Console.WriteLine("\n------------------------");
                        Console.WriteLine($"The smallest number is {minValue}");
                        Console.WriteLine("\n------------------------");
                   
                   
                }
                else if (selection == 'L')
                {

                   
                        double maxValue = numList[0];

                        for (int i = 1; i < numList.Count; i++)
                        {
                            if (numList[i] > maxValue)
                            {
                                maxValue = numList[i];
                            }
                        }
                        Console.WriteLine("\n------------------------");
                        Console.WriteLine($"The largest number is {maxValue}");
                        Console.WriteLine("\n------------------------");
                   
                       
                    
                   
                }
                else if (selection == 'F')
                {
                    Console.Write($"Write the number you're looking for : ");
                    int searchNum = Convert.ToInt32(Console.ReadLine());
                    bool checker = false;  // to check if the number in the List

                    for (int i=0;i < numList.Count; i++)
                    {
                        
                        if (searchNum == numList[i])
                        {
                            Console.WriteLine("\n------------------------");
                            Console.WriteLine($"The number at index {i}");
                            checker = true;
                            Console.WriteLine("\n------------------------");
                        }
                       
                    }
                    if(checker)
                    {

                    }
                    else
                    {
                        Console.WriteLine("\n------------------------");
                        Console.WriteLine($"The number is not exist");
                        Console.WriteLine("\n------------------------");
                    }

                }
                else if (selection == 'C')
                {
                    numList.Clear();
                    Console.WriteLine("\n------------------------");
                    Console.WriteLine("List has been Cleared");
                    Console.WriteLine("\n------------------------");
                }
                   
                else if (selection == 'Q')
                {
                    Console.WriteLine("\n------------------------");
                    Console.WriteLine("Goodbye...");
                    Console.WriteLine("\n------------------------");
                }
                    
                else
                    Console.WriteLine("Unknown option -- try again...");
            } while (selection != 'Q');
        }
    }
}
