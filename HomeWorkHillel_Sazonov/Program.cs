using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkHillel_Sazonov
{
    class Program : Ex_10_1
    {
        /*1. Вывести числа от 1 до 100 в одну строку со следующими изменениями:
- если число кратно 5 то вместо него вывести Hello
- если число кратно 3 то вместо него вывести World
- если число кратно и 3 и 5 то вместо него вывести HelloWorld

2. Заполнить массив из 10 элементов случайными целыми числами от 10(включительно) до 20(включительно).
Вывести среднее арифметическое.

3. Написать метод который проверяет число простое или нет. Если нет вывести все его делители.

4. Написать рекурсивный(!!!) метод который выводит все перестановки строки. Например для строки abc:
abc, acb, bac, bca, cab, cba

5. Сформировать строку которая представляет собой числа от 1 до 30. Каждое число при этом взять в круглые скобки ()

6. Создать 2мерный массив (матрица) M*N  и заполнить его случайными числами.
Отсортировать числа по возрастанию, чтобы с левом верхнем углу было самое маленькое число, справа от него следующее по значению,
итд, в правом нижнем углу самое большое.

7. Задан текстовый файл. Вывести сколько в нём:
a) строк
b) слов
c) символов

9. Задана строка с датой вида "22.01.2019 19:15:00". Написать метод который преобразовывает ее в формат "22 Jan, 7:15 PM".
Предусмотреть обработку ситуации если входящая дата в недопустимом формате.

10. Написать пример для демонстрации модификатра доступа protected.

11. Есть List объектов у каждого из которых 2 поля: int и String.
Удалить те у которых значения int повторяются(оставить по одному из дубликатов).*/
        static void Main(string[] args)
        {
            Ex1();
            Console.WriteLine();

            Ex2();
            Console.WriteLine();

            Ex3();
            Console.WriteLine();

            Ex4();
            Console.WriteLine();

            Ex5();
            Console.WriteLine();

            Ex6();
            Console.WriteLine();

            Ex_7 a = new Ex_7();
            a.Ex7();
            Console.WriteLine();

            Ex_9 b = new Ex_9();
            b.Ex9();
            Console.WriteLine();

            Program c = new Program();
            c.Ex10_R();
            Console.WriteLine();
            //try
            //{
            //    Ex_10_2 d = new Ex_10_2();
            //    d.Ex10_I();________________Error. Так как модификатра доступа protected дает доступ только Наследственным классам
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error");
            //}

            Console.WriteLine();

            Ex_11 e = new Ex_11();
            e.Ex11();

            Console.ReadLine();
        }




        private static void Ex6()
        {
            Console.WriteLine("Ex6");

            int n = 10;
            int m = 5;
            int t;
            Random rnd = new Random();
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(10, 99);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int c = 0; c < n * m; c++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if ((j + 1) < m)
                        {
                            if (array[i, j] > array[i, j + 1])
                            {
                                t = array[i, j];
                                array[i, j] = array[i, j + 1];
                                array[i, j + 1] = t;
                            }
                        }
                        else if ((j + 1) == m && (i + 1) < n)
                        {
                            if (array[i, j] > array[i + 1, 0])
                            {
                                t = array[i, j];
                                array[i, j] = array[i + 1, 0];
                                array[i + 1, 0] = t;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //
        private static void Ex5()
        {
            Console.WriteLine("Ex5");
            string str = "";
            for (int i = 1; i <= 30; i++)
            {
                str += "(" + i.ToString() + ")";
            }
            Console.WriteLine(str);
        }

        //
        private static void Ex4()
        {
            Console.WriteLine("Ex4");
            string str = Console.ReadLine();
            Console.WriteLine();
            char[] ch = str.ToCharArray();
            int l = str.Length;
            int[] array = new int[l];
            rec(array, ch, 0, l);
        }

        private static void rec(int[] array, char[] ch, int m, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (array[j] == i + 1)
                    {
                        break;
                    }
                }
                if (j == m)
                {
                    array[m] = i + 1;

                    if (m < k - 1)
                    {
                        rec(array, ch, m + 1, k);
                    }
                    else
                    {
                        for (int p = 0; p < k; p++)
                        {
                            Console.Write(ch[array[p] - 1]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        //

        static void Ex3()
        {
            Console.WriteLine("Ex3");
            Random rand = new Random();
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(1, 100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            bool k = false;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ": ");
                k = false;
                for (int j = 0; j < a[i]; j++)
                {
                    if (j != 0 && a[i] % j == 0 && j != 1)
                    {
                        Console.Write(j + " ");
                        k = true;
                    }
                }
                if (!k)
                {
                    Console.Write("простое");
                }
                else
                {
                    Console.Write(1 + " " + a[i]);
                }
                Console.WriteLine();
            }
        }

        static void Ex2()
        {
            Console.WriteLine("Ex2");
            Random rand = new Random();
            int[] a = new int[10];
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(10, 20);
                Console.Write(a[i] + " ");
                sum += a[i];
            }
            Console.WriteLine();
            Console.Write(Math.Round((double)(sum / a.Length)));
        }

        static void Ex1()
        {
            Console.WriteLine("Ex1");

            int[] a = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
                if (a[i] % 3 == 0 && a[i] % 5 == 0)
                {
                    Console.Write("HelloWorld ");
                }
                else if (a[i] % 3 == 0)
                {
                    Console.Write("World ");
                }
                else if (a[i] % 5 == 0)
                {
                    Console.Write("Hello ");
                }
                else
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
    }
}
