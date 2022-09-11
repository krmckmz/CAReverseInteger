class Program
{
    static void Main(string[] args)
    {
        int number = 1534236469;
        var result = ReverseBySteps(number);
        System.Console.WriteLine(result);

    }
    public static int Reverse(int x)
    {
        var text = x.ToString();
        var reversedText = string.Empty;

        if (x < default(int))
        {
            reversedText += "-";
            text = text.Substring(1, text.Length - 1);
        }


        for (int i = text.Length - 1; i > -1; i--)
        {
            if (text[i] == default(int))
                continue;
            else
                reversedText += text[i];
        }

        var returnValue = 0;
        if (int.TryParse(reversedText, out returnValue))
            return returnValue;
        else
            return default(int);
    }

    public static long ReverseBySteps(int x)
    {
        long reversedNumber = default(long);
        int numberTen = 10;

        int lastDigit = x % (numberTen);
        if (lastDigit == default(int))
            return default(int);

        var textLength = x.ToString().Length;

        while (textLength > default(int))
        {
            var residiual = x % numberTen;
            if (residiual != default(int))
            {
                long power = (long)Math.Pow(numberTen, textLength - 1);
                var multiply = residiual * power;
                reversedNumber = reversedNumber + multiply;
            }
            x = x / numberTen;
            textLength -= 1;
        }

        return reversedNumber;
    }
}