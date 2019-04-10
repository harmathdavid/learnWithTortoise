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

        const int StepSize = 3;

        public static void InitaializeComponents()
        {
            Console.Clear();
            X = Console.WindowWidth / 2;
            Y = Console.WindowHeight / 2;
            Console.SetCursorPosition(X, Y);

            Console.Write("O");
        }

        static void Core()
        {
            Thread.Sleep(1000);

            Console.Clear();
            if ((X < Console.WindowWidth && X > 0) && (Y < Console.WindowHeight && Y > 0))
            {

                Console.SetCursorPosition(X, Y);
                Console.Write("O");
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

    }
}
