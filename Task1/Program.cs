// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. 
// Не использовать функцию Math.Pow()
Console.WriteLine("Введите число = A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число = B: ");
int B = Convert.ToInt32(Console.ReadLine());
int exponentiation(int number, int index)
{
    int temp = number; 
    for (int i=1; i < index; i++)
    {
        temp = temp * number;
    }
    return temp;
}
Console.WriteLine(A + $" в степени " + B + " = " + exponentiation(A, B));