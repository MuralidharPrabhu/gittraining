using System;
using System.Collections.Generic;
using System.Text;

namespace Practical
{
    class PersonDetails
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Enter Person details ");
            Console.Write("Enter First name : ");
            string first = Console.ReadLine();
            Console.Write("Enter Last name : ");
            string last = Console.ReadLine();
            Console.Write("Enter Email address : ");
            string email = Console.ReadLine();
            Console.Write("Enter Date of birth : ");
            string dob = Console.ReadLine();
            DateTime dateofbirth = DateTime.Parse(dob);
            person p = new person(first, last, email, dateofbirth);
            Console.WriteLine(p.ToString());
            try
            {
                person p1 = new person("\nJOE", "BIDEN", "jb@g.com", new DateTime(1967, 02, 09));
                Console.WriteLine(p1.ToString());

                person p2 = new person("\nDonald", "Trump", new DateTime(1962, 04, 02));
                Console.WriteLine(p2.ToString());

                person p3= new person("\nBarack", "Obama", "bo@g.com");
                Console.WriteLine(p3.ToString());

                person p4 = new person("\nGeorge", "Bush", "gb@g.com", new DateTime(1721, 01, 03));
                Console.WriteLine(p4.ToString());
            }
            catch (InvalidEmailAddressException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FutureDateOfBirthException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DateOfBirthTooFarInPastException ex2)
            {
                Console.WriteLine(ex2.Message);
            } 
        }
    }
 }



