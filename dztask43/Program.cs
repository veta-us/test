int k1 = 0;
int k2 = 0;
int b1 = 0;
int b2 = 0;
int x = 0;
int y = 0;
void Read() //метод считывает значения точек
{
    Console.Write("Введите число k1: ");  // пользователь видит инструкцию, вводит число
    k1 = int.Parse(Console.ReadLine() ?? ""); // переменная стороны считывается с консоли, и преобразуется в число
    Console.Write("Введите число k2: ");
    k2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число b1: ");
    b1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число b2: ");
    b2 = int.Parse(Console.ReadLine() ?? "");

}
void Colculated(int n1, int n2, int c1, int c2) // метод подсчета и сама задача
{
 x = (c2-c1) / (n1 / n2);
 y = n1 * x + c1;
}
void PrintAnswer() // метод печать результаат 
{
    Console.WriteLine(x,y);
}
 Read();
 Colculated(k1, k2, b1, b2);
 PrintAnswer();
