using System;
using System.Linq;

double[] array = new double[]
{
    6.6, 7.2, 7.2, 8.4, 8.6, 8.4, 9.4, 9.8, 10.0
};
Console.WriteLine(mediaEspecial(array));

double mediaEspecial(double[] array)
{
    array = array.Skip(1).ToArray();
    array = array.Skip(array.Length - 1).ToArray();
    if (array.Length % 2 == 1)
    {
        array.Length
    }
    

    return double.array;
}