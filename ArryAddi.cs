using System;
class ArryAddi
{
  static void Main(string [] Arg )
 {
 Console.WriteLine("Enter the Size ");
 
  int iSize = Convert.ToInt32(Console.ReadLine());
  int [] Crr  = new int[iSize] ;
  Aarray aobj = new Aarray(iSize,Crr);
  aobj.Accept();
  aobj.Display();
  int iRet = aobj.Sum();
  Console.WriteLine("Summetion of array is "+iRet);
 }
}

class Aarray
{
 private int [] Arr;
 private int Size;
 private int i;

 public Aarray(int X,int [] AR)
 { 
    Size = X;
    Arr = AR;
 }
 public void Accept()
 {
  Console.WriteLine("Enter the Array ");
   for(i =0; i < Size; i++)
    {
   Arr[i] = Convert.ToInt32(Console.ReadLine());
    }
 }
 public void Display()
 {
  Console.WriteLine("  Array is  ");
   for(i =0; i < Size; i++)
    {
  Console.WriteLine( Arr[i]);
    }
 }

 public int Sum()
 {
    int iCount = 0;
  Console.WriteLine("  Array is  ");
   for(i =0; i < Size; i++)
  {
   iCount+= Arr[i];
  }
   return iCount;
 }
 }

 