using System;

namespace StudentService
{
    public class Student
    {
        public string Name;
        public string LastName;
        public long PhoneNumber;
        public int BirthDay;
        public int BirthMonth;
        public int BirthYear;

        private int InputBirthYear()
        {
            Console.Beep();
            var strYear = Console.ReadLine();
            if (strYear != null)
            {
                Convert.ToInt32(strYear);
                int resAge;
                if (int.TryParse(strYear, out resAge))
                {
                    return resAge;
                }
            }
            return 0;
            //اینجا میخوام سن رو از یوزر بگیرم
        }


        public bool SchoolAge()
        {
            Console.WriteLine("Please enter your age?");
            var birthYear = InputBirthYear();
            if (birthYear > 0)
            {
                if (birthYear <= 2017)
                {
                    Console.WriteLine("Able to sign up for school");
                    this.BirthYear = birthYear;
                    return true;
                }
                else
                {
                    
                    Console.WriteLine("Not able to sign up for school");
                }
            }
            else
            {
                // print error
            }
            //بعد اینجا بگم اگه هفت سالشه میتونه بره مدرسه اگه نیست نمیتونه بره


            return false;

        }

    }


}
