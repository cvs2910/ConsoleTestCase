using System;
using System.Collections.Generic;

namespace GAPTestCase1
{
    public class Program
    {
        public Program()
        {

        }

        static void Main(string[] args)
        {
            string result = "";
            var firstString = "abc";
            var secondString = "efg";


            List<string> stringList = new List<string>();
            stringList.Add(firstString);
            stringList.Add(secondString);

            result = Methods.StringMerge(stringList);
            Console.WriteLine("Test Case 1 - Cadenas de string a mezclar:\n1- " + firstString + "\n2- " + secondString+ "\n");
            Console.WriteLine("Resultado Test Case 1: "+result);

            stringList.Clear();
            secondString = "efg123";
            stringList.Add(firstString);
            stringList.Add(secondString);
            result = Methods.StringMerge(stringList);

            Console.WriteLine("\n\nTest Case 2 - Cadenas de string a mezclar:\n1- " + firstString + "\n2- " + secondString + "\n");
            Console.WriteLine("Resultado Test Case 2: " + result);

            stringList.Clear();
            firstString = "abc123456";
            secondString = "efg";
            stringList.Add(firstString);
            stringList.Add(secondString);
            result = Methods.StringMerge(stringList);

            Console.WriteLine("\n\nTest Case 3 - Cadenas de string a mezclar:\n1- " + firstString + "\n2- " + secondString + "\n");
            Console.WriteLine("Resultado Test Case 3: " + result);

            Console.WriteLine("\nOprimir cualquier tecla para terminar el programa...");
            Console.ReadKey();                

        }



    }
}
