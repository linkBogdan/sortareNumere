using System;

namespace Laborator
{
    internal class Program
    {
        /// <summary>
        /// Metoda main citeste valoarea numerelor si declara prim-cinci ca valoare maxima.
        /// </summary>
        static void Main(string[] args) 
        {
            Console.WriteLine("Num 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 3:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 4:");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 5:");
            int num5 = int.Parse(Console.ReadLine());

            int prim = int.MaxValue;
            int doi = int.MaxValue;
            int trei = int.MaxValue;
            int patru = int.MaxValue;
            int cinci = int.MaxValue;

/// <summary>
/// Metoda ModificaOrdinea pentru fiecare numar, muta in jos numerele mai mici decat ultimul adaugat.
/// </summary>

            void ModificaOrdinea (int num)
            {
                if (num < prim)
                {
                    cinci = patru;
                    patru = trei;
                    trei = doi;
                    doi = prim;
                    prim = num;
                }
                else if (num < doi)
                {
                    cinci = patru;
                    patru = trei;
                    trei= doi;
                    doi = num;
                }
                else if(num < trei)
                {
                    cinci = patru;
                    patru= trei;
                    trei = num;
                }
                else if (num < patru)
                {
                    cinci = patru;
                    patru = num;
                }
                else if (num < cinci)
                {
                    cinci = num;
                }
                
            }
            // Folosim metoda creata pentru fiecare numar
            ModificaOrdinea (num1);
            ModificaOrdinea (num2); 
            ModificaOrdinea (num3);
            ModificaOrdinea (num4);
            ModificaOrdinea (num5);
            // console writeline cu ordinea corecta.
            Console.WriteLine($"Ordinea corecta: {prim} {doi} {trei} {patru} {cinci}");
        }
    }
}

