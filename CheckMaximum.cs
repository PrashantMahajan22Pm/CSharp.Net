
using System;
public class CheckMaximum {
    static void Main(string [] Arg)
   {
  Console.WriteLine("Enter the First  Number");
  int iNo1=Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the Second  Number");
  int iNo2=Convert.ToInt32(Console.ReadLine());
  DPint dobj = new DPint(iNo1,iNo2);
  Console.WriteLine("Big Number is "+dobj.Print());
   } 
}
class DPint
{
   private int iNum1;
      private int iNum2;


  public DPint(int X,int Y)
  {
 iNum1 = X;
 iNum2 = Y;
  }
   public int  Print()
   {
   if(iNum1 > iNum2)
   {
 return iNum1;
   }
   else
   {
   return iNum2;
   }
   }
}
