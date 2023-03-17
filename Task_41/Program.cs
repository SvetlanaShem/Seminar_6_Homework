Console.Clear();
int count = GetNumberFromUser("Введите количество чисел: ", "Ошибка ввода!");
int[] array = GetArrayFromUser(count);
int countPositive = CountingPositiveNumbers(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> в массиве {countPositive} чисел больше ноля");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArrayFromUser(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt($"Введите {i + 1}-й элемент ");
    }
    return arr;
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int CountingPositiveNumbers(int[] arr)
{
    int countNum = 0;
    foreach (int el in arr)
    {
        if (el > 0) countNum++;
    }
    return countNum;
}