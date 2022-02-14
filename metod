using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        public static int Mas (int[] array){
            int c = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    c++;
                }
            }
            Console.WriteLine("сумма:" + c);
            return c;

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Введите кол - во эллементов в массиве: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите {0} эллемент  массива: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }


            Mas(array);
            Console.ReadKey();
        }
    }

}
