using System.Globalization;
using System.IO.Pipelines;

namespace Sequence;

class Program
{
    static void Main(string[] args)
    {
        int initialNumber = 5;
        int finalNumber = 103;
        
        int stepNumber = 7;

        for(int i = initialNumber; initialNumber <= finalNumber; initialNumber += stepNumber)
        {
            Console.WriteLine(initialNumber);
        }
    }
}