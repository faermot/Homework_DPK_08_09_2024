public static class CheckType
{
    // Шедевроуниверсальная функия
    public static T CheckValidInput<T>(string prompt, TryParseDelegate<T> tryParse)
    {
        T result = default(T);
        bool success = false;

        while (!success)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            success = tryParse(input, out result);

            if (!success)
            {
                Console.WriteLine("\a Ошибка! Введите корректное значение!");
            }
        }

        return result;
    }

    public delegate bool TryParseDelegate<T>(string input, out T result);
}
