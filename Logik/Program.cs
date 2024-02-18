bool A = false;
bool B = false;

bool formula = !(A && B) && !( !A || B);
LogicForAll(formula);




void LogicForAll(bool formula){
    
    
   // Console.WriteLine($"A\tB\t!(A && B)");

for (bool A = false; ; A = !A)
{
    for (bool B = false; ; B = !B)
    {
        bool result = formula;
        Console.WriteLine($"{A} \t{B} \t{result}");

        if (B == true)
            break;
    }

    if (A == true)
        break;
}
}



// Console.WriteLine($"A\tB\t!(A && B)");

// for (bool A = false; ; A = !A)
// {
//     for (bool B = false; ; B = !B)
//     {
//         bool result = !(A && B);
//         Console.WriteLine($"{A}\t{B}\t{result}");

//         if (B == true)
//             break;
//     }

//     if (A == true)
//         break;
// }
