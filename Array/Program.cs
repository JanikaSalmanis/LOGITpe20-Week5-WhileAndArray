using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shoppingList = { "milk", "bread", "WC paper", "cookies", "pork" };
            int arrayLength = shoppingList.Length;
            Console.WriteLine($"You have {arrayLength} items on your list.");
            for(int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"{i+1}. {shoppingList[i]}");
            }
            Console.WriteLine($"The first intem on your list is {shoppingList[0]} ");
            Console.WriteLine($"The last intem on your list is {shoppingList[shoppingList.Length-1]} ");
        }
    }
}
