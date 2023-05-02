using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Program
    {
        static double a;
        static double b;
        static double c;

        static double d;
        static double f;
        static double g;
        static void Main()
        {
            Console.WriteLine("Дегтярёв");
            Console.WriteLine("Роман");
            Console.WriteLine("МДБ-20-06");


            Console.WriteLine("Выберите действие (Калькулятор, Таблица)");

            string math = Console.ReadLine();

            if (math == "Калькулятор")
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Введите первое число (введите 'd,f,g' для ввода сохраненной переменной)");
                    string first = Console.ReadLine();
                    if (first == "d")
                    {
                        a = d;
                        Console.WriteLine("Введено значение " + a);
                    }
                    if (first == "f")
                    {
                        a = f;
                        Console.WriteLine("Введено значение " + a);
                    }
                    if (first == "g")
                    {
                        a = g;
                        Console.WriteLine("Введено значение " + a);
                    }
                    else
                    {
                        try
                        {
                            a = double.Parse(first);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка при вводе первой переменной!");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    Console.WriteLine("Введите второе число (введите 'd,f,g' для ввода сохраненной переменной)");
                    string second = Console.ReadLine();
                    if (second == "d")
                    {
                        b = d;
                        Console.WriteLine("Введено значение " + b);
                    }
                    if (second == "f")
                    {
                        b = f;
                        Console.WriteLine("Введено значение " + b);
                    }
                    if (second == "g")
                    {
                        b = g;
                        Console.WriteLine("Введено значение " + b);
                    }
                    else
                    {


                        try
                        {
                            b = double.Parse(second);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка при вводе второй переменной!");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    Console.WriteLine("Введите операцию (+, -, *, /, <, =, >, #)");
                    string act = Console.ReadLine();
                    switch (act)
                    {
                        case "+":
                            c = a + b;
                            Console.WriteLine("Наш ответ: " + c);
                            Console.WriteLine("Хотите сохранить результат?");
                            string plus = Console.ReadLine();
                            if (plus == "Да")
                            {
                                Console.WriteLine("Введите ячейку для сохранения(d,f,g)");
                                string savepl = Console.ReadLine();
                               if (savepl == "d")
                                {
                                    d = c;
                                }
                                if (savepl == "f")
                                {
                                    f = c;
                                }
                                if (savepl == "g")
                                {
                                    g = c;
                                }

                                Console.WriteLine("Результат сохранен!");
                            }
                            break;
                        case "-":
                            c = a - b;
                            Console.WriteLine("Наш ответ: " + c);
                            Console.WriteLine("Хотите сохранить результат?");
                            string minus = Console.ReadLine();
                            if (minus == "Да")
                            {

                                Console.WriteLine("Введите ячейку для сохранения(d,f,g)");
                                string saveml = Console.ReadLine();
                                if (saveml == "d")
                                {
                                    d = c;
                                }
                                if (saveml == "f")
                                {
                                    f = c;
                                }
                                if (saveml == "g")
                                {
                                    g = c;
                                }
                                Console.WriteLine("Результат сохранен!");
                            }
                            break;
                        case "*":
                            c = a * b;
                            Console.WriteLine("Наш ответ: " + c);
                            Console.WriteLine("Хотите сохранить результат?");
                            string umno = Console.ReadLine();
                            if (umno == "Да")
                            {
                                Console.WriteLine("Введите ячейку для сохранения(d,f,g)");
                                string saveul = Console.ReadLine();
                                if (saveul == "d")
                                {
                                    d = c;
                                }
                                if (saveul == "f")
                                {
                                    f = c;
                                }
                                if (saveul == "g")
                                {
                                    g = c;
                                }
                                Console.WriteLine("Результат сохранен!");
                            }
                            break;
                        case "/":
                            if (b == 0)
                            {
                                Console.WriteLine("Infinite");
                            }
                            else
                            {
                                c = a / b;
                                Console.WriteLine("Наш ответ: " + c);
                                Console.WriteLine("Хотите сохранить результат?");
                                string del = Console.ReadLine();
                                if (del == "Да")
                                {
                                    Console.WriteLine("Введите ячейку для сохранения(d,f,g)");
                                    string savedl = Console.ReadLine();
                                    if (savedl == "d")
                                    {
                                        d = c;
                                    }
                                    if (savedl == "f")
                                    {
                                        f = c;
                                    }
                                    if (savedl == "g")
                                    {
                                        g = c;
                                    }
                                    Console.WriteLine("Результат сохранен!");
                                }
                            }
                            break;
                        case "<":
                            if (a < b)
                            {
                                c = a;
                                Console.WriteLine("Наименьшее число: первое, и оно равно " + c);
                            }
                            if (a > b)
                            {
                                c = b;
                                Console.WriteLine("Наименьшее число: второе, и оно равно " + c);
                            }
                            break;
                        case ">":
                            if (a > b)
                            {
                                c = a;
                                Console.WriteLine("Наибольшее число: первое, и оно равно " + c);
                            }
                            if (a < b)
                            {
                                c = b;
                                Console.WriteLine("Наибольшее число: второе, и оно равно " + c);
                            }
                            break;
                        case "=":
                            if (a == b)
                            {
                                c = a;
                                Console.WriteLine("Переменные равны и равны " + c);
                            }
                            else Console.WriteLine("Числа не равны!");
                            break;
                        case "#":

                           
                            int x = (int)a;
                            int y = (int)b;
                            int q = x / 2;
                            int e = y / 2;
                            q = q * 2;
                            e = e * 2;

                            if (a == 0)
                            {
                                Console.WriteLine("Число А равно нулю!");
                            }
                            else
                            {
                                if (x == q)
                                {
                                    Console.WriteLine("Число " + a + " - четное!");
                                }

                                else Console.WriteLine("Число " + a + " - нечетное!");
                            }
                            if (b == 0)
                            {
                                Console.WriteLine("Число В равно нулю!");
                            }
                            else 
                            {
                                if (y == e)
                                {
                                    Console.WriteLine("Число " + b + " - четное!");
                                }

                                else Console.WriteLine("Число " + b + " - нечетное!");
                                }
                            
                            break;
                        default:
                            Console.WriteLine("Ошибка ввода операции!");
                            break;

                    }
                    Console.ReadLine();
                }

               
            }
            if (math == "Таблица")
            {
                Console.WriteLine("Выберите максимальный параметр по вертикали");
              string  fir = Console.ReadLine();
                int o = int.Parse(fir);
                Console.WriteLine("Выберите максимальный параметр по горизонтали");
            string    sec = Console.ReadLine();

                int k = int.Parse(sec);
                for (int i = 1; i < o; i++)
                {
                    for (int j = 1; j < k; j++)
                    {
                        Console.WriteLine($"{i * j}\t");
                       
                    }
                    Console.ReadLine();
                }
                
            }
            
        }
        }
    }


