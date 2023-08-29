
// check weather  7 th bit is on or off 

using System;

class CheckBit
{
 static void Main(string [] arg)
 {
  Console.WriteLine("Enterthe Number ");
  int iNo = Convert.ToInt32(Console.ReadLine());
  Bit bobj = new Bit();
  bool bRet = false;
  bRet = bobj.CheckBit(iNo);
  if(bRet == true)
  {
 Console.WriteLine("7 th bit is oN ");
  }
  else
  {
 Console.WriteLine("7 th bit is oFF ");

  }
 }
}

class Bit{
   public bool CheckBit(long iNo)
   {
   long iMask = 0x40;
   long iResult = 0;

   iResult = iMask & iNo;

   if(iResult == iMask)
   {
    return true;
   }
   else
   {
    return false;
   }
   }
}
