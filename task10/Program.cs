string? inputLine = Console.ReadLine();

if(inputLine != null)

{
    int inputNumber = int.Parse(inputLine);

    int outputNumber =  inputNumber%100/10;

    Console.WriteLine(outputNumber);
}