using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkHillel_Sazonov
{
    class Ex_7
    {
        public void Ex7()
        {
            Console.WriteLine("Ex7");
            string[] ast = File.ReadAllLines("text1.txt");
            Console.WriteLine("a)количество строк: " + ast.Length);
            int sum = 0;
            for (int i = 0; i < ast.Length; i++)
            {
                string[] s = ast[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                sum += s.Length;
            }
            Console.WriteLine("b)количество слов: " + sum);
            int count = 0;
            char j = '!';
            while (j <= '?')
            {
                for (int i = 0; i < ast.Length; i++)
                {
                    for (int k = 0; k < ast[i].Length; k++)
                    {
                        if (ast[i][k] == j)
                        {
                            count++;
                        }
                    }
                }
                if (j == '/')
                {
                    j = ':';
                }
                else
                {
                    j++;
                }
            }
            Console.WriteLine("c)количество символов: " + count);

        }
    }
}
