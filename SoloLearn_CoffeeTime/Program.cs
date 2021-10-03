using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn_CoffeeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here
            coffee.Keys.ToArray();
            List<string> list = new List<string>();
            List<int> vs= new List<int>();
            foreach (var item in coffee.Keys)
            {
                list.Add(item);
            }
            foreach (var item in coffee.Values)
            {
                int x = item - (item * discount / 100);
                vs.Add(x);
            }
            for (int i = 0; i < list.Count; i++)
            {
                coffee[list[i]] = vs[i];
            }
            foreach (var item in coffee)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
