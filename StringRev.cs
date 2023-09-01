using System;

class StringRev
{
  static void Main(string [] Arg)
 {
   
  Console.WriteLine("Enter the String ");
   string stt = Console.ReadLine();
   Revv robj = new Revv(stt);
   Console.WriteLine("New String is "+robj.Rev());
 }
}

class Revv
{
  private String str;

  public Revv(String X)
  {
 str =X;
  }
  public String Rev()
  {
    char [] ch = str.ToCharArray();
    int Start = 0;
    int End = str.Length-1;
    char temp ;
  
    while (Start < End)
    {
      temp = ch[Start];
      ch[Start] = ch [End];
      ch[End] = temp;      
        Start ++;
        End--;
    }
     return new String (ch);
  }
}