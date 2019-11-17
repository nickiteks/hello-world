using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evm_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] work = new int[4, 5];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    work[i, j] = rnd.Next(2);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(work[i, j]+"  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("введите форму");

           string quest = Console.ReadLine();
            string result = "( ";
            string exit = null;

            if (quest == "днф")
            {
                for (int i = 0; i < 4; i++)
                {
                    if (work[i, 4] == 1)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (work[i, j] == 1)
                            {
                                result = result + "x" + j + " ^ ";
                            }
                            if (work[i, j] == 0)
                            {
                                result = result + "¬x" + j + " ^ ";
                            }
                        }
                        result = result + ") V ";
                        exit = exit + result;
                        result = "( ";
                    }
                    if (work[i, 4] == 0)
                    {
                        for (int j = 0; j < 4; j++)
                        {

                            if (work[i, j] == 1)
                            {
                                result = result + "¬x" + j + " ^ ";
                            }
                            if (work[i, j] == 0)
                            {
                                result = result + "x" + j + " ^ ";
                            }
                        }
                        result = result + ") V ";
                        exit = exit + result;
                        result = "( ";
                    }
                }
                Console.WriteLine(exit);
                Console.ReadLine();
            }
            if (quest == "кнф")
            {
                for (int i = 0; i < 4; i++)
                {
                    if (work[i, 4] == 1)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (work[i, j] == 1)
                            {
                                result = result + "x" + j + " V ";
                            }

                            if (work[i, j] == 0)
                            {

                                result = result + "¬x" + j + " V ";
                            }
                        }
                        result = result + ") ^ ";
                        exit = exit + result;
                        result = "( ";
                    }
                    if (work[i, 4] == 0)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (work[i, j] == 1)
                            {

                                result = result + "¬x" + j + " V ";
                            }
                            if (work[i, j] == 0)
                            {
                                result = result + "x" + j + " V ";

                            }
                        }
                        result = result + ") ^ ";
                        exit = exit + result;
                        result = "( ";
                    }
                }
                Console.WriteLine(exit);
              //  Console.ReadLine();
            }


            string[] mystring = exit.Split(' ');

            for (int i = 0; i < mystring.Length; i++)
            {
                string s = Convert.ToString(i);

                if (mystring[i] == "x"+s)
                {
                    Console.WriteLine("есть");
                    mystring[i-1] = null;
                    mystring[i] = null;
                }

            }
            for (int i = 0; i < mystring.Length; i++)
            {
                Console.Write(mystring[i]+" ");
            }

            Console.ReadLine();
        }
    }
}
