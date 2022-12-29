/*Александр Токарев: Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

/*Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<1)
Console.WriteLine("ERROR");
else
{
    int sum = 0;
for (int i = 1; i <= number; i++)
{
     sum += i;
}
 Console.WriteLine("resalt is : {0}",sum); 
} */

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumerals(number));
if (number<1)
Console.WriteLine("ERROR");

int SumNumerals(int number)
{
int sum = 0;
for (int i = 1; i <= number; i++)
    sum += i;
return sum;
}