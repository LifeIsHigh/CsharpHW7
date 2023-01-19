//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//Является ли этот день выходным

Console.Write("Введите цифру соответствующую дню недели: ");
int X = Convert.ToInt32(Console.ReadLine());

if (X >= 1 && X <= 7)
{
    if (X == 6 || X == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
    Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Неверно введён номер дня недели");
}
