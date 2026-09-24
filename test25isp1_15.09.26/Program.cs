using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test25isp1_15._09._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2
            //string output = "txtFile.txt";
            //string[] txtFile = { "red", "green", "black", "white", "blue", };
            //string text = "";
            //foreach (string str in txtFile)
            //{
            //    text += str +  "\n";
            //}
            //File.WriteAllText(output, text);

            //Задача 3
            //string filePaht = "Zadacha3.txt";
            //string[] lines = File.ReadAllLines(filePaht);
            //int maxLength = 0;

            //foreach (string line in lines)
            //{
            //    if (line.Length > maxLength)
            //    { 
            //        maxLength = line.Length;
            //    }
            //}
            //Console.WriteLine("Самая длинная строка имет количество символов: " + maxLength);
            //Console.ReadKey();
            string path = @"C:\Users\phili\Downloads\Clients.txt";
            string copypath = @"C:\Users\phili\Downloads\My_clients.txt";

            string str = File.ReadAllText(path);

            List<string> list = str.Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains("@"))
                {
                    int r = list[i].IndexOf("@");
                    int len = list[i].Length - r;
                    list[i] = list[i].Remove(r, len);
                    list[i] += "@ptpit.ru";
                }
            }
            string n_str = String.Join(" ", list.ToArray());

            File.WriteAllText(copypath, n_str);
        }
    }
}
