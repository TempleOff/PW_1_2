using System;
namespace PW_1_2
{
    class Program
    {
        public static int Convertor(String RimNumber)
        {
            int Number = 0;
            int PlusI = 0;
            Number = 0;
            bool RimNumberTrue = true;
            for (int j = 0; j < RimNumber.Length; j++)
            {
                if (RimNumber[j].Equals('I'))
                {
                    if (j != RimNumber.Length - 1)
                    {
                        PlusI = j + 1;
                        if (RimNumber[PlusI].Equals('V'))
                        {
                            Number += 4;
                            j++;
                        }
                        else if (RimNumber[PlusI].Equals('X'))
                        {
                            Number += 9;
                            j++;
                        }
                        else
                        {
                            Number += 1;
                        }
                    }
                    else
                    {
                        Number += 1;
                    }
                }
                else if (RimNumber[j].Equals('V'))
                {
                    Number += 5;
                }
                else if (RimNumber[j].Equals('X'))
                {
                    PlusI = j + 1;
                    if (j != RimNumber.Length - 1)
                    {
                        if (RimNumber[PlusI].Equals('L'))
                        {
                            Number += 40;
                            j++;
                        }
                        else if (RimNumber[PlusI].Equals('C'))
                        {
                            Number += 90;
                            j++;
                        }
                        else
                        {
                            Number += 10;
                        }
                    }
                    else
                    {
                        Number += 10;
                    }
                }
                else if (RimNumber[j].Equals('L'))
                {
                    Number += 50;
                }
                else if (RimNumber[j].Equals('C'))
                {
                    PlusI = j + 1;
                    if (j != RimNumber.Length - 1)
                    {
                        if (RimNumber[PlusI].Equals('D'))
                        {
                            Number += 400;
                            j++;
                        }
                        else if (RimNumber[PlusI].Equals('M'))
                        {
                            Number += 900;
                            j++;
                        }
                        else
                        {
                            Number += 100;
                        }
                    }
                    else
                    {
                        Number += 100;
                    }
                }
                else if (RimNumber[j].Equals('D'))
                {
                    Number += 500;
                }
                else if (RimNumber[j].Equals('M'))
                {
                    Number += 1000;
                }
                else
                {
                    Console.WriteLine("Введён неверный символ, значение сбросилось");
                    RimNumber = String.Empty;
                    RimNumberTrue = false;
                    break;
                }
            }
            if (RimNumberTrue == true)
            {
                return Number;
            }
            else
            {
                return 0;
            }
        }

        public static bool Palindromtest(String PalindromCheck)
        {
            string ReversePalindormCheck = "";
            for (int i = PalindromCheck.Length - 1; i >= 0; i--)
            {
                ReversePalindormCheck += PalindromCheck[i];
            }
            for (int i = 0; i < 100000; i++)
            {
                if (Convert.ToInt32(ReversePalindormCheck) == i && ReversePalindormCheck != PalindromCheck)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            try
            {
                // Часть 1

                // Функция преобразования
                Console.WriteLine("Введите римское число");
                String RimNumberFunc = Console.ReadLine().ToUpper();
                Console.WriteLine("Число в десятичной системе счисления: " + Convertor(RimNumberFunc));

                // Функция палиндрома
                Console.WriteLine("Введите число");
                String PalindromCheck = Console.ReadLine();
                bool PalindromCheakBool = Palindromtest(PalindromCheck);
                if (PalindromCheakBool == true)
                {
                    Console.WriteLine("Является палиндромом");
                }
                else
                {
                    Console.WriteLine("Не является палиндромом");
                }

                // Часть 2

                // Заполненый двумерный массив
                int[,] ArrayInt = new int[10, 10];
                Random random = new Random();
                for (int i = 0; i < ArrayInt.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInt.GetLength(1); j++)
                    {
                        ArrayInt[i, j] = random.Next(1, 50);
                    }
                }

                for (int i = 0; i < ArrayInt.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInt.GetLength(1); j++)
                    {
                        Console.Write(ArrayInt[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                // Сортирование массива
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        for (int g = 0; g < 10; g++)
                        {
                            if (ArrayInt[j, g] < ArrayInt[j + 1, g])
                            {
                                int temp = ArrayInt[j, g];
                                ArrayInt[j, g] = ArrayInt[j + 1, g];
                                ArrayInt[j + 1, g] = temp;
                            }
                        }
                    }
                }

                // Вывод массива
                for (int i = 0; i < ArrayInt.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInt.GetLength(1); j++)
                    {
                        Console.Write(ArrayInt[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
