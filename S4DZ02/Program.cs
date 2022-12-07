// Задача 2: Напишите программу,которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции.

int Prompt(string messege)      //Функция считывает число
{
    System.Console.Write($"{messege}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int A = Prompt("Введите число");      //функ считывает и возвращаемое значение копируется в А
int P = 1;
int C = 0;
while (P <= A)        //Цикл пока
{
    C = C + A/P %10; 
    P = 10*P;
}
   System.Console.WriteLine(C);
