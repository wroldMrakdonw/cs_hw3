Console.Write("Введите 5-и значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int d1 = n / 10000;
int d2 = n / 1000 % 10;
int d4 = n / 10 % 10;
int d5 = n % 10;
if(d1 == d5 && d2 == d4){
    System.Console.WriteLine($"Число {n} - палиндром.");
}
else{
    System.Console.WriteLine($"Число {n} не является палиндромом");
}