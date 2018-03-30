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
            int res = calculator.GetResult(12, 3, 122);
            Console.WriteLine(res);

            calculator.SetCalulate(Calculator.PlusCal);
             res = calculator.GetResult(12,3,122);
            Console.WriteLine(res);
         
            calculator.SetCalulate(k => k.Max());
            res = calculator.GetResult(12, 3, 122);
            Console.WriteLine(res);

            calculator.SetCalulate(calculate: new Calculate(z=>z.Min()));
            res = calculator.GetResult(12, 3, 122);
            Console.WriteLine(res);

           
          

            Console.ReadLine();
        }
    }
}
