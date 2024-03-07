using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rand_sel_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double min=0,max=0;
            Random random = new Random();
            double[]num = new double[2+3];
            float[] sel = { 0, 0 };
            int i;
            for (i = 0; i < num.Length; i++)
            {
                num[i] = random.NextDouble() * (500 - 300) + 300;
            }
            i = 0;
            do
            {
                Console.WriteLine(num[i]);
                i++;
            }
            while (i < num.Length);
            if (args.Length == 2) 
            {
                min = double.Parse(args[0]);
                max = double.Parse(args[1]);
            }
            else 
            {
                sel[0] = (float)num[random.Next(num.Length)];
                sel[1] = (float)num[random.Next(num.Length)];
                Console.WriteLine(sel[0] + "-" + sel[1]);
                min = sel[0];
                max = sel[1];
            }
            float res = (float)(random.NextDouble() * (max - min) + min);
            Console.WriteLine("The result is:"+res);
            Array.Sort(num);
            i = 0;
            while (i < num.Length) 
            {
                Console.WriteLine(num[i]);
                i++;
            }
            Console.WriteLine(num.Sum());
            Console.ReadKey();
        }
    }
}
