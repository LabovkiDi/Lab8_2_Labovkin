using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_2_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Admin/source/repos/C#/Lab_8/Lab8_2_Labovkin/8_2.txt";
            if (!File.Exists(path))
            {
                File.Create(path); /*создание файла, если такого не существует*/
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                int[] array = new int[10];
                Random rand = new Random();
                foreach (int i in array)
                {
                    array[i] = rand.Next(1, 100);

                    sw.WriteLine("{0}", array[i]); /*запись случайных чисел в файл*/
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                double sum = 0;  /*сумма чисел*/
                //построчно считываем файл
                while ((line = sr.ReadLine()) != null)
                {
                    //переводим считанное число из строки и считаем сумму
                    sum += Convert.ToInt32(line);
                }
                Console.WriteLine("Сумма элементов файла={0}", sum);
            }
            Console.ReadKey();
        }
    }
}
