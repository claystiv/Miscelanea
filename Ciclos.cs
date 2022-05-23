using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
    public class Ciclos
    {
        public static void ciclos()
        {
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("*                                                 Ciclos                                                   *");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("*                               Elija una de las siguientes opciones:                                      *");
            Console.WriteLine("*----------------------------------------------------------------------------------------------------------*");
            Console.WriteLine("*                                1. Multiplos de tres que hay entre el 1 y 100                             *");
            Console.WriteLine("*                                       2.Números impares entre el 0 y 100                                 *");
            Console.WriteLine("*                                       3.Números pares entre el 1 y 100                                   *");
            Console.WriteLine("*                                     4.Cuadrado de los números del 1 al 30                                *");
            Console.WriteLine("*                           5.Cuadrado de los cien primeros números naturales con el resultado             *");
            Console.WriteLine("*  6.Dos números (sinedo el primero el menor) con los números comprendidos entre ellos de forma ascendente *");
            Console.WriteLine("*                      7.Sumar todos los números que se digitan por teclado mientras no sea cero           *");
            Console.WriteLine("*                                                 9.Salir                                                  *");
            Console.WriteLine("************************************************************************************************************");

        }
        public static void ci_1(int num1)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Los números del 1 al 100 que son multiplos de 3 son:");
                for (num1 = 3; num1 <= 100; num1 += 3)
                {
                    Console.WriteLine("- " + num1);
                }
            }

            catch (Exception)
            {
                Ciclos.ci_error();
                Ciclos.ci_1(1);
            }
            return;
        }
        public static void ci_2(int num1)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Los números impares entre el 0 y 100 son: ");
                for (num1 = 1; num1 <= 100; num1 += 2)
                {
                    Console.WriteLine("- " + num1);
                }
            }

            catch (Exception)
            {
                Ciclos.ci_error();
                Ciclos.ci_2(1);
            }
            return;
        }
        public static void ci_3(int num1)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Los números pares entre el 1 y 100 son:");
                for (num1 = 2; num1 <= 100; num1 += 2)
                {
                    Console.WriteLine("- " + num1);
                }
            }

            catch (Exception)
            {
                Ciclos.ci_error();
                Ciclos.ci_3(1);
            }
            return;
        }
        public static void ci_4(int num1)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Cuadrado de los números del 1 al 30 son");
                for (num1 = 1; num1 <= 30; num1++)
                {
                    Console.WriteLine("El cuadrado de " + num1 + " = " + Math.Pow(num1, 2));
                }
            }

            catch (Exception)
            {
                Ciclos.ci_error();
                Ciclos.ci_4(1);
            }
            return;
        }
        public static void ci_5(int num1, int num2 = 0)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Suma de los cien primeros cuadrados");

                for (num1 = 0; num1 <= 100; num1++)
                {
                    Console.WriteLine("El cuadrado de " + num1 + " = " + Math.Pow(num1, 2));
                    num2 = num2 + (int)Math.Pow(num1, 2);
                }
                Console.WriteLine("La suma de los cien primeros cuadrados es: " + num2);
            }

            catch (Exception)
            {
                Ciclos.ci_error();
                Ciclos.ci_5(1, 2);
            }
            return;
        }
        public static void ci_6(int num1, int num2, int num3)
        {
            try
            {

                Console.WriteLine("*************************************");
                Console.WriteLine("Cuadrado de los números del 1 al 30 son");
                Console.WriteLine("Ingrese el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segúndo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                for (num3 = num2; num3 <= num2; num3++)
                {
                    Console.WriteLine("Número " + num3);
                }
            }

            catch (Exception)
            {
                Ciclos.ci_error();
                Ciclos.ci_6(1, 2, 3);
            }
            return;
        }
        public static void ci_7(int num1, int num2 = 0)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Suma de todos los números ingresados, mientras no sea cero");
                do
                {
                    Console.WriteLine("Ingrese un número");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    num2 = num2 + num1;
                } while (num1 != 0);
                Console.WriteLine("La suma de todos los números es: " + num2);
            }

            catch (Exception)
            {
                Ciclos.ci_error();
                Ciclos.ci_7(1, 2);
            }
            return;

        }
        public static void ci_error()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*          No es un valor valido         *");
            Console.WriteLine("******************************************");
        }
    }
}
