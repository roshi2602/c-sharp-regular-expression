using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regular_expression
{
    //it is used to check wheter the given input is matching given pattern or not
    //REGEX()- this constructor initializes new instance of regex class
    //import using System.Text.RegularExpressions;
    //this is used in form validation

    //quantifier
    /*   ? - it matches 0 or 1  */
    // index()
    //length()
  //value()
  // ToString()



    //matches-
    //\d =used to match digit character (digit)
    // \D = for non digit
    // \w = is word character , used to match alphaneumeric, underscore, letters  (for words)
    // \n =used to match new line
    //^ = Word after this element matches at the beginning of the string or line
    // $ =Word before this element matches at the end of the line or string.
// [] =used to match range of characters
// \ =used to match escaped special chaarcter
//  ()= used to match group expression
//  . = any character
//  [a-z]= a to z (lowercase)
// 0-9 = numbers
// * = o or more repetations 
//  ? = optional character
//  \s = any whitespace


//methods
//IsMatch(string) = this finds whether the regular expression matches string
//Match(string) = this finds input string for regular expression
//Split(string) = this splits string into array of substrings
//ToString() = this returns regular expression pattern that was passedin Regex()
//Replace() = is used to replace text that matches with expression
    class Program
    {
        static void Main()
        {

            string email = "roshi26@gmail.com";
            var res = Regex.IsMatch(email, @"^\w+@\w+$"); 
            Console.WriteLine(res);     //output = false

            //----------------------------
            string sr = "hi welcome";
            var rese = Regex.IsMatch(sr, @"\w+"); //output = true
            Console.WriteLine(rese);



            Console.ReadLine();
        }
    }
}
