Console.Write("ВВедите число ");

int inputNumber = int.Parse(Console.ReadLine());

void VariantSimple()
{
    int sumOfNumber =0;
    for(int i=1;i<=inputNumber;i++)
    {
        sumOfNumber +=i;
        // sumOfNumber = sumOfNumber +1

    }
Console.WriteLine("сумма чисел от 1 до " +  inputNumber + " = " + sumOfNumber);
}

void VariantGauss()
{
    int sumOfNumber =0;
    sumOfNumber = ((1+inputNumber)*inputNumber)/2;

Console.WriteLine("сумма чисел от 1 до " +  inputNumber + " = " + sumOfNumber);
}
 
 
 VariantSimple();
 VariantGauss();
