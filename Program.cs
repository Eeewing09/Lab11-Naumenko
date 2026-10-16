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

// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             Console.WriteLine($"Найдена пара дубликатов: {groupIds[i]} и {groupIds[j]}");
//             break;
//         }
//     }
// }
// Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++) {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++) {
//         bool isFree = (day == 3 && lesson == 4);

//         if (isFree) {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }

// if (!found) {
//     Console.WriteLine("Свободных слотов нет");
// }
// задача А
// int[] all_num = { 1, 2, 4, 8, 10, 5, 6 };
// int f_n = 8;
// bool flag = false;
// int ind = 0;
// for (int i = 0; i < all_num.Length; i++)
// {
//     if (all_num[i] == f_n)
//     {
//         flag = true;
//         ind = i;
//         break;
//     }
// }
// Console.WriteLine(flag ? ind : "Число не найдено");
// // задача B
// int[] mas = { 1, 2, 5, 8, 3, 4, 6, 0 };
// int count = 0;
// for (int i = 0; i < mas.Length; i++)
// {

//     if (mas[i] % 2 != 0)
//     {
//         continue;
//     }

//     count += mas[i]; 
// }
// Console.WriteLine(count);

int[] numbers = { 1, 2, 3, 4, 5, 7, 8, 9, 0 };
bool f = false;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length;)
    {
        if (numbers[i] + 1 == numbers[j])
        {
            f = true;
            continue;
        }
        else
        {
            break;
        }

    }
}
Console.WriteLine(f ? "Отсортирован" : "Не отсортирован");

