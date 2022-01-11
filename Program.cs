//Отсортировать массив (использовать любой алгоритм сортировки).
using System;
using System.Collections.Generic;
namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            System.Console.WriteLine("Введите колличество эллементов в массиве: ");
            short num = short.Parse(Console.ReadLine());
            List<short> mas = new List<short>();
            System.Console.WriteLine("Введите значения: ");
            for(short i = 0;i < num;i++){
                mas.Add(short.Parse(Console.ReadLine()));
            }
            for(short i = 0; i < num;i++){
                    System.Console.WriteLine($"Эллементы массива:{mas[i]}");
            }
            
            mas.Sort();
            foreach(short el in mas){
                System.Console.WriteLine("Эллементы массива по возрастанию: {0}",el);
            }
        } 
    }
}