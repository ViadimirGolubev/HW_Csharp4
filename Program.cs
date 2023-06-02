
// ---------------------------------Задача 25-----------------------------------
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("введите число A");
// double num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число B");
// double num2 = Convert.ToInt32(Console.ReadLine());

// double ProductOfNumbers()
// {
//     double work=1;
//     double count =1;

//     while (count<=num2)
//     {
//         work= work*num;
//         count=count+1;
//     }

//     return work;
// }
// double result=ProductOfNumbers();
// Console.WriteLine(result);


// ---------------------------------Задача 27-----------------------------------
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int x = i % 10;
    i = i / 10;
    sum = sum + x;
}
Console.Write(sum);




//---------------------------------- Задача 29---------------------------------
//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void CreateArray()
// {
//     int[] arr = new int[8];
//     int count = 0;
//     while(count < arr.Length)
//     {
//         arr [count] = new Random().Next();
//         Console.Write($"{arr[count]} ");
//         count++;
//     }
    
// }
// CreateArray();

