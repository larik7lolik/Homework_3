// Задача 22: Найти расстояние между точками в пространстве 2D/3D
 Console.WriteLine("Выберите пространство 2D или 3D:  ");
int num  = int.Parse(Console.ReadLine());
int[] coordinatesInput()
{
   int[] xyz = new int[3];
   Console.Write("Введите координату Х: ");
   xyz[0]=int.Parse(Console.ReadLine());
   Console.Write("Введите координату Y: ");
   xyz[1]=int.Parse(Console.ReadLine());
   Console.Write("Введите координату Z: ");
   xyz[2]=int.Parse(Console.ReadLine());
   return xyz;
}
double range(int[] n1, int[] n2)
{
    return Math.Sqrt((n1[0]-n2[0])*(n1[0]-n2[0]) + (n1[1]-n2[1])*(n1[1]-n2[1]) + (n1[2]-n2[2])*(n1[2]-n2[2]));
}
Console.WriteLine("Первая точка: ");
int[] firstPoint = coordinatesInput();
Console.WriteLine();
Console.WriteLine("Вторая точка: ");
int[] secondPoint = coordinatesInput();
Console.WriteLine();
Console.WriteLine($"Расстояние между указанными точками составляет: {range(firstPoint, secondPoint):f2}");
Console.WriteLine();



