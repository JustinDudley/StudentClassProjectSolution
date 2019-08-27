using System;

namespace StudentClassProject {
    class Program {
        static void Main(string[] args) {

            var Lidya = new Student();  //first, identify which Student you're working with. (Lidya.Firstname is diff from Justin.Firstname -- I think that's the point).
            Lidya.Firstname = "Lidya";
            Lidya.Lastname = "Tsegay";
            Lidya.SetFinalGrade(98);
            var fullname = Lidya.GetFullname();
            Console.WriteLine("Lidya's full name is " + fullname);
            // when a method returns something, you can can put that on the right  side of equal


            var Justin = new Student();
            Justin.Firstname = "Justin";
            Justin.Lastname = "Dudley";
            Justin.SetFinalGrade(99);
            fullname = Justin.GetFullname();
            Console.WriteLine($"{fullname}"); //This is a better way to concatenate. This string is going to do something called interpolation . The $ says:  Interpolation coming. "Don't put the name, put the VALUE"
            // -because concatenation of a lot of little strings is very error-prone.  Bad.  This is a better way
            //Console.WriteLine($"")

            var Nick = new Student();
            Nick.Firstname = "Nick";
            Nick.Lastname = "Baker";
            Nick.SetFinalGrade(-100);
            Console.WriteLine($"{Nick.Firstname} {Nick.Lastname}");

        }
    }
}
