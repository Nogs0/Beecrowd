using System;
using System.Globalization;

namespace NotaseMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdNotas;
            double value;
            double[] notes = { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00, 1.00, 0.5, 0.25, 0.10, 0.05, 0.01 };
            Console.WriteLine("Enter the value: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTAS: ");
            for(int i = 0; i<6; i++)
            {
                qtdNotas = (int)(value / notes[i]);
                Console.WriteLine(qtdNotas+" nota(s) de "+notes[i].ToString("f2", CultureInfo.InvariantCulture));
                value -= qtdNotas*notes[i];
                value = Math.Round(value, 2);
            }
            for (int i = 6; i < 12; i++)
            {
                qtdNotas = (int)(value / notes[i]);
                Console.WriteLine(qtdNotas + " nota(s) de " + notes[i].ToString("f2", CultureInfo.InvariantCulture));
                value -= qtdNotas * notes[i];
                value = Math.Round(value, 2);
            }

        }
    }
}
