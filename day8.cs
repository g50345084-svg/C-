using System;
class Day8
{
    public static void Main()
    {
        string[] lines = System.IO.File.ReadAllLines("input.txt");
        int width = 25;
        int height = 6;
        int layerSize = width * height;
        int numLayers = lines[0].Length / layerSize;

        // Part 1
        int minZeroCount = int.MaxValue;
        int resultPart1 = 0;

        for (int i = 0; i < numLayers; i++)
        {
            string layer = lines[0].Substring(i * layerSize, layerSize);
            int zeroCount = CountDigits(layer, '0');
            if (zeroCount < minZeroCount)
            {
                minZeroCount = zeroCount;
                resultPart1 = CountDigits(layer, '1') * CountDigits(layer, '2');
            }
        }

        Console.WriteLine("Part 1: " + resultPart1);

        // Part 2
        char[] finalImage = new char[layerSize];
        for (int i = 0; i < layerSize; i++)
        {
            finalImage[i] = '2'; // Start with transparent
            for (int j = 0; j < numLayers; j++)
            {
                char pixel = lines[0][j * layerSize + i];
                if (pixel != '2')
                {
                    finalImage[i] = pixel;
                    break;
                }
            }
        }

        Console.WriteLine("Part 2:");
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(finalImage[i * width + j] == '1' ? '#' : ' ');
            }
            Console.WriteLine();
        }
    }

    private static int CountDigits(string str, char digit)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == digit) count++;
        }
        return count;
    }
}