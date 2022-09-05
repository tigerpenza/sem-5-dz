// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int [] CreateRandomArray (int size, int min, int max)               
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     newArray [i] = new Random().Next (min, max);
//     return newArray;

// }
// void ShowArray (int [] array)                                               

// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write (array [i] + " *  ");    
//     Console.WriteLine();    
// }

//  int Numbers (int [] array)
// {
//     int count = 0;
  
//     for (int i = 0; i < array.Length; i++)
    
//         if ( array[i] % 2 == 0 ) count++ ;   

//     return count;
// }

// int size = new Random().Next(5, 20);
// int[] myArray = CreateRandomArray(size, 100,1000);     
// ShowArray(myArray);

// Console.Write($"количество чётных чисел в массиве: ");
// Console.Write(Numbers(myArray));




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int [] CreateRandomArray (int size, int minvalue, int maxValue)                
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     newArray [i] = new Random().Next (minvalue, maxValue + 1);
//     return newArray;
// }

// void ShowArray (int [] array)                                               

// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write (array [i] + " ");      

//     Console.WriteLine( );          
// }

//  int PlusSum (int [] array)
// {
//     int sum = 0;

//     for (int i = 1; i < array.Length; i = i + 2)

//         sum = sum + array[i] ;   
//     return sum;
// }


// int[] myArray = CreateRandomArray(15, 1,100);    

// ShowArray(myArray);
// Console.Write($"сумма элементов на нечетных позициях равна {PlusSum(myArray)} : ");







// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] CreateRandomArray (int size, int minvalue, int maxValue)              
{
    double [] newArray = new double [size];
    for (int i = 0; i < size; i++)
    newArray [i] = new Random().NextDouble()  + new Random().Next () ;

    return newArray; 

}

void ShowArray (double [] array)                                               
   { 
    for (int i = 0; i < array.Length; i++)
        Console.Write (array [i] + " | ");      

    Console.WriteLine ( );          
   }

double Max (double [] array)
{
double max = 0;

for (int i = 0; i < array.Length; i++)
    if (array [i] > max) 
        {
            array [i] = max;

         } 
return max;  

}



double Min (double [] array)
{
double min = 0;

for (int i = 0; i < array.Length; i++)
    if (array [i] < min) 
        {
            array [i] = min;

         } 
return min;  

}

int sizeRandom = new Random().Next(10, 15);

double [] myArray = CreateRandomArray (sizeRandom,-10,10);

Console.WriteLine();


ShowArray(myArray);

Console.WriteLine();

Console.WriteLine($"Maximum value: {Max(myArray)} \nMinimum value: {Min(myArray)}");
double diff = Max(myArray) - Min(myArray);
Console.WriteLine($" разница между максимальным и минимальным зачением: {diff}");

