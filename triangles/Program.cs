using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите длины трёх сторон треугольников через пробел:");

        string a = Console.ReadLine();
        string[] nums = a.Split(' ');
        int[] numbers = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            numbers[i] = Convert.ToInt32(nums[i]);
        }

        if (numbers[0] == numbers[1] && numbers[0] == numbers[2] && numbers[1] == numbers[2])
        {
            Console.WriteLine("Это равносторонний треугольник");
        }
        else if (numbers[0] != numbers[1] && numbers[0] != numbers[2] && numbers[1] != numbers[2])
        {
            Console.WriteLine("Это обычный треугольник");
        }
        else
        {
            Console.WriteLine("Это равнобедренный треугольник");
        }
    }
}