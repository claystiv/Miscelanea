using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
   internal class Menu
    {
        Operadores operadores = new Operadores();
        Condicionales condicionales = new Condicionales();
        Ciclos ciclos = new Ciclos();
        Salir salir = new Salir();

        int opcion;
        public void menu()
        {

            do
            {

            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("            Bienvenido               ");
            Console.WriteLine("Elija una de las siguinetes opciones: \n1. Operadores \n2. Condicionales \n3. Ciclos \n9. Salir ");

             
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            operadores.op();
                            break;
                        }
                    case 2:
                        {
                            condicionales.con();
                            break;
                        }
                    case 3:
                        {
                            ciclos.ci();
                            break;
                        }
                    case 9:
                        {
                            salir.sali();
                            break;
                        }

                    default: { def(); break; }
                }



            } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 9);

         }

         public void def()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*          No es un valor valido         *");
            Console.WriteLine("******************************************");

            menu();
        }
    }
}
