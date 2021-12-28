using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Compute area of rectangle using func delegate
namespace ConsoleApp_Day_6_Assingment_1
{
    public delegate int AreaofRectangle(int w, int h);
    public class Area
    {
        public static int GetArea(int w, int h)
        {
            return w * h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Width : ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height : ");
            int height = Convert.ToInt32(Console.ReadLine());  

            AreaofRectangle ans = new AreaofRectangle(Area.GetArea);
            int area = ans.Invoke(width, height);
            Console.WriteLine("Area of Rectangle is " + area);
            Console.ReadLine();
        }
    }
}
