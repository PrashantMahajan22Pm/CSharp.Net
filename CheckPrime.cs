using System;

class CheckPrime
{
  static void Main(string [] Arg)
 {
 
  Console.WriteLine("Enter Number for Checking ");
  int iNum = Convert.ToInt32(Console.ReadLine());
  Prime pobj = new Prime(iNum);
  bool bAns = false;
  bAns = pobj.Check();
  if(bAns == true)
  {
   Console.WriteLine("IT is Prime Number");
  }
  else
  {
    Console.WriteLine("It is Not a Prime Number");
   }
  }
 } 

class Prime
{
  public int iNo;
  public int i;
  public Prime(int X)
  {
  iNo = X;
  i = 0;
  }
  public bool Check()
  {
   int iTemp = iNo;
   bool bRet = true;
   int iFact = 0;
   for(i = 1;i< iTemp;i++)
   {
     if(iNo % 2 == 0)
     {
      iFact++;
     }
   }
   if(iFact >= 2)
   {
    bRet = false;
   }
   return bRet;
  }
}