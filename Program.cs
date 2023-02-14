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
                        int lenght = ReadInt("размер массива");
                        int[] array = GetArray(lenght);
                        Console.WriteLine($"создан массив чисел: {string.Join(", ", array)}");
                        GetPositiveNumbers(array);
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
                        int number = ReadInt("число");

                        Calculate2(number);
                    }

                    int ReadInt(string argument)
                    {
                        Console.Write($"Введите {argument}: ");
                        int number;

                        while(!int.TryParse(Console.ReadLine(),out number))
                        {
                            Console.WriteLine("вы ввели не число");
                        }
                        
                        return number;
                    }

                    void Calculate2(int number)
                    {
                        string digitString = number.ToString();
                        int len = digitString.Length;
                        int counter = 0;
                        int temp = number;
                        for (int i = 0; i < len; i ++)
                        {
                            counter = counter + temp % 10;
                            temp = temp / 10;
                        }
                        Console.WriteLine($"сумма цифр в числе {number} = {counter}");
                    }
                    break;
                }
            case 3:
                {
                    Task_3();

                    void Task_3()
                    {
                        int[] Array = GetArray(ReadInt("размер массива"), ReadInt("минимальное значение элемента массива"), ReadInt("максимальное значение элемента массива"));
                        Console.WriteLine($"создан массив чисел: {string.Join(", ", Array)}");
                    }

                    int ReadInt(string argument)
                    {
                        Console.Write($"Введите {argument}: ");
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
                    break;
                }
            case -1: IsWork = false; break;
        }
    }
}