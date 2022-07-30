Console.WriteLine("Введите число дня недели");

string? inputLine = Console.ReadLine();
if(inputLine != null)

{
    int inputNumber = int.Parse(inputLine);

if((inputNumber == 6)||(inputNumber == 7))
{
    Console.WriteLine("выходной день недели");
}
else
{
    Console.WriteLine("рабочий день недели");
}

}


// string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
