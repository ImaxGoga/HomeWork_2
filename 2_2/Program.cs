Console.Write("Введите число: ");
string a1 = Console.ReadLine();

if(a1.Length >= 3)
{
    Console.Write("Третья цифра: ");
    Console.Write(a1[2]);
}
else {
    Console.Write("Третьей цифры нет");
}