using System;

public class NumberConverter
{ 
    public static byte[] ConvertToBinary(int n)
    {
        byte[] result = new byte[8];
        for (int i = 7; i >= 0; i--)
        {
            result[i] = (byte)(n & 1);
            n >>= 1;
        }

        return result;
    }

    public static int ConvertToDecimal(byte[] binary)
    {
        int size = binary.Length;
        int decimalValue = 0;
        int power = size - 1;

        for (int i = 0; i < size; i++)
        {
            binary[i] = (byte)(1 - binary[i]);
        }

        for (int i = 0; i < size; i++)
        {
            decimalValue += (sbyte)binary[i] * (1 << power);
            power--;
        }

        int answer = binary[0] == 1 ? (sbyte)-(decimalValue + 1) : (sbyte)-(decimalValue + 1);

        return answer;
    }

    public static void Main(string[] args)
    {
        //Positive Case
        Console.WriteLine("Input number : 10");
        byte[] binary2 = ConvertToBinary(10);

        Console.Write("To Binary : ");
        Console.WriteLine(string.Join("", binary2));

        Console.Write("From Binary To Decimal : ");
        Console.WriteLine(ConvertToDecimal(binary2));

        //
        Console.WriteLine();
        //

        //Negative Case
        Console.WriteLine("Input number : -10");
        byte[] binaryNegative2 = ConvertToBinary(-10);

        Console.Write("To Binary : ");
        Console.WriteLine(string.Join("", binaryNegative2));

        Console.Write("From Binary To Decimal : ");
        Console.WriteLine(ConvertToDecimal((binaryNegative2)));
    }
}