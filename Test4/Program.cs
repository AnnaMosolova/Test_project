Console.Write("Введите число a: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = 1;

while (a <= n-1){
    System.Console.WriteLine();
    a++;
    if (a % 2 == 0) Console.WriteLine(a);
}
