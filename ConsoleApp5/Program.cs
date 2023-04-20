using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cost of notebook:");
            int notebook = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cost of pen:");
            int pen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of notebook");
            int notebookBuy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cost of pen:");
            int penBuy = Convert.ToInt32(Console.ReadLine());
            int sum = notebook * notebookBuy + pen * penBuy;
            Console.WriteLine($"Sum= {sum}");
            Console.ReadLine();
        }
    }
}
