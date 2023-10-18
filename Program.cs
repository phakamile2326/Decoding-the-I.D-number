using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Decoding__the_I.D_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID Number");
            string ID = Console.ReadLine();
           
          

            Console.WriteLine("the DateOfBirth : "+ ID.Substring(0,6));
            Console.ReadLine();

            int gender = Convert.ToInt32(ID.Substring(6,1));
            if (gender <=4) 
            {
                Console.WriteLine("Gender: " + "Female");
            }
            else if (gender <=9) 
            {
                Console.WriteLine("Gender: " + "Male");
            }
            Console.ReadLine();

            int citizenship= Convert.ToInt32(ID.Substring(10,1));
            if (citizenship == 0)
            {
                Console.WriteLine("CitizenshipStatus:" + "South African Citizen");
            }
            else if (citizenship == 1)
            {
                Console.WriteLine("citizenshipStatus:" + "Permanent Resident");
            }
            Console.ReadLine();

            bool isValid = ValidateID(ID);
            Console.WriteLine("Is the ID number valid? : " + isValid );
            Console.ReadLine();
        }
        public static bool ValidateID(string ID)
        {
            int sum = 0;
            bool doubleDigit = false;

            for (int i = ID.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(ID[i].ToString());

                if (doubleDigit)
                {
                    digit *= 2;
                    if (digit>9)
                        digit -= 9;
                }
                sum += digit;
                doubleDigit = !doubleDigit;

            }
            return (sum %10 == 0);
            
            
                
           
        }
    }
}
