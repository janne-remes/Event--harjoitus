using System;

namespace event_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberAdding lisattavaLuku = new NumberAdding();
            Number lukuJohonLisataan = new Number(2, lisattavaLuku);
            Number toinenLukuJohonLisataan = new Number(5, lisattavaLuku);
            
            Console.WriteLine("Demo, jossa kokeillaan Events- ja " +
                "Delegates-toiminnallisuuksia C#-ohjelmointikielessä.\n\n" +
                "Paina mitä tahansa painiketta jatkaaksesi");

            Console.ReadLine();
            Console.Clear();

            lisattavaLuku.AddOne();
        }
    }
}
