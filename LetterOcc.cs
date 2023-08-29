using System;

class LetterOcc
{
    static void Main(string [] args)
    {
 Console.WriteLine("Enter the String");
 string str = Console.ReadLine();
  Console.WriteLine("Enter the Charachter");
 char Chr = Convert.ToChar(Console.ReadLine());

 Last lobj = new Last();
 int iRet = lobj.LastOcc(str,Chr);
  if(iRet == 0)
  {
   Console.WriteLine("Character Not Found ");
  }
  else
  {
    Console.WriteLine("Character  Found At "+iRet+" At Index");

  }
 
    }
}

class Last
{
  public int LastOcc(string sstr,char X)
  {int iAns = 0;
   char [] Crr =sstr.ToCharArray();
   for(int i = 0; i< Crr.Length; i++)
   {
    if(Crr[i]==X)
    {
     iAns = i;
    }
   }
   return iAns;
  }
}

