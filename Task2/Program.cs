{
    int arraySize = ReadInt ("Введите величину массива чисел: ");
    double [] array = GenerateArray(arraySize);
    PrintArray(array);


}

int ReadInt(string message){

System.Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
 
}

double [] GenerateArray(int size){


    double[] myArray = new double[size];
    for(int i =0; i < myArray.Length; i++)
    {

myArray[i] = new Random().NextDouble();

    }
    return myArray;
}

 void PrintArray(double [] myArray){
   for(int i = 0; i < myArray.Length; i++){

    Console.Write(myArray[i] + " ");
   }

}