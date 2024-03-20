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
          int temporar;
            temporar = a;
            a = b;
            b = temporar;
          Console.WriteLine("Dupa interschimbare valoarea primului numar este " + a + " iar valoarea celui de-al doilea numar este " + b + " .");
        }
    }
}