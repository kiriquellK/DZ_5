Console.WriteLine("Введите строку");
Console.WriteLine("Строка для шифрования/дешифрования");
string inputString = Console.ReadLine();
if (string.IsNullOrWhiteSpace(inputString))
{
    Console.WriteLine("Введена пустая строка");
}
else
{
    string stringForProcessing = inputString.ToLower();
    Console.WriteLine(stringForProcessing);
    Console.Write("Шаг шифрования/дешифрования:");
    bool isInputStep = int.TryParse(Console.ReadLine(), out int encodeStep);
    if (!isInputStep)
    {
        Console.WriteLine("Введен некорректный шаг шифрования");
    }
    else
    {
        Console.WriteLine("Выберите действие:");
        bool isInputNumber = int.TryParse(Console.ReadLine(), out int inputNumber);
        if (!isInputNumber)
        {
            Console.WriteLine("Введен некорректный номер действия");
        }
        else
        {
            int actionNumber = inputNumber;
            int charCode;
            int firstIndexOfAlphabet = 97;
            int lastIndexOfAlphabet = 122;
            int alphabetPower = lastIndexOfAlphabet - firstIndexOfAlphabet + 1;
            char[] stringArray = stringForProcessing.ToCharArray();
            switch (actionNumber)
            {
                case 1:
                    Console.WriteLine("Зашифрованная строка:");
                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        charCode = stringArray[i];
                        char charResult = Convert.ToChar(firstIndexOfAlphabet + (charCode + encodeStep - firstIndexOfAlphabet) % alphabetPower);
                        Console.Write(Convert.ToChar(charResult));
                    }
                    break;
                case 2:
                    Console.WriteLine("Дешифрованная строка:");
                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        charCode = stringArray[i];
                        char charResult = Convert.ToChar(firstIndexOfAlphabet + (alphabetPower + (charCode - encodeStep) - firstIndexOfAlphabet) % alphabetPower);
                        Console.Write(Convert.ToChar(charResult));
                    }
                    break;
                default:
                    Console.WriteLine("Неправильное действие");
                    break;
            }
        }
    }
}
