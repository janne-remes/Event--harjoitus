using System;

namespace event_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberAdding lisattavaLuku = new NumberAdding();

            NumberSubtraction vahennettavaLuku = new NumberSubtraction();

            Number ekaLuku = new Number(-10, lisattavaLuku, vahennettavaLuku);
            Number tokaLuku = new Number(-5, lisattavaLuku, vahennettavaLuku);
            Number kolmasLuku = new Number(0, lisattavaLuku, vahennettavaLuku);
            Number neljasLuku = new Number(5, lisattavaLuku, vahennettavaLuku);
            Number viidesLuku = new Number(10, lisattavaLuku, vahennettavaLuku);

            NumberAdding toinenLisattavaLuku = new NumberAdding();
            NumberSubtraction toinenVahennettavaLuku = new NumberSubtraction();

            Number kuudesLuku = new Number(27, toinenLisattavaLuku, toinenVahennettavaLuku);
            Number seitsemasLuku = new Number(-97, toinenLisattavaLuku, toinenVahennettavaLuku);

            Console.WriteLine("Demo, jossa testataan Events- ja " +
                "Delegates-toiminnallisuuksia C#-ohjelmointikielessä.\n\n" +
                "Ohjelma käynnistyy automaattisesti muutaman sekunnin kuluttua...");

            System.Threading.Thread.Sleep(10000);
            Console.Clear();

            lisattavaLuku.AddOne();
            vahennettavaLuku.SubtractOne();

            lisattavaLuku.AddTwo();
            vahennettavaLuku.SubtractTwo();

            lisattavaLuku.AddThree();
            vahennettavaLuku.SubtractThree();

            lisattavaLuku.AddFour();
            vahennettavaLuku.SubtractFour();

            lisattavaLuku.AddFive();
            vahennettavaLuku.SubtractFive();

            Console.WriteLine("\n----\n\n" +
                "Pieni lisätesti toisilla NumberAdding- ja NumberSubtraction -luokan muuttujilla " +
                "sekä kahdella Number-luokan edustajalla:\n\n");
            
            toinenLisattavaLuku.AddFive();
            toinenLisattavaLuku.AddOne();

            toinenVahennettavaLuku.SubtractThree();
            toinenVahennettavaLuku.SubtractTwo();
        }
    }
}
