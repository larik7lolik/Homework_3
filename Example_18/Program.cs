// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


bool f1 = false;
bool f2 = false;
bool f3 = false; 
bool f4 = true;

bool x = true;
bool y = true;
if(!(x || y) == (!x && !y))
{
    f1 = false;
}

x = false;
y = true;
if(!(x || y) == (!x && !y)) 
{
    f2 = false;
}

x = true;
y = false;
if(!(x || y) == (!x && !y)) 
{
    f3 = false;
}  

x = false;
y = false;
if(!(x || y) == (!x && !y)) 
{
    f4 = true;
} 

/* bool f1 = true;
bool f2 = true;
bool f3 = true; 
bool f4 = true; */

if (f1 && f2 && f3 && f4)
{
    Console.WriteLine("f1 && f2 && f3 && f4");
}
else
{
    Console.WriteLine("не выполнилось f1 && f2 && f3 && f4"); 
}
    

/* if(!x)  // отрицание
    Console.WriteLine("!x");
else
    Console.WriteLine("не !x");


if(x && y)  // логическое И
    Console.WriteLine("x && y");
else
    Console.WriteLine("не x && y");


if(x || y)  //логическое ИЛИ
    Console.WriteLine("x || y");
else
    Console.WriteLine("не x || y"); */
