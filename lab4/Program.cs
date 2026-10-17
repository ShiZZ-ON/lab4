
//Вариант 9 Высокий уровень

int[] first = new int[7];
int[] two = new int[7];

Console.WriteLine("Введи 7 двузнач чисел:");

for (int i = 0; i < first.Length; i++)
{
    while (true)
    {
        try
        {
            Console.Write($"Часть {i + 1}: ");
            string inputString = Console.ReadLine();
            int chislo = int.Parse(inputString);
            if ((chislo >= 10 && chislo <= 99) || (chislo <= -10 && chislo >= -99))
            {
                first[i] = chislo;
                break;
            }
            else
            {
                Console.WriteLine("не двузначное число есть");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ошибка: {e.Message}"); 
        }
    }
}
            Console.WriteLine("исходный массив: ");
for (int i = 0; i < first.Length; i++)
{
    Console.Write($"{first[i]} ");
}

Console.WriteLine();

Console.WriteLine("старшие разряды:");
for (int i = 0; i < first.Length; i++)
{
    two[i] = first[i] / 10;
    Console.Write($"{two[i]} ");
}
        