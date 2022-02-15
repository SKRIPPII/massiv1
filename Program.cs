using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {


        public static int[] array(int[] element)  //метод;
        {
            for (int i = 1; i < element.Length; i++)  //цикл перебора эллементов массива начиная со второго;
            {
                for (int j = 0; j < i; j++)  //цикл перебора эллементов масиива с 0 до эллемента i;
                {
                    if (element[j] > element[i]) //условия выполнения присваиавния наибольшего эллемента;
                    {                              
                        element[i] = element[j];
                    }
                }
            }

            foreach (int el in element)
            {
                Console.WriteLine(el);      //перебор и вывод массива 
            }
            return element;
        }



        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;


            int[] element = { 1,0,5,10,2,11,2,8};  //массив;

            array(element);  // вызов метода;


            Console.ReadKey();
            Console.Clear();
        }
    }
}
