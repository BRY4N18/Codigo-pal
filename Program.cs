using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palapalin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un aplicativo que determine si una palabra o frase ingresada por el usuario es un palíndromo (se lee igual de izquierda a derecha que de derecha a izquierda).
            // Ignorar los espacios en blanco. Ejemplo de frase palíndromo: Somos o no somos
            string pal;
            int cont = 0;
            Console.WriteLine("Ingrese una frase: ");
            pal=Console.ReadLine();
            string[] espa = new string[pal.Length];
            letras(espa, pal);
            Console.ReadKey();
        }
        static void letras(string[] pacio, string pa)
        {
            int cont = 0, z = 0, cint = 0;
            pa=pa.ToLower();
            for (int i = 0; i < pa.Length; i++)
            {
                pacio[i] = pa.Substring(i, 1);
                if (pacio[i] == " ") cont++;
            }
            string[] le = new string[pacio.Length-cont];
            foreach (var item in pacio)
            {
                if (item!=" ")
                {
                    le[z] = item;
                    z++;
                }
            }
            int y = le.Length-1;
            string[] lef = new string[pacio.Length - cont];
            for (int i = 0; i < le.Length; i++)
            {
                lef[i] = le[y]; y--;
            }
            for (int i = 0; i < le.Length; i++)
            {
                if (le[i] == lef[i]) cint++;               
            }
            if (cint==le.Length) Console.WriteLine("Esta frase es palindromo");
            else Console.WriteLine("Esta frase no es palindroma");
        }
    }
}
