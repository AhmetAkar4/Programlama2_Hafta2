using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru 2
            string kelime = "game";
            Stack<char> harfStack = new Stack<char>();

            foreach (char harf in kelime)
                harfStack.Push(harf);

            Console.Write("Ters çevrilmiş: ");
            while (harfStack.Count > 0)
                Console.Write(harfStack.Pop());
            Console.WriteLine("\n");

            // Soru 5
            string metin = "(Oyun(Geliştirme))";
            Stack<char> parantezStack = new Stack<char>();
            bool dengeli = true;

            foreach (char c in metin)
            {
                if (c == '(')
                    parantezStack.Push(c);
                else if (c == ')')
                {
                    if (parantezStack.Count == 0)
                    {
                        dengeli = false;
                        break;
                    }
                    parantezStack.Pop();
                }
            }

            if (parantezStack.Count > 0) dengeli = false;
            Console.WriteLine($"Parantezler dengeli mi?: {dengeli}\n");

            // Soru 4 - PriorityQueue Olmayan Sürümler İçin Alternatif Çözüm
            List<KeyValuePair<string, int>> aiGorevleri = new List<KeyValuePair<string, int>>();
            aiGorevleri.Add(new KeyValuePair<string, int>("Run", 0));
            aiGorevleri.Add(new KeyValuePair<string, int>("Attack", 1));
            aiGorevleri.Add(new KeyValuePair<string, int>("Chase", 2));
            aiGorevleri.Add(new KeyValuePair<string, int>("Patrol", 5));

            // Öncelik değerine (Value) göre küçükten büyüğe sıralıyoruz
            var siraliGorevler = aiGorevleri.OrderBy(g => g.Value).ToList();

            Console.WriteLine("Görev Sırası:");
            foreach (var gorev in siraliGorevler)
            {
                Console.WriteLine($"{gorev.Key} ({gorev.Value})");
            }
        }
    }
}