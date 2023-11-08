using System;
   
class MatrixAddition {
     static void Main(string [] Arg)
    {
       
       Console.WriteLine("Enter the Row");
       int iNo1 = Convert.ToInt32(Console.ReadLine());
        
       Console.WriteLine("Enter the Col");
       int iNo2 = Convert.ToInt32(Console.ReadLine());
      
       Matrix mobj = new Matrix(iNo1,iNo2);
      Console.WriteLine("Enter the Matrix elements");
      mobj.Accept();
      mobj.Display();

     Console.WriteLine("Smmetion is "+mobj.Summation());
    }
}
 
  class Matrix
  {
    private int iCol;
    private int iRow;
    private int [,] Arr;
    public Matrix(int X, int Y)
    {
      iCol = X;
      iRow = Y;
      Arr = new int [iCol,iRow];
    }

    public void Accept()
    {
    
     for(int i=0; i< iCol; i++)
     {
      for(int j = 0; j < iRow; j++)
      {
      Arr[i,j] = Convert.ToInt32(Console.ReadLine());
      }
     }
    }

    public void Display()
    {
      for(int i=0; i< iCol; i++)
     {
      for(int j = 0; j < iRow; j++)
      {
        Console.WriteLine(Arr[i,j]+"\t");
      }
     }
    }

    public int Summation()
    {
      int iSum =0;
        for(int i=0; i< iCol; i++)
     {
      for(int j = 0; j < iRow; j++)
      {
        iSum = iSum + Arr[i,j];
      }

     }
      return iSum;
    }
  }
