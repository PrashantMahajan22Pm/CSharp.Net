using System;

class Assign55_1
{
   static void Main(string [] Arg)
  {
  Console.WriteLine("Enter the String ");
  string str = Console.ReadLine();
  char [] srr =ToCharArray(str);
  StringCheck stobj =  new StringCheck();
  int iRet = stobj.WhiteSpace(srr);
    Console.WriteLine("Count of WhiteSpace is "+iRet);
  }
} 

class StringCheck
{

 int WhiteSpace(char [] str)
{
  int iCount = 0;

 for(int i=0; i< str.Length; i++)
 {
 if(str[i] == ' ')
 {
   iCount++;
 }
 }

  return iCount;

}
}