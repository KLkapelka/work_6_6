// Дан массив со случайным количеством дробных чисел. Из элементов исходного массива постройте два новых.
// В первый должны входить только положительные элементы, а во второй только отрицательные элементы;

using System;
class work_6_6
{
    static void Main()
    {
        Random rand = new Random(); 
        int length = rand.Next(5, 11);
        float[] array = new float[length]; 
        float[] arrayPositively = new float[length]; 
        float[] arrayNegative = new float[length]; 
        
        int positively = 0; 
        int negative = 0; 

        for (int i = 0; i < length; i++)
        {
            array[i] = (float)rand.NextDouble() * 200 - 100; 
        }

        for (int i = 0; i < length; i++)
        {
            if (array[i] >= 0) 
            {
                arrayPositively[positively] = array[i]; 
                positively++; 
            }
            else 
            {
                arrayNegative[negative] = array[i]; 
                negative++; 
            }
        }

        Console.WriteLine("Оригинальный массив массив: ");
        foreach (float i in array)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(); 

        Console.WriteLine("Положительный массив массив массив: ");
        for (int i = 0; i < positively; i++)
        {
            Console.WriteLine(arrayPositively[i]);
        }
        Console.WriteLine(); 

        Console.WriteLine("Отрицательнй массив массив массив: ");
        for (int i = 0; i < negative; i++)
        {
            Console.WriteLine(arrayNegative[i]);
        }
    }
}

