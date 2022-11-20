// Показать кубы чисел, заканчивающихся на четную цифру
Random random = new Random(10);

for(int i = 0; i < 5; i++) {
    int a = random.Next(1, 100);
    int b = Math.Pow(a,3);
    if (b % 10 % 2 == 0);
    System.Console.WriteLine($"{a}, {b}");
}
    

// System.Console.WriteLine(random.Next(1, 100)+" ");
