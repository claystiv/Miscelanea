using System;
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

            Salir salir = new Salir();

            Operadores op_0 = new Operadores();
            Operadores ope_1 = new Operadores();
            Operadores ope_2 = new Operadores();
            Operadores ope_3 = new Operadores();
            Operadores ope_4 = new Operadores();
            Operadores ope_5 = new Operadores();
            Operadores ope_6 = new Operadores();
            Operadores ope_7 = new Operadores();
            Operadores ope_8 = new Operadores();
            Operadores ope_exit = new Operadores();

            Condicionales co_0 = new Condicionales();
            Condicionales co_1 = new Condicionales();
            Condicionales co_2 = new Condicionales();
            Condicionales co_3 = new Condicionales();
            Condicionales co_4 = new Condicionales();
            Condicionales co_5 = new Condicionales();
            Condicionales co_6 = new Condicionales();
            Condicionales co_7 = new Condicionales();
            Condicionales co_exit = new Condicionales();

            Ciclos cii_0 = new Ciclos();
            Ciclos cii_1 = new Ciclos();
            Ciclos cii_2 = new Ciclos();
            Ciclos cii_3 = new Ciclos();
            Ciclos cii_4 = new Ciclos();
            Ciclos cii_5 = new Ciclos();
            Ciclos cii_6 = new Ciclos();
            Ciclos cii_7 = new Ciclos();
            Ciclos cii_exit = new Ciclos();


            try
            {
                int me;
                me = Convert.ToInt32(Console.ReadLine());

                switch (me)
                {
                    case 1:


                        op_0.op();
                        int menu_op = Convert.ToInt32(Console.ReadLine());
                        switch (menu_op)
                        {
                            case 1:
                                ope_1.op_1();
                                break;

                            case 2:
                                ope_2.op_2();
                                break;

                            case 3:
                                ope_3.op_3();
                                break;

                            case 4:
                                ope_4.op_4();
                                break;

                            case 5:
                                ope_5.op_5();
                                break;

                            case 6:
                                ope_6.op_6();
                                break;

                            case 7:
                                ope_7.op_7();
                                break;

                            case 8:
                                ope_8.op_8();
                                break;

                            case 9:
                                salir.sali();
                                break;

                            default:
                                ope_exit.op_error();
                                break;
                        }
                        break;

                    case 2:
                        co_0.con();
                        int menu_con = Convert.ToInt32(Console.ReadLine());
                        switch (menu_con)
                        {
                            case 1:
                                co_1.con_1();
                                break;

                            case 2:
                                co_2.con_2();
                                break;

                            case 3:
                                co_3.con_3();
                                break;

                            case 4:
                                co_4.con_4();
                                break;

                            case 5:
                                co_5.con_5();
                                break;

                            case 6:
                                co_6.con_6();
                                break;

                            case 7:
                                co_7.con_7();
                                break;

                            case 9:
                                salir.sali();
                                break;

                            default:
                                co_exit.con_error();
                                break;
                        }
                        break;

                    case 3:
                        cii_0.ci();
                        int menu_cil = Convert.ToInt32(Console.ReadLine());
                        switch (menu_cil)
                        {
                            case 1:
                                cii_1.ci_1();
                                break;

                            case 2:
                                cii_2.ci_2();
                                break;

                            case 3:

                                cii_3.ci_3();
                                break;

                            case 4:
                                cii_4.ci_4();
                                break;

                            case 5:
                                cii_5.ci_5();
                                break;

                            case 6:
                                cii_6.ci_6();
                                break;

                            case 7:
                                cii_7.ci_7();
                                break;

                            case 9:
                                salir.sali();
                                break;

                            default:
                                cii_exit.ci_error();
                                break;
                        }
                        break;

                    case 9:
                        salir.sali();
                        break;

                    default:
                        
                        break;
                }

            } 
            catch (FormatException)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("*          No es un valor valido         *");
                Console.WriteLine("******************************************");

                
            }

        }
    }
}

