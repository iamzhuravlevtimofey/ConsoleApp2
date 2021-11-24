using System;
using System.Linq;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string curFile = "t.txt";
            Console.WriteLine(File.Exists(curFile) ? "Файл уже создан" : "Создан файл 't.txt'");
            StreamWriter sw = new StreamWriter("t.txt");
            Console.WriteLine("Введите массив через запятую");
            try
            {
                string mass = Console.ReadLine();
                float[] mass1;
                mass1 = mass.Split(',').Select(float.Parse).ToArray();

                Console.WriteLine("Введите N:");
                int n = Convert.ToInt32(Console.ReadLine());

                mass1 = mass1.Where(i => Math.Pow(i, 2) > n).ToArray();

                for (int i = 0; i < mass1.Length; i++)
                {
                    Console.WriteLine("Число - {0}, Ind - {1}, Kv - {2}", mass1[i], i, Math.Pow(mass1[i], 2));
                    sw.WriteLine("Число - {0}, Ind - {1}, Kv - {2}", mass1[i], i, Math.Pow(mass1[i], 2));
                }
                sw.Close();
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Введите числа");
                Console.ReadLine();
            }
        }
    }
}
