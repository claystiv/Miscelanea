using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
    
    internal class Condicionales
    {

        Menu menu = new Menu();

        private int num1;
        private int num2;
        private int num3;
        private int respuesta;
        public int getNum1()
        {
            return this.num1;
        }
        public void setNum1(int num1)
        {
            this.num1 = num1;
        }
        public double getNum2()
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


        public void con()
        {
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("*                                              Condicionales                                               *");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("*                                 Elija una de las siguientes opciones:                                    *");
            Console.WriteLine("*----------------------------------------------------------------------------------------------------------*");
            Console.WriteLine("*                                      1.Número positivo o negativo                                        *");
            Console.WriteLine("*                                 2.Número mayor y menor entre dos números                                 *");
            Console.WriteLine("*                                3.Número mayor y menor entre tres números                                 *");
            Console.WriteLine("*                              4.Sumar dos números si A < B o sino restarlos                               *");
            Console.WriteLine("*                                    5.Encontrar el cociente entre A y B                                   *");
            Console.WriteLine("*                       6.sumar A y B si uno de ellos es negativo, sino multiplicarlos                     *");
            Console.WriteLine("*                                         7.Año bisiesto o no                                              *");
            Console.WriteLine("*                                                 9.Salir                                                  *");
            Console.WriteLine("************************************************************************************************************");

        }
        public void con_1()
        {

            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el número");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 0)
            {
                Console.WriteLine("El número ingrsado es positivo");
            }
            else if (num1 == 0)
            {
                Console.WriteLine("El número cero es un número neutral");
            }
            else
            {
                Console.WriteLine("El número ingresado es negativo");
            }
            Console.ReadKey();


        }
        public void con_2()
        {

            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingres el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("El número mayor es: " + num1);
                Console.WriteLine("El número menor es: " + num2);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + num2);
                Console.WriteLine("El número menor es: " + num1);
            }

        }
        public void con_3()
        {

            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("El primer número es mayor que el segundo número");
                Console.WriteLine(num1 + "  Es mayor que  " + num2);
            }
            else
            {
                Console.WriteLine("El segundo número es mayor que el primer número");
                Console.WriteLine(num2 + "  Es mayor que  " + num1);
            }
            if (num1 > num3)
            {
                Console.WriteLine("El primer número es mayor que el tercer número");
                Console.WriteLine(num1 + "  Es mayor que  " + num3);
            }
            else
            {
                Console.WriteLine("El tercer número es mayor que el primer número");
                Console.WriteLine(num3 + "  Es mayor que  " + num1);
            }
            if (num2 > num3)
            {
                Console.WriteLine("El segundo número es mayor que el tercer número");
                Console.WriteLine(num2 + "  Es mayor que  " + num3);
            }
            else
            {
                Console.WriteLine("El tercer número es mayor que el segúndo número");
                Console.WriteLine(num3 + "  Es mayor que  " + num2);
            }

        }
        public void con_4()
        {

            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Como a es mayor que b el resultado de la suma es: ");
                Console.WriteLine(num1 + num2);
            }
            else
            {
                Console.WriteLine("Como a es menor que b el resultado de la resta es: ");
                Console.WriteLine(num1 - num2);
            }

        }
        public void con_5()
        {

            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el primer número: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El cociente de la división es: ");
            Console.WriteLine(num1 / num2);
            if (num2 == 0)
            {
                Console.WriteLine("la operación no se puede realizar");
            }


        }
        public void con_6()
        {

            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if ((num1 < 0) || (num2 < 0))
            {
                Console.WriteLine("Como al menos uno de los número es negativo el valor de la suma es: ");
                Console.WriteLine(num1 + num2);
            }
            else
            {
                Console.WriteLine("Como no hay ningun número negativo el valor de la multiplicación es: ");
                Console.WriteLine(num1 * num2);
            }
        }
        public void con_7()
        {

            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el año: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 / 4 == 0)
            {
                if (num1 / 100 == 0)
                {
                    if (num1 / 400 == 0)
                    {
                        Console.WriteLine("El año " + num1 + " si es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año " + num1 + " no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("El año " + num1 + " si es bisiesto");
                }
            }
            else
            {
                Console.WriteLine("El año " + num1 + " no es bisiesto");
            }

        }
        public void con_error()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*          No es un valor valido         *");
            Console.WriteLine("******************************************");

            menu.menu();
        }
    }
}
