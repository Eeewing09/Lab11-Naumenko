// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1001;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// int variant = 7;
// bool isPrime = true;

// if (variant == 1)
// {
//     Console.WriteLine("число 1 не является ни простым, ни составным");
// } else {
//     for (int divisor = 2; divisor < variant; divisor++)
// {
//     if (variant % divisor == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }
//     Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варината составной");
// }

// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int ci = 0;
// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     } else
//     {
//         ci += 1;
//     }
//     sum += points;
// }
// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"работ сдано {ci}");

int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            hasDuplicates = true;
            Console.WriteLine($"Найдена пара дубликатов: {groupIds[i]} и {groupIds[j]}");
            break;
        }
    }
}
Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");

