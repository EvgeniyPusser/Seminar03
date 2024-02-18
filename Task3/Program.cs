// class Programm
// {
// static void Main()
// {
   // string input = Console.ReadLine();
  // if (input.Trim().ToLower() == "q")
  // {q
  //   Environment.Exit(0);
  // }
int number1 = GenerateNumber("Введите целове число: ");
//int oldNumber = number1;
int sumOf = CountNumberSum(number1);



  int GenerateNumber()
  {int myNumber = 0;
  while (true)
  {  
    Console.Write("Введите целое число:  ");
    myNumber = Convert.ToInt32(Console.ReadLine());
  }
       return myNumber ;
  }

  int CountNumberSum(int number)
  {
  int count = 0;
  while (number != 0)
  {
    number = number / 10;
    count++;
  }
  //Console.Write(count);
  int sumOf = 0;
  while (oldNumber != 0)
  {
    sumOf = sumOf + oldNumber % 10;
    oldNumber = oldNumber / 10;
  }
  return sumOf;
  }

  Console.Write("Cумма цифр числа равна" + "\t");
  Console.Write(sumOf + "\n");

  if (sumOf % 2 == 0)
  {
    break;

  }
}


