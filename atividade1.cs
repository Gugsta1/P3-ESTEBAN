/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
       
        string[] entradas = Console.ReadLine().Split(' ');
        double N1 = double.Parse(entradas[0]);
        double N2 = double.Parse(entradas[1]);
        double N3 = double.Parse(entradas[2]);
        double N4 = double.Parse(entradas[3]);

        double media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
        Console.WriteLine($"Media: {media:F1}");

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            double notaExame = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {notaExame:F1}");
            media = (media + notaExame) / 2;
            Console.WriteLine(media >= 5.0 ? "Aluno aprovado." : "Aluno reprovado.");
            Console.WriteLine($"Media final: {media:F1}");
        }
    }
}