using System;

class MainClass {
  public static void Main (string[] args) {
    int number;
    string numberStr;
    Console.Write("Enter a number: ");
    number = int.Parse(Console.ReadLine());
    numberStr = number.ToString();
    if (numberStr.Length >= 3)
    {
        Console.WriteLine("The third digit of the number is " + numberStr[2]);
    }
    else
    {
        Console.WriteLine("The number does not have a third digit.");
    }
  }
}
