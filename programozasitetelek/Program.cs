using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programozasitetelek
{
    class Program
    {
        static void TombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.WriteLine("[{0}] => {1}", i, tomb[i]);
        }

        static bool Eldontes(int[] tomb)
        {
            bool van = false;
            int i = 0;
            while(!van && i < tomb.Length)
            {
                if (tomb[i] % 3 == 0)
                    van = true;
                i++;
            }
            return van;
        }

        static bool Eldontes2(int[] tomb)
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] % 3 != 0)
                i++;
            return i < tomb.Length;
        }

        static bool Eldontes3(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                if (tomb[i] % 3 == 0)
                    return true;
            return false;
        }

        static bool VanEnnelOszthato(int[] tomb, int n)
        {
            for (int i = 0; i < tomb.Length; i++)
                if (tomb[i] % n == 0)
                    return true;
            return false;
        }

        static bool VanEnnelEsMmelOszthato(int[] tomb, int n, int m)
        {
            for (int i = 0; i < tomb.Length; i++)
                if (tomb[i] % n == 0 && tomb[i] % m == 0)
                    return true;
            return false;
        }

        static void Main(string[] args)
        {
            int[] szamok = new int[100];
            Random random = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(1, 101);
            }
            TombKiir(szamok);
            Console.WriteLine("Adj két számot!");
            int oszto1 = int.Parse(Console.ReadLine());
            int oszto2 = int.Parse(Console.ReadLine());

            if(VanEnnelEsMmelOszthato(szamok, oszto1, oszto2))
                Console.WriteLine("Van a tömbben {0}-mal és {1}-val osztható szám.", oszto1, oszto2);
            else
                Console.WriteLine("Nincs a tömbben {0}-mal és {1}-val osztható szám.", oszto1, oszto2);

            Console.ReadKey();
        }
    }
}
