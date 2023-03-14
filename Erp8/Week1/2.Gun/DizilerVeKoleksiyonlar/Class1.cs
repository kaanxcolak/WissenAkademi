using System;

public class Class1
{
    public Class1()
    {
        int[,] dizi = new int[2, 3];
        Random rnd = new();
        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            for(int  j= 0; j < dizi.GetLength(1); j++)
            {
                dizi[i, j] = rnd.Next(1, 100);
            }
        }


    }
}
