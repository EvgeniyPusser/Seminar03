InputLoop();


InputLoop()
{
  while(true)
  {
   Console.Write("Введите целое число(или q, чтобы вылететь): ");
   string input = Console.ReadLine();

   if(input=="q")
      {
        break;
      }
   ProcessInput(input);
  }

void ProcessInput(string input)
{
  if(int.TryParse(input, out int number))
  {
    Console.WriteLine($"Вы и вправду ввели число: {number}");
    int sumOfDigits = CalculateSumOfDigits(number);
    Console.WriteLine($"Сумма цифр Вашего числа: {sumOfDigits}");

    if(sumOfDigits % 2 == 0)
    {
        Console.WriteLine("Сумма цифр чётная. Вылетаем.");
        Environment.Exit(0);
    }
  }
  else
  {
    Console.WriteLine("Неправильный ввод. Введите целое число.");
  }
}

int CalculateSumOfDigits(int number)
{
    int sum = 0;
    while(number != 0)
    {
      sum += number % 10;
      number /= 10;

    }
    return sum;
}

}
