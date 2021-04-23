using System;
using System.Threading;

namespace ConsoleSaat
{
    public static class Clock
    {
        public static void GetTime()
        {
            for (byte saat = 0; saat < 60; saat++)
            {
                for (byte dakika = 0; dakika < 60; dakika++)
                {
                    for (byte saniye = 0; saniye < 60; saniye++)
                    {

                        string saatStr = (saat < 10) ? "0" + saat : saat.ToString();
                        string dakikaStr = (dakika < 10) ? "0" + dakika : dakika.ToString();
                        string saniyeStr = (saniye < 10) ? "0" + saniye : saniye.ToString();

                        string sonuc = saatStr + ":" + dakikaStr + ":" + saniyeStr;
                        Console.Clear();
                        ConsoleHelper.SetCurrentFont("Consolas", 21);
                        Console.CursorTop = Console.WindowHeight / 2;
                        Console.CursorLeft = Console.WindowWidth / 2;
                        Console.ForegroundColor = (ConsoleColor)(saniye % 12);

                        Console.Title = sonuc;
                        Console.WriteLine(sonuc);
                        Thread.Sleep(1000);
                    }
                }
            }

        }
    }
}
