Console.Write("Введите число №1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber) //f = 25, s = 5
{
    Console.WriteLine(firstNumber + " является квадратом от " + secondNumber);
    // Конкатенация - процесс сложения строк: "1" + "1" = "11"
}
// "!=" -  проверка на неравенство 5 != 5 - False
// "==" - равенство. 5 == 5 - True
else // if (firstNumber != secondNumber * secondNumber)
{
    Console.WriteLine(firstNumber + " НЕ является квадратом от " + secondNumber);
}

