using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chash_overflow_source
{
    internal static class Illustrator
    {

        public static void PrintMenuSection(float CurrentBalance)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|\n|        DASHBORD GENERAL");
            Console.Write("|\n|        Saldo Actual: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"${CurrentBalance}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|\n|        OPCIONES A REALIZAR");
            Console.WriteLine("|\n|    1.- Ingresar Saldo Actual");
            Console.WriteLine("|\n|    e.- Salir del programa");
            Console.WriteLine("-----------------------------------------");
            Console.Write("\n\nIngrese el caracter de la opción deseada: ");
        }

        public static float PrintAddSection()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|\n|        CAPTURANDO SALDO ACTUAL");
            Console.WriteLine("-----------------------------------------");
            Console.Write("|\n|    Ingrese el saldo actual: ");
            float CurrentBalance = Convert.ToSingle(Console.ReadLine());
            return CurrentBalance;
        }
    }
}
