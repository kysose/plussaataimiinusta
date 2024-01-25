using System;
//Sami Kytö INTIM23A6

Console.WriteLine("Anna luku 1");
var luku1 = float.Parse(Console.ReadLine());

Console.WriteLine("Anna luku 2");
var luku2 = float.Parse(Console.ReadLine());

Console.WriteLine("Tulos on: " + Math.Round(plusTaiMinus(luku1, luku2), 2));
static float plusTaiMinus(float a, float b)
{
    if (a < b)
    {
        float tulos = a - b;
        return tulos;
        
    }
    else
    {
        float tulos = a + b;
        return tulos;
    }
}
