using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
    internal class Ciclos
    {

        Menu menu = new Menu();

        private int num1 = 0;
        private int num2 = 0;
        private int num3 = 0;
        private int respuesta = 0;
        public int getNum1()
        {
            return this.num1;
        }
        public void setNum1(int num1)
        {
            this.num1 = num1;
        }
        public int getNum2()
        {
            return this.num2;
        }
        public void setNum2(int num2)
        {
            this.num2 = num2;
        }
        public int getNum3()
        {
            return this.num3;
        }
        public void setNum3(int num3)
        {
            this.num3 = num3;
        }
        public int getRespuesta()
        {
            return this.respuesta;
        }
        public void setRespuesta(int respuesta)
        {
            this.respuesta = respuesta;
        }


        public void ci()
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
        public void ci_1()
        {
            
                Console.WriteLine("*************************************");
                Console.WriteLine("Los números del 1 al 100 que son multiplos de 3 son:");
                for (num1 = 3; num1 <= 100; num1 += 3)
                {
                    Console.WriteLine("- " + num1);
                }
            


        }
        public void ci_2()
        {
            
                Console.WriteLine("*************************************");
                Console.WriteLine("Los números impares entre el 0 y 100 son: ");
                for (num1 = 1; num1 <= 100; num1 += 2)
                {
                    Console.WriteLine("- " + num1);
                }
            
        }
        public void ci_3()
        {
            
                Console.WriteLine("*************************************");
                Console.WriteLine("Los números pares entre el 1 y 100 son:");
                for (num1 = 2; num1 <= 100; num1 += 2)
                {
                    Console.WriteLine("- " + num1);
                }
            
        }
        public void ci_4()
        {
            
                Console.WriteLine("*************************************");
                Console.WriteLine("Cuadrado de los números del 1 al 30 son");
                for (num1 = 1; num1 <= 30; num1++)
                {
                    Console.WriteLine("El cuadrado de " + num1 + " = " + Math.Pow(num1, 2));
                }
       
        }
        public  void ci_5()
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
        public void ci_6()
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
        public void ci_7()
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
        public void ci_error()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*          No es un valor valido         *");
            Console.WriteLine("******************************************");

            menu.menu();
        }
    }
}
