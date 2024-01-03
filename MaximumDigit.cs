using System;

class MaximumDigit
{
 static void Main(string [] arg)
 {
   Console.WriteLine(" Enter the Number");
   int iValu = Convert.ToInt32(Console.ReadLine()); 
   DemoChecker dobj = new DemoChecker(iValu); 
   Console.WriteLine(" Big number is "+dobj.BigGetter());
  }
 }

class DemoChecker
{
  public int iNum;
  public DemoChecker(int xNo)
   {
    iNum = xNo;
   }
 public int BigGetter()
   {
   int iBig = 0;
   int iDigi = 0;

   while(iNum != 0)
   {
     iDigi = iNum % 10;
     if(iBig < iDigi)
     {
       iBig = iDigi;
     }
     iNum /= 10;
   }
   return iBig;
   }
}