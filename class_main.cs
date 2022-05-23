﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
    public class Class_Main
    {
        public static void Main()
        {

            try
            {
                int menu;
                Menu.menu();
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Operadores.operadores();
                        int menu_op = Convert.ToInt32(Console.ReadLine());
                        switch (menu_op)
                        {
                            case 1:
                                Operadores.op_1(1, 2);
                                break;

                            case 2:
                                Operadores.op_2(1, 2);
                                break;

                            case 3:
                                Operadores.op_3(1);
                                break;

                            case 4:
                                Operadores.op_4(1);
                                break;

                            case 5:
                                Operadores.op_5(1);
                                break;

                            case 6:
                                Operadores.op_6(1, 2, 3, 4);
                                break;

                            case 7:
                                Operadores.op_7(1);
                                break;

                            case 8:
                                Operadores.op_8(1, 2, 3);
                                break;

                            case 9:
                                Salir.salir();
                                break;

                            default:
                                Operadores.op_error();
                                break;
                        }
                        break;

                    case 2:
                        Condicionales.condicionales();
                        int menu_con = Convert.ToInt32(Console.ReadLine());
                        switch (menu_con)
                        {
                            case 1:
                                Condicionales.co_1(1);
                                break;

                            case 2:
                                Condicionales.co_2(1, 2);
                                break;

                            case 3:
                                Condicionales.co_3(1, 2, 3);
                                break;

                            case 4:
                                Condicionales.co_4(1, 2);
                                break;

                            case 5:
                                Condicionales.co_5(1, 2);
                                break;

                            case 6:
                                Condicionales.co_6(1, 2);
                                break;

                            case 7:
                                Condicionales.co_7(1);
                                break;

                            case 9:
                                Salir.salir();
                                break;

                            default:
                                Condicionales.co_error();
                                break;
                        }
                        break;

                    case 3:
                        Ciclos.ciclos();
                        int menu_cil = Convert.ToInt32(Console.ReadLine());
                        switch (menu_cil)
                        {
                            case 1:
                                Ciclos.ci_1(1);
                                break;

                            case 2:
                                Ciclos.ci_2(1);
                                break;

                            case 3:

                                Ciclos.ci_3(1);
                                break;

                            case 4:
                                Ciclos.ci_4(1);
                                break;

                            case 5:
                                Ciclos.ci_5(1);
                                break;

                            case 6:
                                Ciclos.ci_6(1, 2, 3);
                                break;

                            case 7:
                                Ciclos.ci_7(1);
                                break;

                            case 9:
                                Salir.salir();
                                break;

                            default:
                                Ciclos.ci_error();
                                break;
                        }
                        break;

                    case 9:
                        Salir.salir();
                        break;

                    default:
                        Menu.def();
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("*          No es un valor valido         *");
                Console.WriteLine("******************************************");

                Menu.menu();
            }

        }
    }
}
