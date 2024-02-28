
int ArraySize = ReadNumber("Введите размер массива" + "\n");
int[] array = arrayBuilds(ArraySize, 23, 56);
PrintArray(array);

int number = ReadNumber("Введите искомое число" + "\n");
bool soughtNumber = findNumber(array, number);

if(soughtNumber){

    Console.Write("Suuuuper!" + "\n");
    
}
else{

    Console.Write("o...No..." + "\n");
   
}


int ReadNumber(string words)
{
System.Console.Write(words);
return Convert.ToInt32(Console.ReadLine());
}

int[] arrayBuilds(int size, int LeftEdge, int RightEdge)
{
    int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    Random rand = new Random();
    array[i] = rand.Next(LeftEdge, RightEdge);
}
    return array;
 }
// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] myArray = new int[size];

//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(leftRange, rightRange + 1); // 0 до 10;
//     }

//     return myArray;
bool findNumber(int[] array,int number ){

for(int i = 0; i < array.Length; i++){
    if(array[i] == number){
        return true;
        //Console.Write("Suuuuper!");
        //break;
    }
}return false;
//Console.Write("o...No...");


}
 


// Console.Write("Введите искомое число");
// int WantedNumber = Convert.ToInt32(Console.ReadLine());

// bool Finder = false;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == WantedNumber)
//     {
//         Finder = true;
//         break;

//     }

// }if(Finder == false){
//     Console.Write(" Nooo");
// }else{
//     Console.Write("Yes!!");
//}

// if (bool es == true){
//     Console.Write("Yes");
// }
//    else
// {
//     Console.Write("No");
// }
void PrintArray(int [] ArrayForPrint)
{ Console.Write("Числа массива:   ");
for (int i = 0; i < array.Length; i++)
{
   Console.Write(array[i] + "\t");
}
}
  Console.Write("\n");

// 

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

//void Main()
// {
//     int arraySize = ReadInt("Bведите количество чисел в массиве: ");
//     int[] array = GenerateArray(arraySize, 0, 1000);
//     array[0] = 91;
//     PrintArray(array);
//     System.Console.WriteLine("\n" + CountNumbers(array, 1, 7));
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] myArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return myArray;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");;
// }

// int CountNumbers(int[] array, int lastDigit, int divideBy)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 10 == lastDigit && array[i] % divideBy == 0)
//         {
//             count++;
//         }
//     }

//     return count;
// }

// Main();

//string.Join("", array);
//string.Concat(array);


// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// void Main()
// {
//     // int arraySize = ReadInt("Bведите количество чисел в массиве: ");
//     int[] array = GenerateArray(7, 0, 9);
//     PrintArray(array);
//     int result = Convert.ToInt32(string.Concat(array));
//     System.Console.WriteLine(result);
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] myArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return myArray;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");; // {1, 2, 8, 9} -> join "1, 2, 8, 9" -> concat "1289"
// }

// Main();

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// void Main()
// {
//     int arraySize = ReadInt("Bведите количество чисел в массиве: ");
//     int[] array = GenerateArray(7, 0, 9);
//     PrintArray(array);
//     System.Console.WriteLine(ArrayToIntNumber(array));
// }

// int ArrayToIntNumber(int[] myArray)
// {
//     int resultNumber = 0;

//     for(int i = 0; i < myArray.Length; i++)
//     {
//         resultNumber += myArray[i] * (int) Math.Pow(10, myArray.Length - 1 - i);
//     }

//     return resultNumber;
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] myArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return myArray;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");; // {1, 2, 8, 9} -> join "1, 2, 8, 9" -> concat "1289"
// }

// Main();
//Math.Round(787.898989, 8);
