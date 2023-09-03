using System;

class ArraySum
{
 static void Main(string [] arg)
 {
  Console.WriteLine("Enter the Array size ");
 int iSize = Convert.ToInt32(Console.ReadLine());
 BuSum bobj = new BuSum();
 Console.WriteLine(bobj.Sum(iSize));
 }
}

class BuSum
{
 public int Sum(int iSiz)
 {
  int [] Arr  =new int[iSiz];
  int iSum = 0;
  for(int i= 0; i< iSiz; i++)
  {
   Arr[i] = Convert.ToInt32(Console.ReadLine());
  }
   for(int i= 0; i< iSiz; i++)
  {
    iSum += Arr[i];
  }
  return iSum;
 }
 
}