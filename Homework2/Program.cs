namespace Homework2;

public static class Program
{
    public static void Main()
    {
        try 
        {
            Console.WriteLine("Введите размер массива:");
            int n = ReadInt();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите номер {i + 1} массива: ");
                array[i] = ReadInt();
            }
            int[] arrayTop = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > arrayTop[0])
                {
                    arrayTop[1] = arrayTop[0];
                    arrayTop[0] = array[i];
                } else if (array[i] > arrayTop[1])
                {
                    arrayTop[1] = array[i];
                }
            }
            Console.WriteLine($"Вторым наибольшим числом является {arrayTop[1]}");
        }
        catch (Exception){}
    }
    public static int ReadInt()
    {
            if (Int32.TryParse(Console.ReadLine(), out var value))
            {
                return value;
            }
            else
            {
                throw new Exception("укажите размер массива в виде числа");
            }
    }
    
}
