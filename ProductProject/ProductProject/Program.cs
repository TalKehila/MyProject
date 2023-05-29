using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ProductProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Product[] products = { new Product("milk", 15 , 7), new Product("chicken", 13, 30), new Product("fish", 15, 65) };
          
            while (true)
            {
                loop(products);
            }
        }
        static void loop(Product[] products)
        {
            Console.WriteLine("What is your name : ");// asking for name 
            string name = Console.ReadLine();

            for (int i = 0; i < products.Length; i++)// printing the product
            {
                Console.WriteLine($"[{i + 1}]");
                Console.WriteLine(products[i]);
            }
            Console.WriteLine($"Please choose product (1-{products.Length})");// choosing product
            int choice = ReadNumber("Please write only numbers, try again: ");
            while (choice < 1 || choice > products.Length)
            {
                Console.WriteLine("Sorry, we can't find this product... try again");// cant find 
                choice = ReadNumber("Please write only numbers, try again: ");
            }
            Console.WriteLine("Thank you, ");
            Console.WriteLine(name);
            Console.WriteLine($"\nInvoce:\n{products[choice - 1]}");
            Console.ReadKey();
        }
            static int ReadNumber(string error = "Invalid")//reading the number for product
            {
                int result = 0;
                while (!int.TryParse(Console.ReadLine(), out result))
                {                   
                    Console.WriteLine(error);                
                }
                return result;
            }        
    }
}
