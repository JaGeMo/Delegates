using System;

namespace Delegates
{
  class Program
  {
    public delegate void NewDelegate(int input);
    static void Main(string[] args)
    {
      // internal call
      NewDelegate newDelegate = new NewDelegate(DelegateMethod);
      newDelegate(2);

      // external call
      DelegateTest delTest = new DelegateTest();
      DelegateTest.TestDelegate testDelegate = DelegateMethod;
      delTest.MyHelperMethod(testDelegate);
    }

    static void DelegateMethod(int inputValue)
    {
      inputValue++;
      System.Console.WriteLine("the value is: " + inputValue.ToString());
    }

  }
}
