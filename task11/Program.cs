﻿int number = new Random().Next(100,1000);






Console.WriteLine("Число:" + number);
int numbersecondDigit = number/100;
int numberThirdDigit = number&10;
Console.WriteLine("Число после удаления второй цифры: " + numbersecondDigit + numberThirdDigit);

