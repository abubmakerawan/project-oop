using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TYPES_AND_VARIBLES.CS_OOP_407
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  DATA TYPES+VARIBLES, THEIR PROBLEMS AND SOLUTION
            //1 PROBLEM :-  SHOW   STUDENT NAME ,AGE AND ID CARD NO , GENDER
            // SOLUTION:-
            string studentName = "John WICK";       //
            int studentAge = 18;
            long studentIdCardNo = 00000000000;
            string gender = "male";
            Console.WriteLine(studentName);          // 
            Console.WriteLine(studentAge);
            Console.WriteLine(studentIdCardNo);
            Console.WriteLine(gender);
            // 2PROBLEM :-  car details
            // SOLUTION:-
            string brandname = "nissan";
            string series = "siliva s15  spec-5";
            int make = 2001;
            string modifiedengine = "twin turbo skyline rb26dett";
            string title = "MONA LISA";
            Console.WriteLine(brandname);
            Console.WriteLine(series);
            Console.WriteLine(make);   
            Console.WriteLine(modifiedengine);
            Console.WriteLine(title);
            // PROBLEM 3:-  FINDING THE AREA OF CIRCLE
            // SOLUTION:-
            double radius = 13.5; ;        // also float vatible can be used
            double pi = 3.14;
            double areaofcircle = pi * radius * radius;                // formula=pir^2
            Console.WriteLine("AREA OF CICRLE IS:" + areaofcircle)






























            ;


















        }
    }
}
