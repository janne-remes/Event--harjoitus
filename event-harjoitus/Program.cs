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

            Console.WriteLine("Demo, jossa testataan Events- ja " +
                "Delegates-toiminnallisuuksia C#-ohjelmointikielessä.\n\n" +
                "Paina mitä tahansa painiketta jatkaaksesi.");

            Console.ReadLine();
            Console.Clear();

            lisattavaLuku.AddOne();

            Console.WriteLine();

            lisattavaLuku.AddTwo();

            Console.WriteLine();

            lisattavaLuku.AddThree();

            Console.WriteLine();

            lisattavaLuku.AddFour();

            Console.WriteLine();

            lisattavaLuku.AddFive();

            Console.WriteLine();

            vahennettavaLuku.SubtractOne();

            Console.WriteLine();

            vahennettavaLuku.SubtractTwo();

            Console.WriteLine();

            vahennettavaLuku.SubtractThree();

            Console.WriteLine();

            vahennettavaLuku.SubtractFour();

            Console.WriteLine();

            vahennettavaLuku.SubtractFive();
        }
    }
}
