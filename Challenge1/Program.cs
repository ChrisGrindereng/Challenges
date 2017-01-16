using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class vector
{
    static float vectorLength(float[,] vecs)
    {
        float deltaX = vecs[0, 0] - vecs[1, 0];
        float deltaY = vecs[0, 1] - vecs[1, 1];

        double length = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));


        return (float)length;

    }
    public static void Main()
    {
        Console.WriteLine(vectorLength(new float[2, 2] { { 0, 3 }, { 4, 0 } }) == 5);
        Console.WriteLine(vectorLength(new float[2, 2] { { 1, -1 }, { 1, -1 } }) == 0);
        Console.WriteLine(vectorLength(new float[2, 2] { { 0, 1 }, { 0, 0 } }) == 1);
        Console.ReadLine();

    }
}