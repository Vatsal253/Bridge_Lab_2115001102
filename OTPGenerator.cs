using System;
using System.Collections.Generic;
namespace OTPGenerator
{
    class Program
    {
        static void Main()
        {
            int[] otps = new int[10];
            for (int i = 0; i < 10; i++)
            {
                otps[i] = GenerateOTP();
            }

            // Display the generated OTPs
            Console.WriteLine("Generated OTPs:");
            foreach (int otp in otps)
            {
                Console.WriteLine(otp);
            }

            // Check if the OTPs are unique
            bool areUnique = AreOTPsUnique(otps);
            Console.WriteLine("Are all OTPs unique? " + areUnique);
        }

        static int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 1000000); // Generate a 6-digit OTP
        }

        static bool AreOTPsUnique(int[] otps)
        {
            HashSet<int> uniqueOTPs = new HashSet<int>(otps);
            return uniqueOTPs.Count == otps.Length;
        }
    }
}
