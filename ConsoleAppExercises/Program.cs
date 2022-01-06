using System;

namespace ConsoleAppExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // an array named fred
            int[] Fred = { 1, 2, 3, 4, 5, 56};
            // use a for loop to iterate through the array - this loop iterates 0 through the Length of Fred
            for (int i = 0; i < Fred.Length; i++)
            {
                // this line writes the iteration. Fred is the array of numbers, "i" represents the position
                Console.WriteLine(Fred[i]);
            }
        }
    }
}

//    // global variable = #, or, to start blank, leave it as an empty string
//    var fred = "#";
//    // a continous loop that iterates +1 each time, for a total of 10 times
//    for (int i = 0; i < 3; i++)
//    {
//        //this writes the initial string/variable declared
//        Console.WriteLine(fred);
//        // variable adds # each time
//        fred += "#"; 

//    }

//    // cw 1-100 if divisible by 3 then fizz, if divisible by 5 then buzz

//    for (int i = 0; i < 100; i++)
//    {
//        var result = "";

//        if (i % 3 == 0)
//        {
//            result += "buzz";
//        }
//        if (i % 5 == 0)
//        {
//            result += "fizz";
//        }
//        if (result == "")              
//        {
//            result += i;
//        }

//        Console.WriteLine(result);
//    }
