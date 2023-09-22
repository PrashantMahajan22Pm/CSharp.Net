using System;

class LinePrint {
     static void Main(string [] Arg)
    {
   
  Console.WriteLine("Enter the Coloum ");
   int iNo1 = Convert.ToInt32(Console.ReadLine());
   int iNo2 = Convert.ToInt32(Console.ReadLine());
   Print pobj = new Print(iNo1 , iNo2);
   pobj. Display();
  }
}

class Print
{
  private int iRow;
  private int iCol;

 public  Print(int X, int Y)
 {
   iRow = X;
   iCol = Y;
 }

 public void Display()
 {
  int i = 0, j =0;

  for(i =1;i <=iRow ; i++)
  {
    for(j = 1; j<= iCol; j++)
    {
      if(i % 2 != 0 )
        {
         Console.Write("#\t");
        }
        else
        {
            {
         Console.Write("*\t");
        }
        }
      }
       Console.WriteLine("");
    }
   
  }
}
