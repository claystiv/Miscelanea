﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
    public class Menu
    {
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Elija una de las siguinetes opciones: \n1. Operadores \n2. Condicionales \n3. Ciclos \n9. Salir ");
        }
        public static void def()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*          No es un valor valido         *");
            Console.WriteLine("******************************************");

            Menu.menu();
        }
    }
}