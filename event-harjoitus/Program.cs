using System;

namespace event_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberAdding lisattavaLuku = new NumberAdding();
            Number ekaLuku = new Number(2, lisattavaLuku);
            Number tokaLuku = new Number(5, lisattavaLuku);
            Number kolmasLuku = new Number(17, lisattavaLuku);
            
            Console.WriteLine("Demo, jossa testataan Events- ja " +
                "Delegates-toiminnallisuuksia C#-ohjelmointikielessä.\n\n" +
                "Paina mitä tahansa painiketta jatkaaksesi.");

            Console.ReadLine();
            Console.Clear();

            lisattavaLuku.AddTwo();

            Console.WriteLine();

            lisattavaLuku.AddFive();
        }
    }
}
