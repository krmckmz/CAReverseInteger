class Program
{
    static void Main(string[] args)
    {
        int number = 1534236469;
        var result = Reverse(number);
        System.Console.WriteLine(result);

    }
    public static int Reverse(int x)
    {
        var text = x.ToString();
        var reversedText = string.Empty;

        if (text[0] == '-')
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
}