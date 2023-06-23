using System;
using System.Runtime.CompilerServices;

namespace _04._Password_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (IsValid(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (IsBetweenSixAndTenChars(password) == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (IsOnlyLettersAndDigits(password) == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (HasAtLeastTwoDigits(password) == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static bool IsValid(string password)
        {
            if (IsBetweenSixAndTenChars(password) && IsOnlyLettersAndDigits(password) && HasAtLeastTwoDigits(password))
            {
                return true;
            }
            return false;
        }

        static bool HasAtLeastTwoDigits(string password)
        {

            char[] array = password.ToCharArray();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] >= 48 && array[i] <= 57)
                {
                    count++;
                }

                if (count == 2)
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsOnlyLettersAndDigits(string password)
        {
            
            char[] array = password.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {

                if (!(array[i] >= 48 && array[i] <= 57) && !(array[i] >= 65 && array[i] <= 90) && !(array[i] >= 97 &&
                    array[i] <= 122))
                {
                    return false;
                }
            }

            return true;

        }

        static bool IsBetweenSixAndTenChars(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }
    }
}