using System;
 class PrintHashStar {
      static void Main(string [] arg )
 {
    Console.WriteLine("Enter the Rows");
    string str1 = Console.ReadLine();
    int iNum1 = int.Parse(str1);
    string str2 = Console.ReadLine();
    Console.WriteLine("Enter the Colums");
    int iNum2 = int.Parse(str2);
    Display dobj = new Display();
     dobj.Print(iNum1, iNum2);

 }
}

  class Display
{
 public void Print(int iCol , int iRow)
 { 
   for(int i= 1; i < iCol; i++)
   {
    for(int j = 1; j< iRow ; j++)
    {
       if(i % 2 == 0)
      {
    Console.Write("*\t");
     }
     else
     {
    Console.Write("#\t"); 
     }
    }
    Console.WriteLine("");
   }
 }
}