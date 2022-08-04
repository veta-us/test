Console.WriteLine("Введите трехзначное число");

string? inputLine = Console.ReadLine();
 
{
   Char[] myArray = inputLine.ToCharArray();

   if(myArray.Length>=3)
   {
    Console.WriteLine(myArray[2]);
   }
   else
   {
    Console.WriteLine("третьей цифры нет");
   }

}







