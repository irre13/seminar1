﻿int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
// if 
// (n < 100) System.Console.WriteLine("No");
// else
// System.Console.WriteLine(n/100%10);
if (n > 99) {
    while (n > 1000) {
        n = n / 10;
    }
    System.Console.WriteLine(n % 10);
} else {
    System.Console.WriteLine("No");
}
