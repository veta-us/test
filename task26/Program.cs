Console.Clear();
Console.Write("ВВедите число ");

string inputLineNumber = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLineNumber);

int variantChar()
{
    // int numberLeght = 0;
    // char[] myarray = inputLineNumber.ToArray();
    // numberLeght = myarray.Length;
    return inputLineNumber.ToArray().Length;

}

int variantSimple()
{
    int numberLeght = 0;
    int digits=1;
    while(digits<inputNumber)
    {
        digits=digits*10;
        numberLeght++;
    }

    return numberLeght;
}

int result = 0;
result = variantChar();
Console.WriteLine(result);

