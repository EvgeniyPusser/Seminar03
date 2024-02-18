string MyMsg = ReadMsg("Введите целое число");
if(MyMsg == "q")
{
    return;
}

int MyNumber = Convert.ToInt32(MyMsg);
int SumOfFigures = SumOfFigures(MyNumber);
Console.Write(SumOfFigures);

string ReadMsg(string msg)
{
   Console.WriteLine(msg);
   return Console.ReadLine;
}

int SumOfFigures(int number)
{
 int sumOf = 0;
 while(number != 0)
 {
   sumOf = sumOf + number % 10;
   number = sumOf /10;

 }
 return sumOf;
}




