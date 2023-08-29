using System;

class SumOfN
{
  static void Main()
  {
    Console.WriteLine("Enter the Number for Size");
    int iSize = Convert.ToInt32(Console.ReadLine());
    int [] Arr = new int[iSize];
    int iCnt = 0;
    Console.WriteLine("Enter the Array Element ");
    for(iCnt = 0;iCnt < iSize; iCnt++)
    {
     Arr[iCnt]=Convert.ToInt32(Console.ReadLine());
    }
    
    Addition aobj = new Addition(Arr);
    int iRet = aobj.BigNuM();
    Console.WriteLine("Biggest Number in Array is "+iRet);
    iRet = aobj.SmallNum();
    Console.WriteLine("Smallest Number in Array is "+iRet);

  }
}

class Addition{
  private int [] Drr;
  public Addition(int[] X)
  {
  Drr = X;
  }
 public int BigNuM()
  {
  int BNum = 0;
  for(int iCnt= 0; iCnt < Drr.Length;iCnt++)
  {
    if(Drr[iCnt] > BNum)
    {
    BNum = Drr[iCnt];  
    }
  }
  return BNum;
  }

  public int SmallNum()
  {
   int SNum = Drr[0];
   for(int iCnt = 0; iCnt < Drr.Length; iCnt++)
   {
    if(Drr[iCnt] < SNum)
    {
        SNum = Drr[iCnt];
    }
   }
   return SNum;
  }
}