using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithTortoise
{
    class Program
    {
        static void Main(string[] args)
        {
            Tortoise.StepForward();
            Tortoise.StepRight();
            Tortoise.StepBackward();
            Tortoise.StepLeft();

            Console.ReadLine();
        }
    }
}
