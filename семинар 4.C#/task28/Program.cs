/* Александр Токарев: Решение в группах задач:
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 */


Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
int Proizv (int M)
{
int pz =1;
while(1!=M)
{
    pz = pz * M;
    M--;
}return pz;
}
Console.WriteLine(Proizv(N));
