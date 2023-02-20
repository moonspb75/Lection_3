// // Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
// Доп. задача с усложнением: на отгадывание дается 3 попытки.

Console.WriteLine("Задача 'Дополнительная' ");

int randomNumber = RandomNumber(0, 1000);

int RandomNumber(int min, int max)
{   
  return new Random().Next(min, max);
}

void CheckingTheNumber(int myNumber, int randomNumber) 
{

  if (myNumber > randomNumber) 
  {
    Console.WriteLine("Не угадал, твоё число великовато");
  }
  else Console.WriteLine("Не угадал, твоё число маловато");
}

void AttemptCounter(int maxCounter)
{

  int counter = 1;
  while (counter <= maxCounter) 
  {

    Console.Write("Попытка номер " + counter);
    Console.Write(".   Введи число: ");
    int myNumber = Convert.ToInt32(Console.ReadLine());

    if (myNumber == randomNumber)
    {
      Console.WriteLine("Поздравляю, ты угадал! ");
      break;
    }
    else 
    {
      CheckingTheNumber(myNumber, randomNumber);
      counter++;
    }
  }
}

Console.WriteLine("Игра до 3 попыток");
AttemptCounter(3);

Console.WriteLine("В основные попытки не уложился. Продолжим ? (напиши да/нет)");

string? yesNo = Console.ReadLine();

if (yesNo == "да")
{
AttemptCounter(1000);
}
else Console.Write("Загаданное число было: " + randomNumber);