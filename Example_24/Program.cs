// Задача 24: Найти кубы чисел от 1 до N
int num = 10;
int y = 1;
int x = 1;
while (x <= num)
{
  Console.Write(x + "\t");
  x++;
}
Console.WriteLine();
while (y <= num)
{
  Console.Write(y*y*y + "\t");
  y++;
}

