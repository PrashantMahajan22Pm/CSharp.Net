using System;

 class GetRandom
 {
    static void Main(string [] Arg)
   {  
    Search sObjS = new Search();

    sObjS.UserASk();
    int iNum = Convert.ToInt32(Console.ReadLine());

    while(true)
   {
    if(iNum > 1 || iNum < 0)
    {
     Console.WriteLine(" OPPS , Wrong Entry \n => please enter you choice again");
    }
    else if( iNum == 0)
    {
     Console.WriteLine(" Thank you for playing *'Imagine_Gessing_game'* ");
       break;
     }
    else if(iNum == 1)
    {
    sObjS.Match();
      }

    Console.WriteLine(" \n ");
    sObjS.UserASk();
    iNum =Convert.ToInt32(Console.ReadLine());
      }
    }
  }

  class Search
   {
   private int iNo;

   public void Match()
   {
    
     Random rnd = new Random();
     int iRand = (rnd.Next()) %100;
     int iClick = 0;
     int iGessCount = 0;
     Console.WriteLine(" Gess the number ");
     while(true)
     {
       iClick = Convert.ToInt32(Console.ReadLine());
       iGessCount++;
       if(iRand == iClick)
       {
      Console.WriteLine(" \n*** Congratulation your choice is great ***");
      Console.WriteLine("\n you take "+iGessCount+ " times for gessing write number");
       break;
       }
       else if(iRand > iClick)
       {
     Console.WriteLine(" you have to Enter the Big number");
       }
       else if(iRand < iClick)
       {
     Console.WriteLine(" you have to Enter the Small number");
       }
     }
    
   }

   public void UserASk()
   {
    Console.WriteLine(" press '0' for Exit ");
    Console.WriteLine(" press '1' for start New Game ");
   }

 }

