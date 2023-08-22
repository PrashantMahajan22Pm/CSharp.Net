using System;

class GetReverse 
{
     static void Main(string []  Arg)
    {
   
    Console.WriteLine("Enter the Number ");
     int iNum = Convert.ToInt32(Console.ReadLine());
   Get_Maxi gobj = new Get_Maxi();
  Console.WriteLine("Maximun Digit is "+gobj.IMaX(iNum));
    }
}
class Get_Maxi
{
   public  int iDigit ;
   public int iNumber = 0;
  public int IMaX(int iNo)
  {
   
  if(iNo == 0)
  {
  return iNumber;
  }
  else
  { 
  iDigit = iNo % 10;
 
  iNumber =iNumber * 10 + iDigit;  
    IMaX( iNo /= 10);
  }
  
   return iNumber;
  }
}
