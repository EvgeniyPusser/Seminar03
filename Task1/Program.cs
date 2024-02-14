// System.Console.Write("Введите количество чисел");
// int arraySize = Convert.ToInt32(Console.ReadLine());

// int[] array = new int [arraySize];

// for(int i = 0; i < arraySize; i++)
// {
//   array[i] = new Random().Next(0, 101);
// }
//  for(int i = 0; i < arraySize; i++)
//  {
//    System.Console.Write(array[i] + " ");
   
//  }
//  System.Console.Write("\n");

// System.Console.Write("Введите размер массива");
// int arraySize = Convert.ToInt32(Console.ReadLine());

// double []array = new double[arraySize];

// for(int i = 0; i < arraySize; i++){
//     array[i] = new Random().NextDouble();
// }
// for(int i = 0; i < arraySize; i++){
//     Console.Write(array[i] +"\t");
//     Console.Write(Math.Round(array[i], 2) + "\t");
//     //ToString("0.00" + "\t"));
//     //Console.Write(array[i].ToString("0.000") + "\t");
    
// }




// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Не

//void Main()
{
    int arraySize = ReadInt("Введите количество чисел в массиве: ");

    int[] array = GenerateArray(arraySize, -9, 9);
    PrintArray(array);

    int number = ReadInt("Введите искомое число: ");

    bool numberIsFinded = NumberIsExist(array, number);

    if (numberIsFinded)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] myArray = new int[size];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(leftRange, rightRange + 1); // 0 до 10;
    }

    return myArray;
}


void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
}


bool NumberIsExist(int[] myArray, int number)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] == number)
        {
            return true;
        }
    }

    return false;
}


// Main();




// void Main()
// {
//     int arraySize = ReadInt("Введите количество чисел в массиве: ");
//     int[] array = GenerateArray(arraySize, -9, 9);
//     PrintArray(array);
// }


// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] myArray = new int[size];

//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(leftRange, rightRange + 1); // 0 до 10;
//     }

//     return myArray;
// }


// void PrintArray(int[] arrayForPrint)
// {
//     for (int i = 0; i < arrayForPrint.Length; i++)
//     {
//         System.Console.Write(arrayForPrint[i] + " ");
//     }
// }


// Main();


// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// void Main()
// {
//     int arraySize = ReadInt("Введите количество чисел в массиве: ");
//     int[] array = GenerateArray(arraySize, -10, 10);
//     PrintArray(array);

//     ChangeArray(array);
//     System.Console.WriteLine();
//     PrintArray(array);
// }


// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] myArray = new int[size];

//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(leftRange, rightRange + 1); // 0 до 10;
//     }

//     return myArray;
// }


// void PrintArray(int[] arrayForPrint)
// {
//     for (int i = 0; i < arrayForPrint.Length; i++)
//     {
//         System.Console.Write(arrayForPrint[i] + "\t");
//     }
// }

// void ChangeArray(int[] myArray)
// {
//     for(int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] *= -1; // array[i] = array[i] * -1
//     }
// }








