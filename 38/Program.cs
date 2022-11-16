//  Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
 Console.WriteLine("Ввидите длинну масcива");
 int size = Convert.ToInt32(Console.ReadLine());

     int[] array = GetArray(size);
      int[] GetArray(int size1)
        {
            int[] array = new int[size];
            for (int i = 0; i < size1; i++)
            
            {
                array[i] = new Random().Next(55); 
            }
            return array;
        }
             Console.WriteLine(string.Join(",",array));

    int max=array[0];
    for (int i = 0; i < size; i++)
    {
        if(array[i]>max)
        {
            max=array[i];
        }
    }
             int min=array[0];
    for (int i = 0; i < size; i++)
    {
        if(array[i]<min)
        {
            min=array[i];
        }
    }
    Console.WriteLine($"Разница между max и min= {max-min}");