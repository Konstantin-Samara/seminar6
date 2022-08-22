// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел для проверки хотите ввести ? : ");
int M = Convert.ToInt32(Console.ReadLine());
if (M>0) {
    double Count = 0;
    for (int i=0; i<M; i++) {
        Console.Write($"Введите число {i+1} : ");
        int Number = Convert.ToInt32(Console.ReadLine());  
        if (Number>0) {Count++;}}

    string str = "чисел";
    double LastSinbolsCount = Count;
    if (LastSinbolsCount>99) // получаем значение последних двух разрядов 
    //кол-ва положительных чисел для последующего выбора слова "чисел","число","числа"
    //в ответе.
    {LastSinbolsCount/=100;
    LastSinbolsCount = Convert.ToInt32((LastSinbolsCount - Math.Truncate(LastSinbolsCount))*100);}
   
    if (LastSinbolsCount<10&&LastSinbolsCount>=0) {
        if(LastSinbolsCount==1) {str = "число";}
        else {
            if(LastSinbolsCount>1&&LastSinbolsCount<5) {str = "числа";}
            else {str = "чисел";}}
    }
    if (LastSinbolsCount>=10&&LastSinbolsCount<20) {str = "чисел";}
    
    if (LastSinbolsCount>=20) {
        LastSinbolsCount/=10;
        LastSinbolsCount = Convert.ToInt32((LastSinbolsCount - Math.Truncate(LastSinbolsCount))*10);
        if(LastSinbolsCount==1) {str = "число";}
        else {
            if(LastSinbolsCount>1&&LastSinbolsCount<5) {str = "числа";}
            else {str = "чисел";}}
        }
  
    Console.WriteLine($"Вы ввели {Count} {str} > 0.");
    }
else {Console.WriteLine("Вы ввели не натуральное число.");}