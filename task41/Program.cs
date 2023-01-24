// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите сколько чисел будете вводить: ");
int m = Convert.ToInt32(Console.ReadLine());

string createInputArray(int size)
{
    string numbers = string.Empty;
    for(int i = 0; i<size; i++)
    {
        numbers =  numbers + Console.ReadLine() + " ";
    }
    return numbers;
}

string [] parseInput = createInputArray(m).Split();

int CountPositiveNumbers(string[] arr)
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if (!String.IsNullOrWhiteSpace(arr[i]))
        {
            if( Convert.ToInt16(arr[i])>0)
            {
                count++;
            }
        }
    }
    return count;
}

int countPositive = CountPositiveNumbers(parseInput);
Console.WriteLine($"Количество чисел > 0 = {countPositive}");
