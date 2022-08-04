int a = int.Parse(Console.ReadLine());


int D1 = a/10000;
int D2 = (a/1000)%10;
int D4 = (a/10)%10;
int D5 = a%10;

if(D1 = D5 && D2 = D4)
   {
    Console.WriteLine("полиндром");
   }
   else
   {
    Console.WriteLine("не полиндром");
   }

  