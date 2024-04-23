using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__6_klases_2
{
    internal class Program
    {
        public class Punkts
        {
            public int X;
            public int Y;
            public string Krāsa;

            public void Reģistret()
            {
                Console.Write("Ievadi X: ");
                X = int.Parse(Console.ReadLine());

                Console.Write("Ievadi Y: ");
                Y = int.Parse(Console.ReadLine());

                Console.Write("Ievadi krāsu: ");
                Krāsa = Console.ReadLine();
            }

            public void Izvadīt()
            {
                Console.WriteLine($"X: {X}");
                Console.WriteLine($"Y: {Y}");
                Console.WriteLine($"Krāsa: {Krāsa}");
            }
        }

        public class Linija
        {
            public Punkts A;
            public Punkts B;
            public string Krāsa;

            public void Reģistrēt()
            {
                Console.WriteLine("Punktam A");
                A = new Punkts();
                A.Reģistret();

                Console.WriteLine("Punktam B");
                B = new Punkts();
                B.Reģistret();

                Console.Write("Līnijas krāsa: ");
                Krāsa = Console.ReadLine();
            }

            public double Garums()
            {
                // Aprēķina līnijas garumu

                double garums = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
                return garums;
            }

            public void Izvadīt()
            {
                Console.WriteLine("Punktam A");
                A.Izvadīt();

                Console.WriteLine("Punktam B");
                B.Izvadīt();

                Console.WriteLine($"Garums: {Garums()}");

                Console.WriteLine($"Līnijas krāsa: {Krāsa}");
            }

        }
        public static void Main(string[] args)
        {
            // Main funkcijā izveidot vismaz Līniju masīvu, masīva izmēru ievada lietotājs.

            Console.Write("Ievadi līniju skaitu: ");
            int skaits = int.Parse(Console.ReadLine());
            Linija[] linijas = new Linija[skaits];

            for (int i = 0; i < skaits; i++)
            {
                Console.WriteLine($"Reg {i + 1}");

                linijas[i] = new Linija();
                linijas[i].Reģistrēt();
            }

            Console.WriteLine("Reģistrētās līnijas:");

            for (int i = 0; i < skaits; i++)
            {
                Console.WriteLine($"Līnijai {i + 1}");
                linijas[i].Izvadīt();
                Console.WriteLine();
            }
        }
    }
}

