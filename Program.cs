using System;

namespace Delegates
{
  class Program
  {
    public delegate void InternalHandler(int input);
    static void Main(string[] args)
    {
      // internal call 
      // the pipeline (delegate) dumps its data to a an "event handler" DelegateMethod
      InternalHandler delInternal = new InternalHandler(DelegateMethod);
      delInternal(2);

      // external call
      DelegateTest delExternal = new DelegateTest();
      DelegateTest.ExternalHandler externalHandler = DelegateMethod;
      delExternal.MyHelperMethod(externalHandler);
    }

    static void DelegateMethod(int inputValue)
    {
      inputValue++;
      System.Console.WriteLine("the value is: " + inputValue.ToString());
    }

  }
}
