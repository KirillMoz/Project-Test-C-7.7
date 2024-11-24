using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test_C_7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order<int> newOrder = new Order<int>("uaysguygasygdas", 1);
            newOrder.AddProduct("good 1", 260);
            newOrder.AddProduct("good 2", 290);
            newOrder.AddProduct("good 3", 310);
            newOrder.AddProduct("good 4", 570);
            newOrder.AddProduct("good 5", 110);
            newOrder.AddProduct("good 6", 100);
            newOrder.AddProduct("good 7", 60);
            
            newOrder.Print();

            Order<int> oldOrder = new Order<int>("ldkmgkmkgoimrtgm", 2);
            oldOrder.AddProduct("good 1", 660);
            oldOrder.AddProduct("good 8", 390);
            oldOrder.AddProduct("good 2", 810);
            oldOrder.AddProduct("good 4", 670);
            oldOrder.AddProduct("good 5", 810);
            oldOrder.AddProduct("good 9", 500);
            oldOrder.AddProduct("good 7", 60);

            oldOrder.Print();

            Order<int> sumOrder = newOrder + oldOrder;
            sumOrder.Print();

            Console.ReadKey();

        }
    }
}
