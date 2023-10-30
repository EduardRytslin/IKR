// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray()
{
    Console.WriteLine("Введите число элементов массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[size];
    Console.WriteLine("Введите элементы массива:");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray (string[] arr, string sep = ", ")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"“{arr[i]}”{sep}");
        else Console.Write($"“{arr[i]}”");
    }
    Console.WriteLine("]");
}

string[] ChangeArray(string[] arr)
{
    Console.WriteLine("Сколько элементов вы хотите удалить?");
    Console.Write("Удалить элементов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] newArr = new string[arr.Length - n];
    for (int i = 0; i < arr.Length - n; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

string[] arr1 = CreateArray();
PrintArray(arr1);
string[] arr2 = ChangeArray(arr1);
PrintArray(arr2);