using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassProject {
    class Student {

        public string Firstname { get; set; }  //get  read data       set change data
        public string Lastname { get; set; }
        //every single SS is going to have a first name, and a last name
        public string Email { get; set; }
        public string Phone { get; set; }   
        public int FinalGrade { get; set; }
        //SHORTCUT:  type "prop" and tab twice, to get template

        // public = access modifier.  what access do you allow?.   "public", "private" "internal (default.)"
        // from inside the Student class, all things in class can be accessed.  But what can OTHER classes access?

        //public:  ANY other class can have access to this property
        //private:  NO other class can access this.  ONLY in the class it's defined in
        //internal: Can be accessed by any class in same project as this one.


        //METHODS
        public string GetFullname() {        //parenths empty.  Don't need to pass anything in       // will return a string
            return Firstname + " " + Lastname;
        }
        public void SetFinalGrade(int finalGrade) {            // void:  It doesn't return anything.  Like a null.  a value that means it has no value
            if (finalGrade < 0) {    // check for bad input
                Console.WriteLine("ERROR:  Grade must be greater than zero");
                return; // so we never get to the part below where the final grade gets changed.
            }
            FinalGrade = finalGrade;    // the property starts with a capital F
                                        // these are two different variables!  "The FfinalGrade [don't know which!!] property is set to that value"
                                        // OR, could NOT write return, but instead put FinalGrade = finalGrade inside an else clause
        }
    }
}
