Console.Clear();
Console.Write("ВВедите число ");

int A = int.Parse(Console.ReadLine());

int B = 0;

void Conculated()
{
    
    while(A>0)
    {
        B=B+A%10;
        A=A/10;

    }
    Console.WriteLine(B);

}

Conculated();


