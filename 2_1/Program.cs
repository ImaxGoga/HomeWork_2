string a1;
do {
Console.Write("Введите трехзначное число: ");
a1 = Console.ReadLine();
}
while(a1.Length != 3);

Console.Write("Вторая цифра: ");
Console.Write(a1[1]);