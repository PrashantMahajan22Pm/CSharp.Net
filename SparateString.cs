using System;

class SparateString
{
 static void Main(string [] arg)
 {
  Console.WriteLine("Enter the String ");
  string srr =Console.ReadLine();
  Spaces sobj = new Spaces(srr);
    sobj.White();
  
 }
}

class Spaces
{
  private string str;
  public Spaces(string X)
  {
 str = X;
  }
  public void White()
  {
    char [] crr = str.ToCharArray();
    char [] Copy = new char [crr.Length];
    int j = 0;
    int k = 0;
    int p = 0;
    for(int i = 0; i < crr.Length; i++)
    {
     if(crr[i] != ' ')
     {
      Copy[j] = crr[i];
      j++;
     }
     else
     { 
        Console.WriteLine("");
      for( k = p; k < j; k++){
        Console.Write(Copy[k]);
     p++;   
      }
     }
     k = p;
    }
  }
}