using System;

public class DecimalToBinary_BinaryToDecimal
{
    public static int[] ConvertToBinary(int n)
    {
        int[] result = new int[8];

        for (int i = 7; i >= 0; i--)
        {
            result[i] = n & 1;
            n >>= 1;
        }

        return result;
    }

    public static int ConvertToDecimal(int[] binary)
    {
        int decimalValue = 0;
        int power = 7;

        // if negative case
        if (binary[0] == 1)
        {
            // convert to negative
            int[] flippedBits = new int[8];

            for (int i = 0; i < 8; i++)
            {
                flippedBits[i] = 1 - binary[i];
            }

            for (int i = 0; i < 8; i++)
            {
                decimalValue += flippedBits[i] * (1 << power);
                power--;
            }

            decimalValue = -(decimalValue + 1);
        }
        else
        {
            // if positive case
            for (int i = 0; i < 8; i++)
            {
                decimalValue += binary[i] * (1 << power);
                power--;
            }
        }

        return decimalValue;
    }

    public static void Main(string[] args)
    {
        //Positive Case
        Console.WriteLine("Input number : 10");
        int[] binary2 = ConvertToBinary(10);

        Console.Write("To Binary : ");
        Console.WriteLine(string.Join("", binary2));

        Console.Write("From Binary To Decimal : ");
        Console.WriteLine(ConvertToDecimal(binary2));

        //
        Console.WriteLine();
        //

        //Negative Case
        Console.WriteLine("Input number : -10");
        int[] binaryNegative2 = ConvertToBinary(-10);

        Console.Write("To Binary : ");
        Console.WriteLine(string.Join("", binaryNegative2));

        Console.Write("From Binary To Decimal : ");
        Console.WriteLine(ConvertToDecimal(binaryNegative2));
    }
}