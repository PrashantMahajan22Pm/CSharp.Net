using System;

class FirstOcc
{
  static void Main(string [] arg)
  {
 Console.WriteLine("Enter the size of array ");
 int iSize = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter the Search ");
 int iSea = Convert.ToInt32(Console.ReadLine());
 int [] Arr = new int[iSize];
 Search sobj = new Search(Arr,iSize); 
 int bAns ;
   sobj.Accept();
 bAns= sobj.First(iSea);
 if(bAns != -1)
  {Console.WriteLine("First Occurance is "+bAns);
  }
  else
  {
  Console.WriteLine("Element Not Found ");
  }
  }
}
class Search
{ 
  private int [] Crr;
  private int sizeI;
  private int i;

  public Search(int [] X, int Y)
  {
   Crr = X;
   sizeI = Y;
  }

  public void Accept()
  {
    Console.WriteLine("Enter the Array Element ");
     for(i = 0; i< sizeI ; i++)
    {
     Crr[i] = Convert.ToInt32(Console.ReadLine());
     }
    }
  public int First(int SeaI)
  {
   
    int iRet = -1;
    for(i = 0; i< sizeI ; i++)
    {
     if(Crr[i] == SeaI)
     {
     iRet = i;
     }
    }
    return  iRet;
  }
}