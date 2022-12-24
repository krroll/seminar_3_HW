// Задача 19: Напишите программу, которая
// принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом
// 14212 - нет
// 23432 - да
// 12821 - да

// Console.WriteLine ("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Num1 = number/10000; // Находим первое число
// int Num5 = number %10; // Находим пятое число
// int Num2 = (number/1000)%10; // Находим второе число
// int Num4 = (number%100) / 10; // Находим четвёртое число

// if ((Num1 == Num5) && (Num2 == Num4))
//     Console.WriteLine ("Число является палиндромом!");
// else
//     Console.WriteLine ("Число НЕ является палиндромом!");
//-------------------------------------------------

//Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек 
// и находит координаты между ними
// A (3,6,8); B(2,1,7) - 15,84
// A (7,-5,0); B(1,-1,9) - 11,53

// Console.WriteLine("Введите X для точки A");
// int X1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y для точки A");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z для точки A");
// int Z1 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите X для точки B");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y для точки B");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z для точки B");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));
// d = Math.Round (d,2); //округляем до 2-ух знаков после запятой

// Console.WriteLine("Расстояние между точками A и B = "+ d);


//--------------------------------------
//Задача 23: Напишите программу, которая
//принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N
// 3 - 1,8,27
// 5 - 1,8,27,64,125

Console.WriteLine ("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=N; i++)
{
    if (i<N)
    Console.Write (Math.Pow (i,3) + ",");
    else if (i==N)
    Console.Write (Math.Pow (i,3));
}


//--------------------------------------
// Задача 22: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine ("Введите число N ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i<=N; i++)
// {
//     if (i<N)
//     Console.Write (i*i + ",");
//     else if (i==N)
//     Console.Write (i*i);
// }

