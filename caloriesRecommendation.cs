
/*
 *  A sign of the times is that people are concerned about ther amount of fat 
 *  they consume. Many health experts recommend that people get no more that 20 %
 *  of their colories from fat . Write a program that recommends the number of 
 *  calories and maximum grams of fat a person should eat each day . base your
 *  Recommendation on the  person's weight and weather the person is active or 
 *  sedentary during the day . if the person is  sedentary , that  person's
 *  activity factor is 13 . if the person is active , that persons activity factor is 
 *  13 . if the person is active , that person's weight to get the recommended number of 
 *  calories . the maximum fat is 20% of the recommended calories.
 * 
 * 
 */


using System;
class caloriesRecommendation {
    static void Main(string [] Arg)
   {
  Console.WriteLine("Enter the weight ");
  int iWeight = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the Choice (1 for active Person and 2 for Sedentary  person) ");
  int iChoice = Convert.ToInt32(Console.ReadLine());
  fatRecommendation frobj = new fatRecommendation();
 int iRet = frobj.Calories(iWeight,iChoice);
  Console.WriteLine(" Recommended Calaries are "+iRet +" grams");
  Console.WriteLine(" Fat is "+frobj.Fat(iRet));
   } 
}

class fatRecommendation
{
  public int Calories(int iWeight , int iCho )
  { 
    int iCal = 0;
     if(iCho == 1)  // Active person
     {
      iCal = iWeight * 15 ;
     }
     else
     {
       iCal = iWeight * 13 ; 
     }
   return iCal;
  }

  public double Fat(int iCal)
  { 
    double ifat = 0.0;
    ifat = 0.2 * iCal;
    return ifat;
  }
}
