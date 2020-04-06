class DelegateTest
{
  public delegate void ExternalHandler(int input);

  public void MyHelperMethod(ExternalHandler delegateInput)
  {
    delegateInput(7);
  }

}