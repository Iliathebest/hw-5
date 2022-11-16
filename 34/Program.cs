// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
  // [345, 897, 568, 234] -> 2
        Console.WriteLine("Ввидите длинну масcива");
        int size = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        // массив который будет отоброжать метод
        int[] array = GetArray(size);
        // рабочий метот
        int[] GetArray(int size1)
        {
            int[] array = new int[size];
            for (int i = 0; i < size1; i++)
            {
                array[i] = new Random().Next(100, 1000);
                int a = array[i];
                if (a % 2 == 0)
                {
                    sum += 1;
                }
            } return array;
         }   
        Console.WriteLine(String.Join(",",array));
        Console.WriteLine(" количество чётных чисел в массиве"+sum);




       

