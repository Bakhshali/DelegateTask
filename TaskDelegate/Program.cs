using System;

namespace TaskDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 30, 58, 62, 75, 88, 90, 99, 106 };
            
            Action<double[]> action = getTotal;

            Action<double[]> action1 = getCount;

            action += action1;
            action(array);

            
        }

        public static void getTotal(double [] array)
        {
            double total =default(double);

            foreach (var item in array)
            {
                total+=item;
            }
            Console.WriteLine(total);
        }

        public static void getCount(double [] array)
        {
            double count =default(double);

            foreach (var item in array)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
