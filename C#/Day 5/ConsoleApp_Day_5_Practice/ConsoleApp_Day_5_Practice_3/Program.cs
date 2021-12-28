using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Store a product information in map object. Key will be a product item and value will be the price of that product. Search the product by product name.

namespace ConsoleApp_Day_5_Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            map.Add("Pen", 45);
            map.Add("Keyboard", 900);
            map.Add("Pencil", 50);
            map.Add("Mouse", 500);
            map.Add("Notebook", 20);
 
            Console.Write("Product List : ");
            foreach (KeyValuePair<string, int> kvp in map)
            {
                Console.Write(kvp.Key + "\n\t       ");
            }
            
            Console.Write("\nEnter Product Name for Search : ");
            string keyname = Console.ReadLine();
            Console.WriteLine("Product Price : " + map[keyname]);
            Console.ReadLine();
        }
    }
}
