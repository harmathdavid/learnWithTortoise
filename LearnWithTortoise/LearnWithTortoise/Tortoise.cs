using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace LearnWithTortoise
{
    class Tortoise
    {
        static int X { get; set; }
        static int Y { get; set; }

        const int StepSize = 1;

        static Tortoise()
        {
            Console.Clear();
            X = Console.WindowWidth / 2;
            Y = Console.WindowHeight / 2;
            Console.SetCursorPosition(X, Y);

            DrawTortoise();
        }

        static void Core()
        {
            Thread.Sleep(1000);

            Console.Clear();
            if ((X < Console.WindowWidth - 4 && X > 0) && (Y < Console.WindowHeight && Y > 0))
            {

                Console.SetCursorPosition(X, Y);
                DrawTortoise();
            }
            else
            {
                X = Console.WindowWidth / 2;
                Y = Console.WindowHeight / 2;
                Console.SetCursorPosition(X, Y);

                Console.Write("Game Over");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }

        static void DrawTortoise()
        {
            Console.Write(@"\o/");
            Console.SetCursorPosition(Console.CursorLeft - 4, Console.CursorTop + 1);
            Console.Write(@"-( )-");
        }

        public static void StepForward()
        {
            Y -= StepSize;
            Core();
        }

        public static void StepBackward()
        {
            Y += StepSize;
            Core();
        }

        public static void StepLeft()
        {
            X -= StepSize;
            Core();
        }

        public static void StepRight()
        {
            X += StepSize;
            Core();
        }

        public static bool NextStepIsWall()
        {
            if ((X == Console.WindowWidth - 5 || X == 1) || (Y == Console.WindowHeight - 1 || Y == 1))
            {
                return true;
            }


            return false;
        }

    }
}
