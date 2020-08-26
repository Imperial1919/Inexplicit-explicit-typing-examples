using System;

namespace Inexplicit_explicit_typing_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new string[] { "John", "Paul", "George", "Ringo" };
            

            foreach (var beatle in studentNames)
            {
                Console.WriteLine($"Student id: \n {beatle}");
            }

            for (decimal decade = -500; decade < 2020; decade += 1)
            {

                if( decade > 0)
                {
                    Console.WriteLine($"Year :{decade}AD");
                }

                else
                {

                 
                    
                        Console.WriteLine($"year :{decade}BC");
                    }
                }

                    
            }
        }
    }


