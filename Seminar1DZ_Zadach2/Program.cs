//Задача2
Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2){
    Console.Write("min=");
    Console.WriteLine(num1);
    Console.Write("max=");
    Console.Write(num2);
}
else {
    Console.Write("min=");
    Console.WriteLine(num2);
    Console.Write("max=");
    Console.WriteLine(num1);
}