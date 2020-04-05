class DelegateTest
{
  public delegate void TestDelegate(int input);

  public void MyHelperMethod(TestDelegate delegateInput)
  {
    delegateInput(7);
  }

}