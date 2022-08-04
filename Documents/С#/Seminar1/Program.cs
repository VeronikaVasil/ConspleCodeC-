Console.Write("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());

int negativeNumber = number * (-1);

while (negativeNumber <= number) //пока несправедливо условие
{
    Console.WriteLine(negativeNumber);
    negativeNumber++;
}

