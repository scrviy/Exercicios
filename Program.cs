﻿using System;

namespace Exercicios
{
    public class Exercicio
    {
        static void Main(string[] args)
        {
              Console.WriteLine("a" == "a");
              Console.WriteLine("a" == "A");
              Console.WriteLine(1 == 2);

              string myValue = "a";
              Console.WriteLine(myValue == "a");

              string value1 = " a";
              string value2 = "A ";
              Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

              Console.WriteLine("a" != "a");
              Console.WriteLine("a" != "A");
              Console.WriteLine(1 != 2);

              string myValue1 = "a";
              Console.WriteLine(myValue1 != "a");

              Console.WriteLine(1 > 2);
              Console.WriteLine(1 < 2);
              Console.WriteLine(1 >= 1);
              Console.WriteLine(1 <= 1);

              string pangram = "The quick brown fox jumps over the lazy dog.";
              Console.WriteLine(pangram.Contains("fox"));
              Console.WriteLine(pangram.Contains("cow"));

              //* These two lines of code do the same thing
              Console.WriteLine(pangram.Contains("fox") == false);
              Console.WriteLine(!pangram.Contains("fox"));

             string pangram1 = "The quick brown fox jumps over the lazy dog.";
             Console.WriteLine(!pangram1.Contains("fox"));
             Console.WriteLine(!pangram1.Contains("cow"));

            //* Operador condicional
            int saleAmount = 1001;
            int discount = saleAmount > 1000 ? 100 : 50;

            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
        }
    }
}