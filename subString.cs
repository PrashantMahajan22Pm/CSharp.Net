
 using System;


public class subString
 {
     static void Main(string [] arg)
    {
    string sc = "abcabcbb";
    subCheker aobj = new subCheker();
    aobj.Cheker(sc);
    }
}


class subCheker
{
  public void Cheker(string str)
  {
    char [] srr = str.ToCharArray();
    Console.WriteLine("String is : "+srr.Length);
    char [] check = new char[srr.Length];
    int A = 0;
    bool  bchk= true;
    string afterSet = "";


    for(int i= 0; i<srr.Length;i++)
    {
       bchk= true;
     for(int j=0; j<=A;j++)
      {
         if(srr[i] == check[j])
        {
          bchk = false;
          break;
        }
       
      }
         if(bchk == true) 
        {
        check[A] = srr[i];
        afterSet += srr[i];
        A++;
        }
    }   
    Console.WriteLine("SubString is : "+afterSet);
  }
}
