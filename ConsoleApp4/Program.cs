// Просто так проверять через TryParse как то не круто,
// хотелось следовать принципу "Don’t Repeat Yourself".
// Поэтому пришла идея сделать 1 +- универсальную функцию.
// Но сделать это без Try Catch было довольно сложно,
// и я так же не хотел использовать goto, хоть это и
// не было запрещено, просто если можно использовать goto
// зачем было запрещать Try Catch. Но в общем я много думал,
// и начал сомневатся возможно ли вообще сделать функцию
// универсальной. Но всё же я узнал
// что оказывается в C# есть такой прикол как "Обобщения", и
// можно передавать в метод делегат, и в общем что-то да получилось.

class ConsoleApp4
{
    static void Main()
    {
        decimal decimal_number_1, decimal_number_2, temporary_decimal_number;  // 128b
        double double_number_1, double_number_2;                               // 64b
        ulong ulong_number_1, ulong_number_2;                                  // 64b
        long long_number_1, long_number_2;                                     // 64b
        float float_number_1, float_number_2;                                  // 32b
        uint uint_number_1, uint_number_2;                                     // 32b
        int int_number_1, int_number_2;                                        // 32b
        ushort ushort_number_1, ushort_number_2;                               // 16b
        short short_number_1, short_number_2;                                  // 16b
        sbyte sbyte_number_1, sbyte_number_2;                                  // 8b
        byte byte_number_1, byte_number_2;                                     // 8b

        decimal_number_1 = CheckType.CheckValidInput<decimal>("Введите 1 число типа decimal: ", decimal.TryParse);
        decimal_number_2 = CheckType.CheckValidInput<decimal>("Введите 2 число типа decimal: ", decimal.TryParse);
        // Пример динамической переменной
        temporary_decimal_number = decimal_number_1 + decimal_number_2;
        Console.WriteLine($"Сумма введённых вами чисел (decimal): {temporary_decimal_number}");
        Thread.Sleep(2000);
        Console.Clear();

        double_number_1 = CheckType.CheckValidInput<double>("Введите 1 число типа double: ", double.TryParse);
        double_number_2 = CheckType.CheckValidInput<double>("Введите 2 число типа double: ", double.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (double): {double_number_1 + double_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        ulong_number_1 = CheckType.CheckValidInput<ulong>("Введите 1 число типа ulong: ", ulong.TryParse);
        ulong_number_2 = CheckType.CheckValidInput<ulong>("Введите 2 число типа ulong: ", ulong.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (ulong): {double_number_1 + ulong_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        long_number_1 = CheckType.CheckValidInput<long>("Введите 1 число типа long: ", long.TryParse);
        long_number_2 = CheckType.CheckValidInput<long>("Введите 2 число типа long: ", long.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (long): {double_number_1 + ulong_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        float_number_1 = CheckType.CheckValidInput<float>("Введите 1 число типа float: ", float.TryParse);
        float_number_2 = CheckType.CheckValidInput<float>("Введите 2 число типа float: ", float.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (float): {float_number_1 + float_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        uint_number_1 = CheckType.CheckValidInput<uint>("Введите 1 число типа uint: ", uint.TryParse);
        uint_number_2 = CheckType.CheckValidInput<uint>("Введите 2 число типа uint: ", uint.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (uint): {uint_number_1 + uint_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        int_number_1 = CheckType.CheckValidInput<int>("Введите 1 число типа int: ", int.TryParse);
        int_number_2 = CheckType.CheckValidInput<int>("Введите 2 число типа int: ", int.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (int): {int_number_1 + int_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        ushort_number_1 = CheckType.CheckValidInput<ushort>("Введите 1 число типа ushort: ", ushort.TryParse);
        ushort_number_2 = CheckType.CheckValidInput<ushort>("Введите 2 число типа ushort: ", ushort.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (ushort): {ushort_number_1 + ushort_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        short_number_1 = CheckType.CheckValidInput<short>("Введите 1 число типа short: ", short.TryParse);
        short_number_2 = CheckType.CheckValidInput<short>("Введите 2 число типа short: ", short.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (short): {short_number_1 + short_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        sbyte_number_1 = CheckType.CheckValidInput<sbyte>("Введите 1 число типа sbyte: ", sbyte.TryParse);
        sbyte_number_2 = CheckType.CheckValidInput<sbyte>("Введите 2 число типа sbyte: ", sbyte.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (sbyte): {sbyte_number_1 + sbyte_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        byte_number_1 = CheckType.CheckValidInput<byte>("Введите 1 число типа byte: ", byte.TryParse);
        byte_number_2 = CheckType.CheckValidInput<byte>("Введите 2 число типа byte: ", byte.TryParse);
        Console.WriteLine($"Сумма введённых вами чисел (byte): {byte_number_1 + byte_number_2}");
        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine(
            "РЕЗУЛЬТАТЫ ВСЕХ ВЫЧИСЛЕНИЙ \n" +
            "-----------------------------\n" +
            $"Decimal: {temporary_decimal_number}\n" +
            $"Double: {double_number_1 + double_number_2}\n" +
            $"Ulong: {ulong_number_1 + ulong_number_2}\n" +
            $"Long: {long_number_1 + long_number_1}\n" +
            $"Float: {float_number_1 + float_number_2}\n" +
            $"Uint: {uint_number_1 + uint_number_2}\n" +
            $"Int: {int_number_1 + int_number_2}\n" +
            $"Ushort: {ushort_number_1 + ushort_number_2}\n" +
            $"Short: {short_number_1 + short_number_2}\n" +
            $"Sbyte: {sbyte_number_1 + sbyte_number_2}\n" +
            $"Byte: {byte_number_1 + byte_number_2}\n" +
            "-----------------------------\n" +
            "Для закрытия программы нажмите любую кнопку..."
            );
        Console.ReadKey();

    }
}
