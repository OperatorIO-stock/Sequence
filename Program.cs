using System.Globalization;
using System.IO.Pipelines;

namespace Sequence;

class Program
{
    static void Main(string[] args)
    {
        int finalNumber = 103;
        int initialNumber = 5;
        int stepNumber = 7;

        for(int i = initialNumber; i <= finalNumber; i += stepNumber)
        {
            Console.WriteLine(i);
        }

    }
}