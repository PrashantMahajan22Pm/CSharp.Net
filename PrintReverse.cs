 using System;

class PrintReverse
{
 
  static void Main(string [] Arg)
 {
  Console.WriteLine("Enter the NUmber ");
  int iNo = Convert.ToInt32(Console.ReadLine());
  DisRev drobj = new DisRev(iNo);
  drobj.Display();

 }
}

class DisRev
{
 private int iNo;
 public DisRev(int iN)
 {
  iNo = iN;
 }
 public void Display()
 {
  int temp = iNo;
   iNo *= -1;
   int i=0;
   for(i=temp;i>=iNo;i-- )
   {
  Console.Write(i+"\t");
   }
 
 }
}