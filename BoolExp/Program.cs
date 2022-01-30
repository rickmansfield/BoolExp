using System;

namespace BoolExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int apples = 6;
            int oranges = 9;
            decimal applePrice = 12.60m;
            decimal orangesPrice = 4.50m;

            //Console.WriteLine(apples == oranges);
            //Console.WriteLine(apples != oranges);
            //Console.WriteLine($"1. {apples} > {oranges} is {apples > oranges}");
            //Console.WriteLine($"2. {apples} < {oranges} is {apples < oranges}");
            //Console.WriteLine($"3. {apples} >= {oranges} is {apples >= oranges}");
            //Console.WriteLine($"4. {apples} <= {oranges} is {apples <= oranges}");
            //Console.WriteLine($"5. {apples} is int is {apples is int}");

            //Console.WriteLine($"A) Reducing apple cost: {(apples > oranges) && (applePrice > orangesPrice)}");
            //Console.WriteLine($"B) Reducing apple cost: {(apples > oranges) || (applePrice > orangesPrice)}");
            bool moreApples;
            bool applesAreDearer;

            moreApples = (apples > oranges);
            applesAreDearer = (applePrice > orangesPrice);
            Console.WriteLine($"We have more apples: {moreApples}");
            Console.WriteLine($"Apples are dearer: {applesAreDearer}");

            //Console.WriteLine($"Reducing apple cost: {moreApples && applesAreDearer}");
            //Console.WriteLine($"Reducing apple cost: {moreApples || applesAreDearer}");

            bool moreApplesAndDearer = moreApples && applesAreDearer;
            bool moreApplesOrDearer = moreApples || applesAreDearer;
            Console.WriteLine($"Reducing apple cost: {moreApplesAndDearer}");
            Console.WriteLine($"Reducing apple cost: {moreApplesOrDearer}");
        }
    }
}
