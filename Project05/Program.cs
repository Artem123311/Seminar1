Console.WriteLine("Введите значение: ");
string text = Console.ReadLine();
int y = text[text.Length - 1] - '0';
int n = y * y;
Console.WriteLine("Последние число нашего числа {0,5}", y);