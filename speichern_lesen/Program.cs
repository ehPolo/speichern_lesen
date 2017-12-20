using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace speichern_lesen
{
    class Program
    {
        static void Main(string[] args)
        {
            var zeilen = File.ReadAllLines("datensatz.txt");

            File.WriteAllLines("speichern.txt", zeilen);

            //foreach (var item in zeilen)
            //{
            //    Console.WriteLine(item);
            //}

            string[] haustier = zeilen[0].Split(',');
            string[] toedlich = zeilen[1].Split(',');

            foreach (var item in haustier)
            {
                if (toedlich.Contains(item))
                {
                    Console.WriteLine("Tödlich ist: " + item);
                }
            }

            

        }
    }
}
