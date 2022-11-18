// Определить количество цифр в числе. Сделать подпрограмму.
int CountDigits(int Number)
{
    Number = Math.Abs(int Number);
    int count = 0;
    while (Number > 0)
    {
        Number = Number / 10;
        count++;
    }
}
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));