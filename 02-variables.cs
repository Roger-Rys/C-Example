//VARIABLES
    /*
    int - store integers
    double - store floating point numbers
    char - store simple character
    string - store text
    bool - store two states: true or false 


    Syntax
    type variableName = value;
    */
//CONSTANTS
    /*you can add the "const" keyword if you don't want others (or yourself) to overwrite existing values*/

//CONCAT
    //To combine both text and a variable, use the + character:

//Declare Many Variables
    /*use a comma-separated list:
        int x = 5, y = 6, z = 50;
    */

//IDENTFIERS
/*Recall: All C# variables must be identified with unique names.
Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).*/

using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args){
            //String
            string name = "Robert";
            Console.WriteLine(name);

            //char
            string letter = "a";
            Console.WriteLine(letter);

            //Number
            int number = 34;
            Console.WriteLine(number);

            //Double
            double decim = 10.23;
            Console.WriteLine(decim);

            //Bool
            bool state = true;
            Console.WriteLine(state);

            //constant
            const double PI=3.1415;
            Console.WriteLine(PI);

            //Concat
            Console.WriteLine("Hello "+name);
            Console.Write("Sum: "+number+"+"+decim +"=");
            Console.WriteLine(number + decim);

            //Declare many variables 
            int x=6, y=10, z=2;
            Console.Write("multi-sum:");
            Console.WriteLine(x+y+z);
        }
    }
}


