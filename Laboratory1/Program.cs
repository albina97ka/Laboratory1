using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x в диапазоне |x|<1:");
            double x = double.Parse(Console.ReadLine());

            if (Math.Abs(x) >= 1)
            {
                Console.WriteLine("Введите число меньше 1");
            }
            else
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());

                double sum = 0;
                int verh = 1;
                int niz = 1;
                for (int i = n; i > 0; i--)
                {
                    for (int j = 1; j == n; j++)
                    {
                        if (j % 2 == 0)
                        {
                            niz = j * niz;
                        }
                        else
                        {
                            verh = j * verh;
                        }
                    }
                    sum += (verh * (2 * i - 1) * Math.Pow(x, (2 * i + 1))) / (niz * 2 * i * (2 * i + 1));
                }

                Console.WriteLine(Math.PI / 2 - sum);
            }
        }
    }
