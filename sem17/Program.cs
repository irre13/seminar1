// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a = Int32.Parse(Console.ReadLine());
if (a == 6 || a == 7) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}