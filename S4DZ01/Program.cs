// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// Реализовать через функции.

int Prompt(string messege)
{
    System.Console.Write($"{messege}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int A = Prompt("Введите число");
int B = Prompt("Введите число");
int C = 1;
for(int i = 0;i < B; i++) 
{
    C = C*A;
}
   System.Console.WriteLine(C);
