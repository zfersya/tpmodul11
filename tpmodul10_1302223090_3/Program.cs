using System;
using AljabarLibraries;

namespace tpmodul10_1302223090_3 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Perhitungan kalkulator = new Perhitungan();

            double[] akar = kalkulator.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("\nAkar persamaan kuadrat\t: ");
            for (int i = 0; i < akar.Length; i++)
            {
                Console.Write(akar[i]);
                Console.Write("  ");
            }
            Console.WriteLine("  ");
            
            Console.WriteLine("  ");
            double[] hasilKuadrat = kalkulator.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil hitung kuadrat\t: ");
            for (int i = 0; i < hasilKuadrat.Length; i++)
            {
                Console.Write(hasilKuadrat[i]);
                Console.Write("  ");
            }
            Console.WriteLine("  ");
            Console.ReadKey();
            
        }
    }
}
