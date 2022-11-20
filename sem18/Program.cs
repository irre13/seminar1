// По двум заданным числам проверять является ли одно квадратом другого.
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
if (a * a == b || b * b == a){
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");
