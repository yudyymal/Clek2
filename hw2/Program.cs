Console.WriteLine("Введите число");

string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (num < -99) // Сделано, чтоб работало с трёхзначными отрицательными
{
    num = num * (-1); 
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine
    ("Третья цифра в числе - " + (num.ToString().ToCharArray()[2]));
}