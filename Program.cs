﻿using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi == 10)
        {
            Console.WriteLine("Girilen sayı 10'a eşittir.");
        }
        else if (sayi < 10)
        {
            Console.WriteLine("Girilen sayı 10'dan küçüktür.");
        }
        else
        {
            Console.WriteLine("Girilen sayı 10'dan büyüktür.");
        }

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }
    }
}
