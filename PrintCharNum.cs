using System;
 class PrintCharNum {
    static void Main(string [] Arg)
   {
  Console.WriteLine("Enter the Number");
  int iNo= Convert.ToInt32(Console.ReadLine());
  DPint dobj = new DPint(iNo);
  dobj.Print();
   } 
}
class DPint
{
   private int iNo;

  public DPint(int X)
  {
 iNo = X;
  }
   public void Print()
   {
  int i=0,j=0;
  char ch = 'a';
  
  for(i = 1; i<=iNo; i++) 
  {   j = (int)ch;
   Console.Write(ch+"\t"+i+"\t");
   j++;
    ch= (char)j;
  }
   }
}
