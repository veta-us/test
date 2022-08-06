Console.Write("ВВедите число");

int inputNumber = int.Parse(Console.ReadLine());

void VariantSimple()
{
    int sumOfNumber =0;
    for(int i=1;i<=inputNumber;i++)
    {
        sumOfNumber +=i;
        // sumOfNumber = sumOfNumber +1

    }
Console.WriteLine("сумма чисел от 1 до" +  inputNumber + "=" + sumOfNumber);

}

 VariantSimple();
