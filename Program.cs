using System;
using static System.Console;

namespace AsciiInfo
{
    class Program
    {
        static void RepeatChar(string character, int reps)
        {
            for (int i = 0; i < reps; i++)
            {
                Write(character);
            }
        }
        static void Main(string[] args)
        {
            // variable declaration
            const int bannerWidth = 54;
            const string name = "Matthew Obert";
            string hometown;
            string major;
            string hobby;
            string activity;

            // variable assignment
            WriteLine("What is your hometown?");
            hometown = ReadLine();
            WriteLine("What is your major?");
            major = ReadLine();
            WriteLine("What is your hobby?");
            hobby = ReadLine();
            WriteLine("What is your favorite activity?");
            activity = ReadLine();

            // output
            RepeatChar("*", bannerWidth);
            WriteLine();

            /*
             * TODO: refactor to use bannerWidth to calculate spacing
             *       instead of relying on hard-coded "magic numbers"
             */

            Write("*|   Name: {0}\\", name);
            RepeatChar(" ", 41 - name.Length);
            WriteLine("*");

            Write("*    Hometown: {0}\\", hometown);
            RepeatChar(" ", 37 - hometown.Length);
            WriteLine("*");

            Write("*    Major: {0}\\", major);
            RepeatChar(" ", 40 - major.Length);
            WriteLine("*");

            Write("*    Hobby: {0}\\", hobby);
            RepeatChar(" ", 40 - hobby.Length);
            WriteLine("*");

            Write("*    Favorite Activity: {0}\\", activity);
            RepeatChar(" ", 27 - activity.Length);
            WriteLine("|*");

            RepeatChar("*", bannerWidth);

        }
    }
}
