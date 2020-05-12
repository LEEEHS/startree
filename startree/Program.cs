using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 8; i++)
            {;
                for(int j = 1;j<= 15; j++)
                {
                    if (j <= 8 - i)
                    {
                        Console.Write(" ");

                    }
                    if (j >= 8 + i)
                    {
                        Console.Write(" ");
                    }
                    if (j > 8 - i && j < 8 + i)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
