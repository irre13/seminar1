// Дано число.Проверить кратно ли оно 7 и 23
int a = Int32.Parse(Console.ReadLine());
if((a % 7 == 0) || (a % 23 == 0)){
    Console.WriteLine("YES");
}
else Console.WriteLine("NO");
