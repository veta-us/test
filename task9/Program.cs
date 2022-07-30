System.Random numberSintezator = new System.Random ();


void variant1(System.Random numberSintezator)
{
    int number = numberSintezator.Next(10,100);
 Console.WriteLine(number);

int firstNumber = number/10;
int secondNumber = number%10;

if(firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}
}

void variant2System.Random ()
{
    Console.WriteLine("The random number is: ");
    Console.WriteLine(numberKir);

    string stringNum = numberKir.ToString();

    Console.WriteLine("The biggest digit is : ");
    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else
    {
        Console.WriteLine(stringNum[1]);
    }
}




// вариант 3 
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
 
 Console.WriteLine(digits);

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);

// ладно, с методами я разберусь позже. До момента сборки методов, все у меня получалось и было аккуратно. 