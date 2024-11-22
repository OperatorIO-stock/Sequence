using System.Globalization;
using System.IO.Pipelines;

namespace Sequence;

class Program
{
    static void Main(string[] args)
    {
        int finalNumber = 103;
        int stepNumber = 7;
        int initialNumber = 5;

        for(int i = 0; initialNumber <= finalNumber; initialNumber += stepNumber)
        {
            Console.WriteLine(initialNumber);
        }
    }
}