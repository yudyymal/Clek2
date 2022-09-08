Console.WriteLine("Введите трёхзначное число");

string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (num > 999 || num < 100)
{
    Console.WriteLine("Число не является трёхзначным или отрицательное");
}
else
{
    Console.WriteLine
    ("Вторая цифра в числе - " + (num.ToString().ToCharArray()[1]));
}