Console.Clear();
Console.WriteLine("ВВедите число ");
string inputLine = Console.ReadLine();
int inputNumber = int.Parse(inputLine);

Console.WriteLine (sumNums(inputNumber));

int sumNums(int num)
{
    int sum = 1;
    for (int i= 1; i<= inputNumber; i++)
    {
        sum=sum*i;
    }
    return sum;
}


