using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача365
{
    class Program
    {
        static void Main(string[] args)
        {

            //int number = 0;
           
            int brd = 0, male;
            Console.WriteLine("Enter EGN");
            string egn = Console.ReadLine();
            egn = egn.Trim();
            if (egn.Length != 10)
            {
                Console.WriteLine("Incorrect length");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
            int[] r = new int[10];
            for (int i = 0; i < 10; i++) r[i] = egn[i] - '0';
            
                
                int god = r[0] * 10 + r[1];
                int mes = r[2] * 10 + r[3];
                int den = r[4] * 10 + r[5];
                if (mes > 0 && mes < 13)
                {
                    god = 1900 + god;
                }

                else if (mes > 20 && mes < 33)
                {
                    god = 1800 + god;
                    mes = mes - 20;
                }
                else if (mes > 40 && mes < 53)
                {
                    god = 2000 + god;
                    mes = mes - 40;
                }
                else
                {
                    Console.WriteLine("Incorrectly entered month");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                switch (mes)
                {
                    case 1:

                        break;
                    case 3:
                        break;
                    case 5:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 10:
                       
                        break;
                    case 12: brd = 31;
                        break;
                    case 2: if (god % 400 == 0 || god % 4 == 0 && god % 100 != 0)
                        {
                            brd = 29;
                        }
                        else
                        {
                            brd = 28;
                        }
                        break;
                    case 4:
                        break;
                    case 6:
                        break;
                    case 9:
                        break;
                    case 11: brd = 30;

                        break;
                }
                if (den < 1 && den > brd)
                {
                    Console.WriteLine("incorrectly entered day!");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                if (r[8] % 2 == 0)
                {
                    male = 1;
                }
                else
                {
                    male = 0;
                }
                int k = r[0] * 2 + r[1] * 4 + r[2] * 8 + r[3] * 5 + r[4] * 10 + r[5] * 9 + r[6] * 7 + r[7] * 3 + r[8] * 6;
                k = k % 11;
                if (k == 10)
                {
                    k = 0;
                }
                if (k != r[9])
                {
                    Console.WriteLine("incorrectly entered control number");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                if (male == 1)
                {
                    Console.WriteLine("date of birth " + den + "." + mes + "." + god + "god.");
                    Console.WriteLine("date of birth " + den + "." + Month(mes) + " " + god + "god.");
                    Console.WriteLine("date of birth " + Day(mes) + "." + Month(mes) + " " + god + "god.");
                    Console.WriteLine("the man was born on " + den + "." + mes + "." + god + "god.");
                    
                }
                else
                {
                    Console.WriteLine("date of birth " + den + "." + mes + "." + god + "god.");
                    Console.WriteLine("date of birth " + den + "." + Month(mes) + " " + god + "god.");
                    Console.WriteLine("date of birth " + Day(mes) + "." + Month(mes) + " " + god + "god.");
                    Console.WriteLine("the woman was born on" + den + "." + mes + "." + god + "god.");
                }
                Console.ReadKey();
            }

        public static string Month(int mes)
        {
            string mes2 = "";

            switch (mes)
            {
                case 1:
                    mes2 = "qnuari";
                    break;
                case 2:
                    mes2 = "fevruari";
                    break;
                case 3:
                    mes2 = "mart";
                    break;
                case 4:
                    mes2 = "april";
                    break;
                case 5:
                    mes2 = "mai";
                    break;
                case 6:
                    mes2 = "uni";
                    break;
                case 7:
                    mes2 = "uli";
                    break;
                case 8:
                    mes2 = "avgust";
                    break;
                case 9:
                    mes2 = "septemvri";
                    break;
                case 10:
                    mes2 = "oktomvri";
                    break;
                case 11:
                    mes2 = "noemvri";
                    break;
                case 12:
                    mes2 = "dekemvri";
                    break;
            }
            
            return mes2;
        }
        public static string Day(int mes)
        {
            string dey2 = "";

            switch (mes)
            {
                case 1:
                    dey2 = "first";
                    break;
                case 2:
                    dey2 = "second";
                    break;
                case 3:
                    dey2 = "third";
                    break;
                case 4:
                    dey2 = "fourth";
                    break;
                case 5:
                    dey2 = "fifth";
                    break;
                case 6:
                    dey2 = "sixth";
                    break;
                case 7:
                    dey2 = "seventh";
                    break;
                case 8:
                    dey2 = "eighth";
                    break;
                case 9:
                    dey2 = "ninth";
                    break;
                case 10:
                    dey2 = "tenths";
                    break;
                case 11:
                    dey2 = "eleventh";
                    break;
                case 12:
                    dey2 = "twentieth";
                    break;


                case 13:
                    dey2 = "thirties";
                    break;
                case 14:
                    dey2 = "fourteenth";
                    break;
                case 15:
                    dey2 = "fifteenth";
                    break;
                case 16:
                    dey2 = "sixteenth";
                    break;
                case 17:
                    dey2 = "seventeenth";
                    break;
                case 18:
                    dey2 = "eighteenth";
                    break;
                case 19:
                    dey2 = "nineteenth";
                    break;
                case 20:
                    dey2 = "twentieth";
                    break;
                case 21:
                    dey2 = "twenty-one tenths";
                    break;
                case 22:
                    dey2 = "ttwenty-two tenths";
                    break;
                case 23:
                    dey2 = "twenty-three tenths";
                    break;
                case 24:
                    dey2 = "twenty-four tenths";
                    break;
                case 25:
                    dey2 = "twenty-five tenths";
                    break;
                case 26:
                    dey2 = "twenty-six tenths";
                    break;
                case 27:
                    dey2 = "twenty-seven tenths";
                    break;
                case 28:
                    dey2 = "twenty-eight tenths";
                    break;
                case 29:
                    dey2 = "twenty-nine tenths";
                    break;
                case 30:
                    dey2 = "thirty";
                    break;
                case 31:
                    dey2 = "thirty-one";
                    break;
            }

            return dey2;
        }
        }

    }

