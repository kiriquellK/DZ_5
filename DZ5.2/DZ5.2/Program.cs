bool isContinue = true;
while (isContinue)
{
    Console.WriteLine("Введите строку:");
    string inputString = Console.ReadLine();
    if (string.IsNullOrEmpty(inputString) || !inputString.Contains('h'))
    {
        Console.WriteLine("Введена пустая или не содержащая символов h строка");
    }
    else
    {
        string stringBeforeChange = inputString;
        string buferString = string.Empty;
        int firstIndexOfH = stringBeforeChange.IndexOf('h');
        int lastIndexOfH = stringBeforeChange.LastIndexOf('h');
        buferString = stringBeforeChange.Replace('h', 'H');
        char[] resultStringArray=buferString.ToCharArray();
        resultStringArray[firstIndexOfH] = 'h';
        resultStringArray[lastIndexOfH] = 'h';
        string resultString = new string(resultStringArray);
        Console.WriteLine($"Полученная после преобразований строка: {resultString}");
        isContinue = false;
    }
}
