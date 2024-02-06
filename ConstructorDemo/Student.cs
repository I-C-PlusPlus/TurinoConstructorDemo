using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Student
    {

        //-------------------------------------
        //Constructors
        //-------------------------------------
        //default constructor
        public Student():this("Number Pending")
        {         
        }
        public Student(string sId):this (sId,"TBD","TBD")
        {
           
        }
        public Student(string sId, string firstName, string lastName):this(sId,firstName, lastName, -1, -1, -1, "undeclared")
        {
        }
 

            public Student(string sId, string firstname, string lastName, int s1, int s2, int s3, string maj)
        {
            StudentNumber= sId;
            FirstName = firstname; 
            LastName = lastName;            
            Score1 = s1;
            Score2 = s2;
            Score3 = s3;
            Major = maj;
            CalcAverage();
        }
        //-------------------------------------
        //Properties
        //-------------------------------------
        public string Major { get; set; }

        private int score1;

        public int Score1
        {
            get { return score1; }
            set { score1 = value; CalcAverage(); }
        }
        private int score2;

        public int Score2
        {
            get { return score2; }
            set { score2 = value; CalcAverage(); }
        }

        private int score3;

        public int Score3
        {
            get { return score3; }
            set { score3 = value; CalcAverage(); }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public double Average { get; private set; }

        //-------------------------------------
        //Instance Methods
        //------------------------------------
        public void CalcAverage()
        {
            Average = (score1 + score2 + score3) / 3.0;
        }
        //---------------------------
        //Destructor
        //---------------------------
       ~ Student()
        {
            Console.WriteLine($"The student  {StudentNumber} {FirstName} {LastName} has been removed from the system. ");
        }

      /*  protector overide void Finalize()
        {
         //   Console.WriteLine...
        }*/
    }
}
