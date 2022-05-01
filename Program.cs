
using System;
using System.Collections.Generic;
using System.Linq;


// Author: Nathan Colburn
// date: 6/4/2019

//about:
// imput customer info 


namespace Assignment_6
{
    class Program
    {
        
        static void Main(string[] args)
        {
           


            List<string> info = new List<string>();
            {
                Console.WriteLine("Enter First Name");
                info.Add(Console.ReadLine());
                Console.Write("Enter Last Name: ");
                info.Add(Console.ReadLine());
                Console.Write("Enter Street: ");
                info.Add(Console.ReadLine());
                Console.Write("Enter City: ");
                info.Add(Console.ReadLine());
                Console.Write("Enter State: ");
                info.Add(Console.ReadLine());
                Console.Write("Enter Zip: ");
                info.Add(Console.ReadLine());

                Console.WriteLine("\n\nCustomer's Information:");


                var result = 
                    from newInfo in info
                    let upperCaseWord = UppercaseWords(newInfo)
                    select upperCaseWord;
              

                foreach (var catagory in result)
                    Console.WriteLine("{0} ", catagory);


                Console.ReadLine();

            }

            
        }

        public static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

    }
}
