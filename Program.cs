using System;

namespace vsCodeDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask the user for a string
            Console.WriteLine("Enter a string: ");  
            string input = Console.ReadLine();  
            
            // Convert string to a character array since strings are immutable
            char[] inputChars = input.ToCharArray(); 

            // 2. Convert all characters to uppercase
            for (int i = 0; i < inputChars.Length; i++)  
            {
                if (inputChars[i] >= 'a' && inputChars[i] <= 'z')
                {
                    inputChars[i] = (char)(inputChars[i] - 32);  // Convert to uppercase
                }
            }

            // Convert the char array back to a string
            input = new string(inputChars);

            // Create an array to store counts of each ASCII character
            int[] counts = new int[128];  

            // 3. Loop through each character in the input
            for (int i = 0; i < input.Length; i++)  
            {
                char c = input[i];  
                counts[c]++;  
            }

            // 4. Find the character that appears the most times
            int mostCount = -1;  
            char mostChar = ' '; 

            for (int i = 0; i < 128; i++)  
            {
                if (counts[i] > mostCount)  
                {
                    mostCount = counts[i];  
                    mostChar = (char)i;  
                }
            }

            // 5. Print the result
            Console.WriteLine("The most common character is: " + mostChar + " with " + mostCount + " occurrences.");
        }
    }
}
