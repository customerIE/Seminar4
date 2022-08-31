// Назовём число «интересным», если его произведение цифр
// делится на их сумму. Напишите программу, которая заполняет
// массив на N «интересных» случайных целых чисел.
Console.WriteLine("Введите размер массива 'интересных' чисел : ");
int N  = Convert.ToInt32(Console.ReadLine());
int [] inter_ar = new int [N];
int j = 0;
// Цикл заполнения элементов 'интересного' массива.
//for (int j=0; j<N; j++)
//{
    for (int k=22; k<50; k++)
    {
        int index = 0;
        int digit = 0;
        int sum = 0;
        int counts = 1;
        int number = k;
        // Определяем количество цифр в числе 
        // для создания массива нужнго размера.
        int temp = number;
        while (temp != 0) 
            {
                temp = temp/10;
                index++;
            }
        //Создаем массив
        int[] array = new int [index];
        //Вставляем цифры введенного числа в массив.
        temp = number;
        for (int i=0; i<index; i++)
        {
            digit = temp % 10;
            array[i] = digit;
            temp = temp/10;
        }
        int length = array.Length;
        Console.WriteLine($"Длинна массива: "  + length);
        Console.Write("Массив из полученных цифр:");
        for (int i=0; i<length; i++)
        {
            Console.Write($"_" + array[i]);
        }
        Console.WriteLine();
        // Складываем цифры, которые являются делителями введенного числа.
        for (int i=0; i<length; i++)
        {
            sum = sum + array[i];
            counts = counts * array[i];
        }
        Console.WriteLine($"Сумма цифр = " + sum);
        Console.WriteLine($"Произведение цифр = " + counts);
        //Исключаем деление на 0.
        if (sum !=0)
        {
            if ((counts%sum == 0) && (j != N))
            {
                inter_ar[j] = number;
                j++;
            }
        }
    }
//Конец цикла for j.
//}
Console.WriteLine("Массив интересных чисел: ");
for (int i = 0; i < N; i++)
{
    Console.Write($" " + inter_ar[i]);
}