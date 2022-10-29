// Задача 8
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if (N<=0){
   Console.WriteLine("Число меньше 1"); 
}
int num = 2;
while (num<=N)
{
 if (num%2==0){
 Console.Write(num + ", ");   
}
num++;
}
if (N==2){
    Console.WriteLine(N);
}
