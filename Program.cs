
// ---------------------------------Задача 25-----------------------------------
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// ---------------------------------Задача 27-----------------------------------
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



//---------------------------------- Задача 29---------------------------------
//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
 // ----------------пример войта это отсутсвие возвращающего значения--------------------
// PrintText();
// void PrintText()
// {
//     int y=3;
//     Console.WriteLine(y);
// }



// PrintText();



// PrintText();
// =====мое НЕ РАБОТАЕТ    ====

// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());
//  int GetSumNumber()
//  {
//       int sum=0;
//       int count=1;

//       while (count<=num);
//       {
//         sum=sum+count;
//         count=count+1;
//       }
//     return sum;
//  }
// int result=GetSumNumber();
// Console.WriteLine("result");

//______________________________________ Задача 24:_____________
// Напишите программу, которая
//  принимает на вход число (А) и выдаёт сумму
//   чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("введите число");
// int num =Convert.ToInt32(Console.ReadLine());

// int GetSumNumber()
// {
//     int sum=0;
//     int count =1;

//     while (count<=num)
//     {
//         sum= sum+count;
//         count=count+1;
//     }

//     return sum;
// }
// int result=GetSumNumber();
// Console.WriteLine(result);

//___________________________________Задача 26________ 
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число");
// string A = Console.ReadLine();
// Console.WriteLine(Length());

// int Length () {
//     int length = A.Length;
//     return length;
// }
// --------------------Задача 28:_____________
 //Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int x()
// {
//     int result = 1;
//     int count = 1;
//     while (count <= num)
//     {
//         result = result * count;
//         count = count + 1;
//     }
//     return result;
// }
// Console.WriteLine(x());

//++++++++++++++++++Задача 30:++++++++++++++++++++
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
//   На третьей строки это создание массива ВАЖЕНО1!!!!!!!!!!!!!!!

// void CreateArray()
// {
//     int[] arr = new int[8];
//     int count = 0;
//     while(count < arr.Length)
//     {
//         arr [count] = new Random().Next(0,2);
//         Console.Write($"{arr[count]} ");
//         count++;
//     }
    
// }
// CreateArray();











//дз3 19

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num<10000)||(num>99999))
// {
//     Console.WriteLine($"Число {num} не пятизначное.");
    
// }
// else
// {
//     int a=num%10;
//     int b=(num%100)/10;
//     int c=(num/1000)%10;
//     int d=num/10000;

//     if (a==d&&b==c)
//     {
//         Console.WriteLine($"Число {num} - полиндром.");
//     }
    
//     else
//     {
//         Console.WriteLine($"Число {num} - не полиндром.");
//     }
// }


//вар2
// Console.WriteLine("Введите число: ");
// string numText = Console.ReadLine();

// int numLength = numText.Length;

// while (numLength == 5)
// {
//     if (numText[0] == numText[4] && numText[1] == numText[3])
//     {
        
//         Console.WriteLine($"{numText} - Палиндром");
//     } else {
//         Console.WriteLine($"{numText} - Не палиндром");
//     }
//     return;
// }
// Console.WriteLine($"{numText} - Введите 5 чисел!");



// 
// int Max(int arg1, int arg2, int arg3)
// {
// int result = arg1;
// if(arg2>result) result=arg2; 
// if(arg3>result) result=arg3; 
// return result;
// }
// int [] array = {11,21,31,41,1095,61,17,18,19};
// int result = Max(
//     Max(array[0], array[1], array[2]), 
//     Max(array[3], array[4], array[5]), 
//     Max(array[6], array[7], array[8])
//     );
// Console.WriteLine(result);



// int[] array = {1,12,31,4,18,16,17,18};
// int n = array.Length;
// int find = 18;
// int index = 0;
// while (index < n) 
// {
// if(array[index] == find) 
// {
// Console.WriteLine(index); 
// break;
// }
// index ++; 
// }

void FillArray(int[] collection) 
{
int length = collection.Length; 
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(1, 10); 
//index = index + 1;
index++;
}
}
void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
Console.WriteLine(col[position]);
position++;
}
}

int IndexOf(int[] collection, int find) 
{
int count = collection.Length; 
int index = 0;
int position = -1;
while (index < count)
{
if(collection[index] == find)
{
  position = index;
  break;
}
index++; 
}
return position;
 }

int[] array = new int[10];
FillArray(array);
array[4]=4;
array[8]=4;
PrintArray(array);
Console.WriteLine();


int pos = IndexOf(array, 444);
Console.WriteLine(pos);
