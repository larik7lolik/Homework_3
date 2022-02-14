// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


bool f1 = false;
bool f2 = false;
bool f3 = false; 
bool f4 = false;

bool x = true;
bool y = true;
if(!(x || y) == (!x && !y))
{
    f1 = true;
}

x = false;
y = true;
if(!(x || y) == (!x && !y)) 
{
    f2 = true;
}

x = true;
y = false;
if(!(x || y) == (!x && !y)) 
{
    f3 = true;
}  

x = false;
y = false;
if(!(x || y) == (!x && !y)) 
{
    f4 = true;
} 

if (f1 && f2 && f3 && f4)
{
    Console.WriteLine("f1 && f2 && f3 && f4");
}
else
{
    Console.WriteLine("не выполнилось f1 && f2 && f3 && f4"); 
}
    


