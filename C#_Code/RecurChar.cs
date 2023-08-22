using System;

class RecurChar
{
  static void Main(string [] arg)
  {
 Console.WriteLine("Enter the Number ");
 int iNo = Convert.ToInt32(Console.ReadLine());
 char cCh = 'a';
 Reverse robj = new Reverse();
 robj.Display(iNo,cCh);
  }
}

class Reverse
{
   
 public void Display(int iNum,char ch )
 {
 int iP =(int)ch;
  iP++;
  
  if(iNum == 0)
  {
  return;
  }
  else
  {
    
   Console.Write(ch+"\t");
  char kCh = (char)iP;
    Display(iNum-1,kCh); 
  }
 }
}