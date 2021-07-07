using System;

namespace condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your result: ");
            String Score = Console.ReadLine();
            int ScoreInt = Convert.ToInt32(Score);

            String Result = string.Empty;

            if(ScoreInt>=90 && ScoreInt <= 100)
            {
                Result = "You Earn A+";
            }
            else if(ScoreInt>=80 && ScoreInt < 90)
            {
                Result = "You Earn A";
            }
            else if (ScoreInt >= 70 && ScoreInt < 80)
            {
                Result = "You Earn A-";
            }
            else if (ScoreInt >= 60 && ScoreInt < 70)
            {
                Result = "You Earn B";
            }
            else if (ScoreInt >= 50 && ScoreInt < 60)
            {
                Result = "You Earn B-";
            }
            else if (ScoreInt >= 40 && ScoreInt < 50)
            {
                Result = "You Earn C";
            }

            else
            {
                Result = " You fall in the Exam";
            }


            Console.WriteLine(Result);




        }
    }
}
