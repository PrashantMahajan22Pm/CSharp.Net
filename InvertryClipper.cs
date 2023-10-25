using System;
class InvertryClipper
{
  static  void Main(string [] Arg)
  { 
   
   Console.WriteLine("***CMC Inventery System***");
    Create_In Cobj = new Create_In();
   Cobj.CreateClipper("Cycle");
   Cobj.CreateClipper("BiCycle");
   Cobj.CreateClipper("Train");
   Cobj.CreateClipper("Bus");
   Cobj.CreateClipper("Bike");
//    char ch = Convert.ToChar(Console.ReadLine()); ;
    while(true)
    {
    Console.WriteLine("\n 'a' for adding Inventry \t'R' for Remove Inventry \t 'G' for Display  Graph \t 'Q' for Quit");
    char ch = Convert.ToChar(Console.ReadLine());
    if(ch == 'a')
    {
      Console.WriteLine("Enter the Code");
      int ICod = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(" Add the Inventry");
      int Inv = Convert.ToInt32(Console.ReadLine());
      Cobj.Accept(ICod, Inv);
    }
    else if(ch == 'R')
    {
      Console.WriteLine("Enter the Code");
      int ICod = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(" Remove the Inventry");
      int Inv = Convert.ToInt32(Console.ReadLine());
      Cobj.Remove(ICod, Inv);
    }
    else if(ch == 'G')
    {
     Cobj.Display1();
      Cobj.Display();
    }
     else if(ch == 'Q')
     {
       break;
     }
    }
  }
}

class Node
{
 public int  Item_Code;
 public String Products;
 public int Inventery;
 public Node next;

 public Node( String str,int iCode, int Zero)
 {
    this.Products = str;
    this.Item_Code = iCode;
    this.Inventery = Zero;
    this.next = null;
 }
 }

 //////////new Class////////////

class Create_In
{
 public Node first;
 public int iCount;
 public int Code;
 private int iCnt;

 public Create_In()
 {
  this.first = null;
  this.iCount = 0;
  this. Code = 1;
  this.iCnt = 0; 

 }

 public int Count()
 {
    return this.iCount;
 }

 public void CreateClipper(String str)
 { 
  int aTemp = 0;
  
   Node newn = new Node(str,Code,aTemp);
   
   Code++;

   if(first == null)
   {
    first = newn;
   }
   else
   {
    Node temp = first;
   
   while(temp.next != null)
   {
    temp = temp.next;
    }
    temp.next = newn;
  }
    this.iCount++;
    Console.WriteLine("Product is added "+newn.Products+" and its Code is "+newn.Item_Code);
 }


  public void Accept(int ICode, int Inv)
  { 
    int iCheck = 0;
    Node temp = first;
    if(Inv <= 0 || Inv >= 51)
    {
      Console.WriteLine("Wrong Entry");
      return ;
    }
  
    for(int i= 1; i< ICode ; i++)
    {
    if(temp == null)
    {
      Console.WriteLine("Temp is Null");
      return;
    }
    temp = temp.next;
  }
     iCheck =temp.Inventery + Inv;
     if(iCheck <= 50)
     {
     temp.Inventery = iCheck;
     }
     else
     {
      Console.WriteLine("Unable to add Inventry");
      return;
     }
  }

  public void Remove(int ICode,int Inv)
  {   
    
    int iCheck = 0;
    Node temp = first;
    if(Inv <= 0 || Inv >= 51)
    {
      Console.WriteLine("Wrong Entry");
      return ;
    }
  
    for(int i= 1; i< ICode ; i++)
    {
    if(temp == null)
    {
      Console.WriteLine("Temp is Null");
      return;
    }
    temp = temp.next;
  }
     iCheck =temp.Inventery - Inv;
     if(iCheck >=0 )
     {
     temp.Inventery = iCheck;
     }
     else
     {
      Console.WriteLine("Unable to Remove Inventry");
      return;
     }
  }
  
  public void Display1()
  {
      Console.WriteLine("Products  of Clipper are : ");

        Node temp = first;

        while(temp!= null)
        {
           Console.Write("| "+temp.Products+" |-> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
  }

  public void Display()
  {
    int iCount = Count();
    Node temp = first;
   Console.Write("\nItem\t  Item_Code  Inventry  \t Chart \t \n");
   for(iCnt = 0; iCnt < iCount; iCnt++)
   {
    Console.Write(temp.Products+"\t\t"+temp.Item_Code+"\t"+temp.Inventery +"\t ");
     for(int i= 0; i<temp.Inventery; i++)
     {
     Console.Write("*");
     }
     temp = temp.next;  
     Console.WriteLine("");
   }
  }
}

