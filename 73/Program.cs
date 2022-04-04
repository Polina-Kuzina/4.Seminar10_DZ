// Задача 73 : Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? 
// Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int m = Convert.ToInt32(Math.Log(n, 2));
Console.WriteLine("Число групп = " + m);
Console.WriteLine("Группа 1: 1");
for (int i = 1; i < m; i++)
{
    Console.Write($"Группа {i + 1}: ");
    for (int k = Convert.ToInt32(Math.Pow(2, i)); k < Convert.ToInt32(Math.Pow(2, (i + 1))) && k<(n+1); k++)
    {
        Console.Write(k + " ");
    }
    Console.WriteLine();
}