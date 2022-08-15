//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int UserDay;
do {
Console.Write("Введите порядок дня недели: ");
UserDay = Convert.ToInt32(Console.ReadLine());
if (UserDay > 7)
{
    Console.WriteLine("Ошибка! День недели может быть от 1 до 7(включительно)!");
}
}
while(UserDay > 7 );

if(UserDay >= 6)
{
    Console.Write("День " + UserDay + " является выходным!");
}
else {
    Console.Write("День " + UserDay + " не является выходным!");
    }

