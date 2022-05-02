using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppinList2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\helen.raudsepp\Samples\myShoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add something to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your product:");
                    string userProduct = Console.ReadLine();
                    myShoppingList.Add(userProduct);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
            Console.Clear();

            foreach (string product in myShoppingList)
            {
                Console.WriteLine($"Your wish: {product}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
