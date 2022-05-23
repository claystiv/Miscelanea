﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
    public class Operadores
    {
        public static void operadores()
        {
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("*                                               OPERADORES                                                 *");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("*                               Elija una de las siguientes opciones:                                      *");
            Console.WriteLine("*----------------------------------------------------------------------------------------------------------*");
            Console.WriteLine("*                                         1.Área del triangulo                                             *");
            Console.WriteLine("*                                         2.Suma de dos numeros                                            *");
            Console.WriteLine("*                                       3.Numero elevado al cuadrado                                       *");
            Console.WriteLine("*                                       4.Convertir euros a dolares                                        *");
            Console.WriteLine("*                                    5.Area y perimetro de un cuadrado                                     *");
            Console.WriteLine("*                                      6.Area y volumen de un cilindro                                     *");
            Console.WriteLine("*                                 7.Longitud y area de una circunferencia                                  *");
            Console.WriteLine("*                                       8.Promedio de tres numeros                                         *");
            Console.WriteLine("*                                                 9.Salir                                                  *");
            Console.WriteLine("************************************************************************************************************");

        }

        public static void op_1(int num1, int num2)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Área del triangulo");
                Console.WriteLine("Ingrese un numero para la base del triangulo: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un numero para la altura del triangulo: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("el area del triangulo es : " + (num1 * num2) / 2);

            }
            catch (Exception)
            {
                Operadores.op_error();
                Operadores.op_1(1, 2);
            }
            return;
        }

        public static void op_2(int num1, int num2)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Suma de dos numeros");
                Console.WriteLine("Ingrese un numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("el resultado de la suma es : " + (num1 + num2));

            }
            catch (Exception)
            {
                Operadores.op_error();
                Operadores.op_2(1, 2);
            }
            return;
        }
        public static void op_3(int num1)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Numero elevado al cuadrado");
                Console.WriteLine("Ingrese un numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("el resultado del numero al cuadrado es : " + Math.Pow(num1, 2));

            }
            catch (Exception)
            {
                Operadores.op_error();
                Operadores.op_3(1);
            }
            return;
        }
        public static void op_4(double num1)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Convertir euros a dolares");
                Console.WriteLine("Ingrese un monto: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 + " euros a dolares es : " + (num1 * 1.06 + " USD"));
            }
            catch (Exception)
            {
                Operadores.op_error();
                Operadores.op_4(1);
            }
            return;
        }
        public static void op_5(int num1)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Area y perimetro de un cuadrado");
                Console.WriteLine("Ingrese un numero para el lado del cuadrado: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("el resultado del area del cuadrado es : " + (num1 * 2) + " y el perimetro es: " + (num1 + num1 + num1 + num1));
            }
            catch (Exception)
            {
                Operadores.op_error();
                Operadores.op_5(1);
            }
            return;
        }
        public static void op_6(int num1, int num2, int num3, double num4)
        {
            try
            {

                Console.WriteLine("*************************************");
                Console.WriteLine("Area y volumen de un cilindro");
                Console.WriteLine("Ingrese un numero para la altura del cilindro: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un numero para la base del cilindro: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                num3 = (num2 / 2);
                num4 = (2 * 3.1416 * num3 * num1) + (2 * 3.1416 * Math.Pow(num3, 2));
                Console.WriteLine("el resultado del area del cilindro es : " + num4 + " y el volumen es: " + ((3.1416 * Math.Pow(num3, 2)) * num1));
            }
            catch (Exception)
            {
                Operadores.op_error();
                Operadores.op_6(1, 2, 3, 4);
            }
            return;
        }
        public static void op_7(double num1)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Longitud y area de una circunferencia");
                Console.WriteLine("Ingrese un numero para el radio de la circunferencia: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("la longitud de la circunferencia es : " + (2 * 3.1416) * num1 + " y el area es: " + (3.1416 * Math.Pow(num1, 2)));
            }
            catch (Exception)
            {
                Operadores.op_error();
                Operadores.op_7(1);
            }
            return;
        }
        public static void op_8(int num1, int num2, int num3)
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Promedio de tres numeros");
                Console.WriteLine("Ingrese un numero : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero : ");
                num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("el promedio de los 3 numeros es : " + (num1 + num2 + num3)/ 3);
            }
            catch (Exception)
            {
                Operadores.op_error();
                Operadores.op_8(1, 2, 3);
            }
            return;
        }
        public static void op_error()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*          No es un valor valido         *");
            Console.WriteLine("******************************************");
        }

    }

}
