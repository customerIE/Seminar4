// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе, которые являются делителями
// этого числа. 
int index = 0;
int digit = 0;
int sum = 0;
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
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
Console.WriteLine(length);
Console.Write("Массив из полученных цифр:");
for (int i=0; i<length; i++)
{
    Console.Write($"_" + array[i]);
}
Console.WriteLine();
// Складываем цифры, которые являются делителями введенного числа.
for (int i=0; i<length; i++)
{
    //Исключаем деление на 0.
    if (array[i] != 0)
    {
    if ((number%array[i]) == 0)
    {
        sum = sum + array[i];
    }
    }
}
Console.Write($"Сумма цифр в числе кратных введенному = " + sum);