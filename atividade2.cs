/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections.Generic;

class Program animais 
{
    static void Main(string[] args)
    {
        var animais = new Dictionary<(string, string, string), string>
        {
            { ("vertebrado", "ave", "carnivoro"), "ÁGUIA" },
            { ("vertebrado", "ave", "onivoro"), "POMBA" },
            { ("vertebrado", "mamifero", "onivoro"), "HOMEM" },
            { ("vertebrado", "mamifero", "herbivoro"), "VACA" },
            { ("invertebrado", "inseto", "hematofago"), "PULGA" },
            { ("invertebrado", "inseto", "herbivoro"), "LAGARTA" },
            { ("invertebrado", "anelideo", "hematofago"), "SANGUESSUGA" },
            { ("invertebrado", "anelideo", "onivoro"), "MINHOCA" }
        };

        string entrada1 = Console.ReadLine().Trim().ToLower();
        string entrada2 = Console.ReadLine().Trim().ToLower();
        string entrada3 = Console.ReadLine().Trim().ToLower();

        if (animais.TryGetValue((entrada1, entrada2, entrada3), out string animal))
        {
            Console.WriteLine(animal);
        }
        else
        {
            Console.WriteLine("Animal não encontrado");
        }
    }
}