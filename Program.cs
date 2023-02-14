bool IsWork = true;

while (IsWork)

{
    Console.WriteLine("Выберите программу:");
    Console.WriteLine("1 - Программа показывает количество чётных чисел в массиве");
    Console.WriteLine("2 - Программа находит сумму элементов, стоящих на нечётных позициях");
    Console.WriteLine("3 - Программа находит разницу между максимальным и минимальным элементами массива");
    Console.WriteLine("-1 - Для завершения работы");
    Console.Write("Введите номер программы: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:
                {
                    Task_1();

                    void Task_1()
                    {
                        Console.WriteLine();
                        int lenght = ReadInt("размер массива");
                        int[] array = GetArray(lenght);
                        Console.WriteLine();
                        Console.WriteLine($"создан массив чисел: {string.Join(", ", array)}");
                        Console.WriteLine();
                        GetPositiveNumbers(array);
                        Console.WriteLine();
                    }

                    int ReadInt(string argument)
                    {
                        Console.Write($"Задайте {argument}: ");
                        int number;

                        while(!int.TryParse(Console.ReadLine(),out number))
                        {
                            Console.WriteLine("вы ввели не число");
                        }
                        
                        return number;
                    }
                    
                    int[] GetArray(int lenght)
                    {
                        int[] array = new int[lenght];
                        Random rnd = new Random();
                        
                        for (int i = 0; i < lenght; i++)
                        {
                            array[i] = rnd.Next(100, 1000);
                        }

                        return array;
                    }

                    void GetPositiveNumbers(int[] array)
                    {
                        int counter = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                counter++;
                            }
                            else
                            {
                            }
                        }

                        Console.WriteLine($"количество чётных чисел в массиве: {counter}");
                    }
                    break;
                }
            case 2:
                {
                    Task_2();

                    void Task_2()
                    {
                        Console.WriteLine();
                        int[] Array = GetArray(ReadInt("размер массива"), ReadInt("минимальное значение элемента массива"), ReadInt("максимальное значение элемента массива"));
                        Console.WriteLine();
                        Console.WriteLine($"создан массив чисел: {string.Join(", ", Array)}");
                        Console.WriteLine();
                        GetSum(Array);
                        Console.WriteLine();
                    }

                    int ReadInt(string argument)
                    {
                        Console.Write($"Задайте {argument}: ");
                        int number;

                        while(!int.TryParse(Console.ReadLine(),out number))
                        {
                            Console.WriteLine("вы ввели не число");
                        }
                        
                        return number;
                    }
                    
                    int[] GetArray(int lenght, int min, int max)
                    {
                        int[] array = new int[lenght];
                        Random rnd = new Random();
                        
                        for (int i = 0; i < lenght; i++)
                        {
                            array[i] = rnd.Next(min, max + 1);
                        }

                        return array;
                    }

                    void GetSum(int[] array)
                    {
                        int sum = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sum += array[i];
                            }
                            else {}
                        }

                        Console.WriteLine($"сумма элементов на нечётных позициях: {sum}");
                    }
                    break;
                }
            case 3:
                {
                    Task_3();

                    void Task_3()
                    {
                        Console.WriteLine();
                        double[] Array = GetArray(ReadInt("размер массива"), ReadInt("минимальное значение элемента массива"), ReadInt("максимальное значение элемента массива"));
                        Console.WriteLine();
                        Console.WriteLine($"создан массив чисел: {string.Join(", ", Array)}");
                        Console.WriteLine();
                        GetDifference(Array);
                        Console.WriteLine();
                    }

                    int ReadInt(string argument)
                    {
                        Console.Write($"Задайте {argument}: ");
                        int number;

                        while(!int.TryParse(Console.ReadLine(),out number))
                        {
                            Console.WriteLine("вы ввели не число");
                        }
                        
                        return number;
                    }

                    double[] GetArray(int lenght, int min, int max)
                    {
                        double[] array = new double[lenght];
                        Random rnd = new Random();
                        
                        for (int i = 0; i < lenght; i++)
                        {
                            array[i] = rnd.Next(min, max + 1);
                        }

                        return array;
                    }

                    void GetDifference(double[] array)
                    {
                        int i = 0;
                        double max = array[i];
                        double min = array[i];
                        for (i = 0; i < array.Length; i++)
                        {
                            if (min > array[i])
                            {
                                min = array[i];
                            }
                            else if (max < array[i])
                            {
                                max = array[i];
                            }
                            else
                            {
                            }
                        }
                        double difference = max - min;

                        Console.WriteLine($"разница между максимальным и минимальным элементами массива: {difference}");
                    }

                    break;
                }
            case -1: IsWork = false; break;
        }
    }
}