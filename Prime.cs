using System;

class Prime
{
    static void Main(String [] Arg)
    { 
   int iCount = 0;
   int iCnt = 0;
   bool bRet = false;
   Console.WriteLine("ENter the Number For Checking Number is Ptrrime or Not ");
   string str = Console.ReadLine();
   int iNo =Convert.ToInt32(str);
 for(iCnt = 1; iCnt < iNo/2; iCnt++)
 {
   if(iNo % iCnt == 0)
   {
    
    iCount++;
    Console.WriteLine("iCnt is "+iCount);
  }
  if(iCount >= 2)
  {
    bRet = true;
    break;
  }
 }

 if(bRet == true)
  {
   Console.WriteLine("It is  Not A  Prime Numbr ");
  }
  else{
   Console.WriteLine("It is Prime Number");
  }  


}
}

 