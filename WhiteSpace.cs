using System;

class WhiteSpace
{
 static void Main(string [] arg)
 {
  Console.WriteLine("Enter the String ");
  string srr =Console.ReadLine();
  Spaces sobj = new Spaces(srr);
  string sRet = sobj.White();
  Console.WriteLine("New string is "+sRet);
 }
}

class Spaces
{
  private string str;
  public Spaces(string X)
  {
 str = X;
  }
  public string White()
  {
    char [] crr = str.ToCharArray();
    char [] Copy = new char [crr.Length];
    int j = 0;
    for(int i = 0; i < crr.Length; i++)
    {
     if(crr[i] != ' ')
     {
      Copy[j] = crr[i];
      j++;
     }
    }
    return new string(Copy);
  }
}