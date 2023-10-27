 using System;

public class CountDigitFrequecy {
     static void Main(string [] arg)
    {
  Console.WriteLine("Enter the Number ");
  string strNo= Console.ReadLine();
  int iNo = int.Parse(strNo);
  Console.WriteLine("Enter the Search Digit ");
  string strSea = Console.ReadLine();
  int isea = int.Parse(strSea);
  CountDigit cdobj = new CountDigit(iNo,isea);
 Console.WriteLine("Search Found at "+ cdobj.CoutD()+" times");
   
 }
}

class CountDigit
{
  public int iNo;
  public int iSea;
  public CountDigit(int X , int y)
  {
  iNo = X;
  iSea = y;
  }
  public int CoutD()
  {
  int iCount = 0;
  int itemp = iNo;
  int iDigit = 0;
  
  while(itemp != 0)
  {
  iDigit = itemp % 10;
   if(iDigit == iSea)
   {
     iCount++;
   }
   itemp = itemp / 10;
   iDigit = 0;
  }
  return iCount;
  }
}
