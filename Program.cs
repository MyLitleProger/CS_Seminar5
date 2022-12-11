Console.Clear();
restart:
Console.WriteLine("1-5 Задачи семинара");
Console.WriteLine("6-8 Практические задачи");
Console.WriteLine("9-10 Дополнительная задача \n");
Console.Write("Что бы запустить какую то конкретную задачу введите номер этой задачи то 1 до 8: ");
int Task = int.Parse(Console.ReadLine());

switch(Task){
    case 1:
    /*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
    из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов 
    массива.   */
    void InputArray(int[] array){
        for (int i = 0; i < array.Length; i++){
            array[i] = new Random().Next(-9,10);
        }
    }

    void ReleaseArray(int[] array){
        int sumNegative = 0, sumPositive = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > 0)
                sumPositive += array[i];
            else
                sumNegative += array[i];
        }
        Console.WriteLine($"Сумма положительных чисел равна: {sumPositive}");
        Console.WriteLine($"Сумма положительных чисел равна: {sumNegative}");
    }

    Console.Write("Введите кол-во элементов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    InputArray(array);
    Console.WriteLine($"[{string.Join(", ", array)}]");
    ReleaseArray(array);
    break;

    case 2:
    /*Задача 32: Напишите программу замена элементов 
    массива: положительные элементы замените на 
    соответствующие отрицательные, и наоборот.*/
    void InvernArray(int[] array){
        for (int i = 0; i < array.Length; i++)
            array[i] *= -1;
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    Console.Write("Введите кол-во элементов массива: ");
    n = Convert.ToInt32(Console.ReadLine());
    array = new int[n];
    InputArray(array);
    Console.WriteLine($"[{string.Join(", ", array)}]");
    InvernArray(array);
    break;

    case 3:
    /*Задача 33: Задайте массив. Напишите программу, которая
    определяет, присутствует ли заданное число в массиве.*/
    string SearchNumberInArray(int[] array, int k){
        for (int i=0; i<array.Length; i++){
            if (array[i] == k)
                return "yes";
        }
        return "no";
    }

    Console.Write("Введите кол-во элементов массива: ");
    n = Convert.ToInt32(Console.ReadLine());
    array = new int[n];
    InputArray(array);
    Console.WriteLine($"[{string.Join(", ", array)}]");
    Console.Write("Введите кол-во элементов массива: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SearchNumberInArray(array, k));
    break;

    case 4:
    /*Задача 35: Задайте одномерный массив из 123 случайных числе.
    Найдите количество элементов массива, значениея коорых лежат в 
    отрезке [10,99].    */

    void InputArrayTo200(int[] array){
        for (int i = 0; i < array.Length; i++){
            array[i] = new Random().Next(-200,201);
        }
    }

    int CountElementArray(int[] array){
        int count = 0;
        for (int i=0; i<array.Length; i++){
            if (array[i] >= 10 && array[i] <= 99)
                count++;
        }
        return count;
    }

    array = new int[123];
    InputArrayTo200(array);
    Console.WriteLine($"[{string.Join(", ", array)}]");
    Console.WriteLine(CountElementArray(array));
    break;

    case 5:
    /*Задача 37: Найдите произведение пар чсисел в одномерном массиве.
    Парой считаем первый и послежний элемент, второй и продпоследний 
    и т.д. Результат запишите в новом массиве.*/
    void InputArray_1_10(int[] array){
        for (int i = 0; i < array.Length; i++){
            array[i] = new Random().Next(1,11);
        }
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }
    void PairedNumbers(int[] array){
        for (int i=0; i<array.Length / 2 + array.Length % 2; i++)
            Console.Write($"{array[i] * array[array.Length - i - 1]} ");
    }
    array = new int[5];
    InputArray_1_10(array);
    PairedNumbers(array);
    break;
/////////////////////////////////////////////////////////////////////////////////
    case 6:
    /*Задача 34: Задайте массив заполненный случайными
    положительными трехзначными числами. Напишите
    программу, которая показет количество четных чисео в
    массиве.*/
    void InputArray_100_999(int[] array){
        for (int i = 0; i < array.Length; i++){
            array[i] = new Random().Next(100,1000);
        }
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    int CountEvenNumbersInArray(int[] array){
        int count = 0;
        for (int i=0; i<array.Length; i++){
            if (array[i] % 2 == 0)
                count++;
        }
        return count;
    }
    array = new int[5];
    InputArray_100_999(array);
    System.Console.WriteLine(CountEvenNumbersInArray(array));
    break;

    case 7:
    /*Задача 36: Задайте одномерный массив, заполненный 
    случайными числами. Найдите сумму элеменетов, стоящих
    на нечетных позициях.*/
    int SumElemArray(int[] array){
        int sum = 0;
        for (int i=0; i<array.Length; i++){
            if (i % 2 != 0)
            sum += array[i];
        }
        return sum;
    }

    array = new int[5];
    InputArray_1_10(array);
    System.Console.WriteLine(SumElemArray(array));

    break;

    case 8:
    /*Задача 38: Задайте массив вещественных чисел.
    Найдите разницу между максимальным и минимальным
    элементов массива.*/
    void InputArrayDouble_0_100(double[] array){
        for(int i=0; i<array.Length;++i){
            array[i] = new Random().NextDouble() * 100;
        }
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }
    double MaxElemArray(double[] array){
        double max = -1;
        for (int i=0; i<array.Length;++i){
            max = array.Max();
        }
        return max;
    }
    double MinElemArray(double[] array){
        double min = -1;
        for (int i=0; i<array.Length;++i){
            min = array.Min();
        }
        return min;
    }
    double DiffMaxMinElemArrayDouble(double[] array){
        double max = MaxElemArray(array);
        double min = MinElemArray(array);
        double diff = max - min;
        return diff;
    }

    double[] array1 = new double[5];
    InputArrayDouble_0_100(array1);
    
    Console.WriteLine(DiffMaxMinElemArrayDouble(array1));
    break;

    case 9: 
    /*написать программу, производящую согласно утверждению Гольдбаха, 
    разложение заданного чётного числа. Из всех пар простых чисел, 
    сумма которых равна заданному числу, требуется найти пару, 
    содержащую наименьшее простое число. */

    bool PrimeNumber(int num){
        bool yes = true;
        for (int i =2; i < num; ++i){
            if (num % i == 0) yes = false; 
        } 
        return yes; 
    }

    Console.Write("Введите четное число от 4 до 998:  ");
    int UserNumber = int.Parse(Console.ReadLine());
    int PrimeNumber1 = 0, PrimeNumber2 = 0;
    bool yes = false;

    for (int i = 2; i < UserNumber / 2 + 1; i++){
        if (PrimeNumber(i) && PrimeNumber (UserNumber - i)){
            yes = true;
            PrimeNumber1 = i;
            PrimeNumber2 = UserNumber - i;
        }
    }
    if (yes){
        if (PrimeNumber2 > PrimeNumber1)
             Console.WriteLine($"{PrimeNumber1} + {PrimeNumber2} = {UserNumber}");
        else Console.WriteLine($"{PrimeNumber2} + {PrimeNumber1} = {UserNumber}");
    }
    else Console.WriteLine($"{UserNumber} - С этим число ничего не получилось");

    break;

    case 10:
    /*
    1. Указать количество дней в которые Вася получил оценки
    2. Указать дни месяца в которые Вася получил оценку
    3. Найти сколько троек и четверое получил Вася
    4. Найти результат, может ли Вася расчитывать на четверку
    */

    //блок ввода данных
    int[] even = new int[0], odd = new int[0];
    int l = 0, m = 0;
    Console.Write("Укажите кол-во дней в которые Вася получил оценку: ");
    array = new int[int.Parse(Console.ReadLine())];
    
    Console.WriteLine("Укажите дни месяца в которые Вася получил оценку: ");
    for (int i = 0; i < array.Length; ++i){
        array[i] = int.Parse(Console.ReadLine());
    }

    //блок заполнения массивов
    for (int i = 0; i < array.Length; ++i){
        if (array[i] % 2 == 0){
            Array.Resize(ref even, even.Length + 1);
            even[l] = array[i];
            l++;
        }
        else{
            Array.Resize(ref odd, odd.Length + 1);
            odd[m] = array[i];
            m++;
        }
    }

    //блок вывода данных
    if (odd.Length > 0)             Console.WriteLine($"[{string.Join(" ", odd)}]");
    if (even.Length > 0)            Console.WriteLine($"[{string.Join(" ", even)}]");
    if (even.Length > odd.Length)   Console.WriteLine("Вася получит четверку");
    else                            Console.WriteLine("Вася не получит четверку");

    //нет дополнительных проверок на дни месяца, но основной смысл программы работает
    break;

    default:
    goto restart;
}
