//DATA TYPES
//A data type specifies the size and type of variable values.
/*
Data Type |	 Size
int 	    4 bytes
long 	    8 bytes
float 	    4 bytes
double 	    8 bytes
bool 	    1 bit
char 	    2 bytes
string 	    2 bytes per character
*/

//Scientific Numbers
/*
A floating point number can also be a scientific number with an "e" to indicate the power of 10:
*/

using System;
namespace Name
{
    class Program
    {
        static void Main(string() args){
            //Int
            int numb = 10000;
            Console.WriteLine(numb);

            //Long (Note:should end the value with an "L")
            long myNum = 15000000000L;
            Console.WriteLine(myNum);

            //float (end the value with an "F") 
            float myFlo = 5.75F;
            Console.WriteLine(myFlo);

            //Double (end the value with a "D")
            double myDob = 19.99D;
            Console.WriteLine(myDob);

            //Scientific Numbers
            float f1 = 35e3F;
            double d1 = 12E4D;

            Console.WriteLine(f1);
            Console.WriteLine(d1);


        } 
    }
}