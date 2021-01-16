using System;
using System.Collections.Generic;

namespace CampIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            string siteUrl = "http://teknoget.net";
            bool uyeMi = true;
            bool yetki = true;

            if (siteUrl == "http://teknoget.net")
            {
                if (uyeMi)
                {
                    if (yetki)
                    {
                        Console.WriteLine("Giriş Başarılı ! Yönlendiriliyorsunuz...");
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm artık sisteme giriş yetkiniz yok.");
                    }
                }
                else
                {
                    Console.WriteLine("Üye değilsiniz.");
                }
            }
            else
            {
                Console.WriteLine("Gelen post başka siteden.");
            }

        }
    }
}
