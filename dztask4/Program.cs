string? inputLineOne = Console.ReadLine();

if(inputLineOne != null) 

{
    int inputNumber = int.Parse(inputLineOne);

    int NumberTwo = 2;

    string lineOutput = "";

    while (NumberTwo < inputNumber)
    {
        lineOutput = lineOutput+NumberTwo+",";
        NumberTwo = NumberTwo+2;
    }
     lineOutput=lineOutput+inputNumber;

Console.WriteLine(lineOutput);
}
