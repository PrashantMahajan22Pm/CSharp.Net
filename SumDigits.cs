using System;

class SumDigits
{
  static void Main(string [] arg)
  {
     Console.WriteLine("Enter the Number ");
     int iNo = Convert.ToInt32(Console.ReadLine());
   Demo dobj  = new Demo();
   Console.WriteLine("Addition is "+dobj.Sum(iNo));
  }
}
class Demo
{
    private int iSum=0;
  public int Sum(int iNum)
  {
    int iDigit = 0;
   if(iNum == 0)
   {
    return iSum;
   }
  else
  {
   iDigit = iNum % 10;
   iSum += iDigit;
   Sum(iNum /10);
  }
   return iSum; 
 }
       
}