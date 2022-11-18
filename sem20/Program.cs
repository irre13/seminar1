int Part(double x, double y) {
    int part = 0;
    if (x > 0 && y > 0) part = 1;
    if (x < 0 && y > 0) part = 2;
    if (x < 0 && y < 0) part = 3;
    if (x > 0 && y < 0) part = 4;
    return part;
}
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("part:" + Part(x, y));
