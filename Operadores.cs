using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
    internal class Operadores
    {

        Menu menu = new Menu();

        private int num1 = 0;
        private int num2 = 0;
        private int num3 = 0;
        private double num4 = 0.0;
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
        public double getNum4()
        {
            return this.num4;
        }
        public void setNum4(double num4)
        {
            this.num4 = num4;
        }
        public int getRespuesta()
        {
            return this.respuesta;
        }
        public void setRespuesta(int respuesta)
        {
            this.respuesta = respuesta;
        }

        public void op()
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

            public void op_1()
            {
               
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Área del triangulo");
                    Console.WriteLine("Ingrese un numero para la base del triangulo: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese un numero para la altura del triangulo: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("el area del triangulo es : " + (num1 * num2) / 2);

               
            }

            public void op_2()
            {
                
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Suma de dos numeros");
                    Console.WriteLine("Ingrese un numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese otro numero: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("el resultado de la suma es : " + (num1 + num2));

              
            }
            public void op_3()
            {
                
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Numero elevado al cuadrado");
                    Console.WriteLine("Ingrese un numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("el resultado del numero al cuadrado es : " + Math.Pow(num1, 2));

              
            }
            public void op_4()
            {
                
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Convertir euros a dolares");
                    Console.WriteLine("Ingrese un monto: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num1 + " euros a dolares es : " + (num1 * 1.06 + " USD"));
               
            }
            public void op_5()
            {
               
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Area y perimetro de un cuadrado");
                    Console.WriteLine("Ingrese un numero para el lado del cuadrado: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("el resultado del area del cuadrado es : " + (num1 * 2) + " y el perimetro es: " + (num1 + num1 + num1 + num1));
              
            }
            public void op_6()
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
            public void op_7()
            {
                
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Longitud y area de una circunferencia");
                    Console.WriteLine("Ingrese un numero para el radio de la circunferencia: ");
                    num4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("la longitud de la circunferencia es : " + (2 * 3.1416) * num4 + " y el area es: " + (3.1416 * Math.Pow(num4, 2)));
     
            }
            public void op_8()
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
            public void op_error()
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("*          No es un valor valido         *");
                Console.WriteLine("******************************************");

            menu.menu();
        }
        

    }

}
