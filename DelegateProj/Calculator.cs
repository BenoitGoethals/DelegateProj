using System;
using System.Linq;

namespace DelegateProj
{
    /**
    Points to Remember :
    Delegate is a function pointer. It is reference type data type.
    Syntax: public delegate void <function name>(<parameters>)
    A method that is going to assign to delegate must have same signature as delegate.
    Delegates can be invoke like a normal function or Invoke() method.
    Multiple methods can be assigned to the delegate using "+" operator. It is called multicast delegate.
    **/
    public delegate int Calculate(params int[]nums);

    public class Calculator
    {
        private Calculate _calculate;


        public void SetCalulate(Calculate calculate)
        {
            this._calculate += calculate;
        }


        public int GetResult(params int[] nums)
        {
            return _calculate(nums);
        }


        public static int PlusCal(params int[] nums)
        {

            return nums.Sum();
        }

        public static int PlusMultiPly(params int[] nums)
        {

       
            int ret = 0;
            foreach (var vNum in nums)
            {
                ret *= vNum;
            }
            return ret;
        }

    }
}