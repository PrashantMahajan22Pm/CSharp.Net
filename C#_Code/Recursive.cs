using System;

class Recursive
{
  static void Main(string [] arg)
  {
 Console.WriteLine("Enter the Number ");
 int iNo = Convert.ToInt32(Console.ReadLine());
 Reverse robj = new Reverse();
 robj.Display(iNo);
  }
}

class Reverse
{
   
 public void Display(int iNum)
 {
  if(iNum == 0)
  {
  return;
  }
  else
  {
    Console.Write("*\t");
    Display(iNum-1); 
  }
 }
}