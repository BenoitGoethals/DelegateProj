using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProj
{

    public class Starter
    {
        static void Main(string[] args)
        {
            Calculator calculator=new Calculator();
            calculator.SetCalulate(Calculator.PlusMultiPly);
            calculator.SetCalulate(Calculator.PlusCal);
            int res = calculator.GetResult(12,12,12);
            Console.WriteLine(res);
            calculator.SetCalulate(k => k.Max());
            Console.WriteLine(res);

           
            Console.WriteLine(calculator.GetResult(12, 12, 12));

            Console.ReadLine();
        }
    }
}
