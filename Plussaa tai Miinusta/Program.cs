using System;
//Sami Kytö INTIM23A6

Console.WriteLine("Anna luku 1");
var numero1 = Console.ReadLine(); 
var luku1 = float.Parse(numero1);
Console.WriteLine("Anna luku 2");
var numero2 = Console.ReadLine();
var luku2 = float.Parse(numero2);
//tein ensin vain var luku1 = float.Parse(Console.ReadLine());
//ilman erillistä float.Parse()
//mutta muutin tällaiseksi koska vihreä aaltoviiva varoitus
//antoi silloin enemmän tekstiä kuin näin -Sami
//tässä esimerkki: var luku3 = float.Parse(Console.ReadLine());

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
