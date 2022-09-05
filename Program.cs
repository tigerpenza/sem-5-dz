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

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for( int i = 0; i < size; i++)
//         newArray[i] = new Random().Next(minValue, maxValue +1); 
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " | ");
//     Console.WriteLine();
// }

// int MaxNum( int[] array)
// {
//     int max = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] > max) max = array[i];
//     return max;    
// }

// int MinNum( int[] array)
// {
//     int min = 0;
//     for(int i = 0; i < array.Length; i++) 
//         if(array[i] < min) min = array[i];
//     return min;    
// }


// int sizeRandom = new Random().Next(4, 20);
// int[] myArray = CreateRandomArray(sizeRandom,-100,100);
// Console.WriteLine();
// ShowArray(myArray);
// Console.WriteLine();

// Console.WriteLine($"Maximum value: {MaxNum(myArray)} \nMinimum value: {MinNum(myArray)}");
// int diff = MaxNum(myArray) - MinNum(myArray);
// Console.WriteLine($"The difference between the maximum and minimum elements is: {diff}");
