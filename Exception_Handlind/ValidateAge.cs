using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exception_Handlind
{
    public  class ValidateAge
    {
        public static string CheckCategory(int age)
        {
            string category;

            try
            {
                if (age == null)
                {
                    throw new InvalidAgeException("Invalid age entered.");
                }
                else if (age < 1)
                {
                    throw new InvalidAgeException("Age should not be less than 1.");
                }
                else if (age >= 1 && age <= 14)
                {
                    category = "Children";
                }
                else if (age >= 15 && age <= 24)
                {
                    category = "Youth";
                }
                else if (age >= 25 && age <= 64)
                {
                    category = "Adults";
                }
                else if (age >= 65)
                {
                    category = "Seniors";
                }
                else
                {
                    throw new InvalidAgeException("Enter valid age !!!.");
                }
            }
            catch (ArgumentNullException ex)
            {
                category = "Error: " + ex.Message;
            }
            catch (InvalidAgeException ex)
            {
                category = "Error : " +ex.Message;
            }
            return category;
        }
    }
}
