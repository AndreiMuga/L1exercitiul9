using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex9
/*
 * Scrieti un program care interschimba valoarea a doua variabile intregi.
 */
{
    public class Program 
    { public static void Main(string[] args) 
        { int a;
          int b;
          Console.WriteLine("Introduceti primul numar: "); 
          a = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Introduceti al doilea numar: "); 
          b= Convert.ToInt32(Console.ReadLine());
          int aTransformatInB;
          int bTransformatInA;
          aTransformatInB = b;
          bTransformatInA = a;
          Console.WriteLine("Dupa interschimbare valoarea primului numar este " + aTransformatInB + " iar valoarea celui de-al doilea numar este " + bTransformatInA + " .");
        }
    }
}