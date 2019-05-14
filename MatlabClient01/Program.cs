using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathWorks.MATLAB.NET.Utility;

namespace MatlabClient01
{
    class Program
    {
        static void Main(string[] args)
        {
            y ystruct;
            Double[] yarray;

            MatlabInterfaceClient client = new MatlabInterfaceClient();
            double value = 32.5;
            ystruct = client.callMATLABfunction_1(value);
            Console.WriteLine("Reply from client (function1)..Completion [{0}], Result [{1}], Message [{2}]", ystruct.Completion, ystruct.Result, ystruct.Message);

            yarray = client.callMATLABfunction_2(value);
            Console.WriteLine("Reply from client (function2)..Array Size [{0}], Array value 0 [{1}], Array Value 1 [{2}]", yarray.Length, yarray[0], yarray[1]);
            Console.WriteLine("Press any key to close the client.");
            Console.ReadLine();
            Console.WriteLine("Closing client...");
        }
    }
}
