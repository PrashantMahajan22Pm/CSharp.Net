  /*
    Input : 

    Row : 4
    Col : 4

    Output : 
                *
            *   *
        *   *   *   
   *    *   *   *   
        *   *   *    
            *   *
                *

*/  

using System;

class Arrow
{
  static void Main(string [] arg)
 {
  
 Console.WriteLine("Enter the Row ");
 int iNo1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the Coloum ");
 int iNo2 = Convert.ToInt32(Console.ReadLine());
 DemoDisplay ddobj = new DemoDisplay();
 ddobj.Display(iNo1, iNo2);
 }
}

class DemoDisplay
{
  public void Display(int iCol, int iRow)
  {
  int i= 0;
  int j = 0;

 
  for(i = iCol; i>= 1 ;i--)
  {
  for(j = 1; j<=iRow; j++)
  {
    if(i <= j)
    {
 Console.Write("*\t");
    }
    else
    {
     Console.Write(" \t");
    }
  }
  Console.Write(" \n");
  }
   for(i = 1; i<= iCol; i++)
  {
  for(j = 1; j<= iRow; j++)
  {
    if(i <= j)
    {
 Console.Write("*\t");
    }
    else
    {
     Console.Write(" \t");
    }
  }
  Console.Write(" \n");
  }
 
  }
}