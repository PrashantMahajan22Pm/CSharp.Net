using System;

class CountDigitNumber
{
  static void Main(string [] arg)
  {
  Console.WriteLine("Enter the Number ");
  int iNo =  Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the Search ");
  int iSearch =  Convert.ToInt32(Console.ReadLine()); 

CountD cdobj = new CountD();
  // bAns = false;
  bool bAns = cdobj.CheckNum(iNo,iSearch);

  if(bAns == true )
  {
    Console.WriteLine("Number is Found");
  }
  else
  {
    Console.WriteLine("Number is Not Found");
  }
  }
}

class CountD{
   public bool CheckNum(int iNo, int iCheck)
  {
 int iDigit = 0;
 //int iCount = 0;
 bool bRet = false;

 while(iNo != 0)
 {
 iDigit = iNo % 10;
 if(iDigit == iCheck)
 {
  bRet = true;
  break;
 } 
 iNo /= 10;
 
 }
   return bRet;
  }
}


   