//  Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

 Console.WriteLine("Ввидите длинну масcива");
        int size = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

     int[] array = GetArray(size);
      int[] GetArray(int size1)
        {
            int[] array = new int[size];
            for (int i = 0; i < size1; i++)
            
            {
                array[i] = new Random().Next(); 
                
                int a= array[i];
                if(i%2!=0)  
                {
                  sum=sum+a;
                }
            }
            return array;
        }
             Console.WriteLine(string.Join(",",array));
            Console.WriteLine("Сумма ="+ sum);
