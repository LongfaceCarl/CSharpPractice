using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intializing class Method 1
            People leo = new People{studentID = 0, name = "Leo", bornYear = 2001, testScore = 83 };

            //Intializing class Method 2
            People carl = new People();
            carl.studentID = 1;
            carl.name = "Carl";
            carl.bornYear = 2001;
            carl.testScore = 89;

            //Intializing class Method 3
            People harry = new People(2, "Harry", 2000, 97);

            People jackey = new People(2, "Jackey", 2000, 79);

            Console.WriteLine("What is the current year?");
            string userResponse = Console.ReadLine();
            int currentYear = Convert.ToInt16(userResponse);

            //This is equivalent to ...
            //Console.WriteLine(leo.ToString() + " is " + leo.StudentAge(currentYear) + " years old.");
            //Console.WriteLine(carl.ToString() + " is " + carl.StudentAge(currentYear) + " years old.");
            //Console.WriteLine(harry.ToString() + " is " + harry.StudentAge(currentYear) + " years old.");
            //Console.WriteLine(jackey.ToString() + " is " + jackey.StudentAge(currentYear) + " years old.");
            //This...
            People[] students = {leo, carl, harry, jackey};
            float totalScore = 0;
            for(int i = 0; i < students.Length; i ++){
                People student = students[i];
                Console.WriteLine(student.ToString() + " is " + student.StudentAge(currentYear) + " years old.");
                totalScore += student.testScore;
            }

            Console.WriteLine("Mean score = " + totalScore/students.Length);

            Console.WriteLine("Enter to exit");
            Console.ReadLine();
            
        }
    }
    public class People{

        public People(){}
        public int studentID;
        public string name;
        public int bornYear;
        public float testScore;
        public int StudentAge(int currentYear){
            return currentYear - bornYear;
        }
        //Initializing a class, Method 3 specific
        public People(int SID, string Name, int BornYear,float TestScore){
            studentID = SID;
            name = Name;
            bornYear = BornYear;
            testScore = TestScore;
        }
        public override string ToString()//Override, replace the original and write our own version of such function
        {
            return "Student " + studentID + ", " + name + ", last test score " + testScore;
        }
    }
}

