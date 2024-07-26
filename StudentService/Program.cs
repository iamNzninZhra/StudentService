using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stdService = new Student();
            stdService.Name = "NazaninZahra";
            stdService.LastName = "Shahsavan";
            stdService.PhoneNumber = 09391381755;
            stdService.BirthDay = 04;
            stdService.BirthMonth = 12;
            //stdService.BirthYear = Console.ReadLine("Please Enter your year of birth");


            Console.WriteLine($"Full Name : {stdService.Name} {stdService.LastName}");
            //Console.writeline("lastname :" + stdservice.lastname);
            Console.WriteLine("Phonenumber :" + stdService.PhoneNumber);
            Console.WriteLine($"Birthday : {stdService.BirthDay}/{stdService.BirthMonth}/{stdService.BirthYear}");

            stdService.SchoolAge();

            Console.ReadLine();
        }
    }
}