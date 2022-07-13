// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int a = Prompt("Задайте количество чисел массива => ");
int[] ArrayNumbers = new int[a];

void InputNumbers(int a)
{
for (int i = 0; i < a; i++)
  {
    System.Console.Write($"Введите {i+1} число: ");
    ArrayNumbers[i] = int.Parse(Console.ReadLine());
  }
}


int EvenNumb(int[] ArrayNumbers)
{
  int count = 0;
  for (int i = 0; i < ArrayNumbers.Length; i++)
  {
    if(ArrayNumbers[i] > 0 ) 
    count += 1; 
  }
  return count;
}

InputNumbers(a);

System.Console.WriteLine($"Введено чисел больше 0 - {EvenNumb(ArrayNumbers)} ");



