using System;

namespace Delegates
{
  class Program
  {
    public delegate void InternalHandler(int input);
    static void Main(string[] args)
    {
      // internal call
      InternalHandler delInternal = new InternalHandler(DelegateMethod);
      delInternal(2);

      // external call
      DelegateTest delTest = new DelegateTest();
      DelegateTest.ExternalHandler ExternalHandler = DelegateMethod;
      delTest.MyHelperMethod(ExternalHandler);
    }

    static void DelegateMethod(int inputValue)
    {
      inputValue++;
      System.Console.WriteLine("the value is: " + inputValue.ToString());
    }

  }
}
