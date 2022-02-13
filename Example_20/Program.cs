//Задача 20: Задать номер четверти, показать диапазоны для возможных координат
 Console.WriteLine("Введите номер четверти: ");
 int num = int.Parse(Console.ReadLine());
 if ( num == 1)
 {
     Console.WriteLine("Координата х > 0 и координата у > 0");
 }
 else if (num == 2)
 {
     Console.WriteLine("Координата х < 0 и координата у < 0");
 }
 else if (num == 3)
 {
     Console.WriteLine("Координата х < 0 и координата у > 0");
 }
 else if (num == 4)
 {
     Console.WriteLine("Координата х < 0 и координата у > 0");
 }
 else
 {
     Console.WriteLine("Координата х = 0 и координата у = 0");
 }
 
