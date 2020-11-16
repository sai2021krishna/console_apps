using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class series
    {
        public static void main()
        {
            
            char[] inputn = new char[6];
            int index = 0;
            char[] numb = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] charc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x','y','z' };

                int x = 5;
                Console.WriteLine("Input-->");
                string input = Console.ReadLine();
                if (input.Equals("zzz999"))
                {
                    Console.WriteLine("*invalid* \n--------reached series end--------");

                }
                else
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        inputn[i] = input[i];
                    }

                    string inp_alpha = input.Substring(0, 3);
                    string inp_num = input.Substring(3, 3);

                    while (x >= 0)
                    {
                        if (x < 0)
                        {
                            break;
                        }

                        if (numb.Contains(inputn[x]))
                        {

                            index = Array.IndexOf(numb, inputn[x]);
                            if (index == 9)
                            {
                                index = -1;
                                inputn[x] = numb[index + 1]; x--; continue;
                            }
                            else
                            {
                                inputn[x] = numb[index + 1]; break;
                            }


                        }
                        else
                        {

                            index = Array.IndexOf(charc, inputn[x]);

                            if (index == 25)
                            {
                                index = -1;
                                inputn[x] = charc[index + 1]; x--; continue;
                            }
                            else
                            {
                                inputn[x] = charc[index + 1]; break;
                            }


                        }
                    }
                    Console.Write("Output--> ");
                    for (int j = 0; j <= 5; j++)
                    {
                        Console.Write(inputn[j]);
                    }
                    Console.WriteLine();
                }

            

            Console.ReadKey();

        }
    }
}
