using System;  // This is needed to use Console functions like WriteLine and ReadLine

namespace vsCodeDotnet
{
    class Program
    {
        /// <summary>
        /// This is the main method that runs when the program starts. It asks the user for a string,
        /// converts it to uppercase, counts how many times each character appears, and finds the 
        /// most common character.
        /// </summary>
                static void Main(string[] args)
        {
            // Ask the user to type a string
            
            Console.WriteLine("Enter a string: ");  // Ask user
            
            // input from the user and store it in a variable called 'input'
          string input = Console.ReadLine();  // This takes what the user typed and saves it in 'input'
            
            // Turn the string into a character array 
           
            char[] inputChars = input.ToCharArray();  // This splits the string into individual characters
            
            // Loop through each character and make it uppercase if it's a lowercase letter
           
            for (int i = 0; i < inputChars.Length; i++)  // This loop goes through each character in the array
            {
                // Check if the character is between 'a' and 'z' (lowercase letters)
                if (inputChars[i] >= 'a' && inputChars[i] <= 'z')
                {
                    // Convert the lowercase letter to uppercase by subtracting 32 from its ASCII value
                              inputChars[i] = (char)(inputChars[i] - 32);  // Changes the letter to uppercase
                }
            }

            // Convert the character array back into a string
         input = new string(inputChars);  // This turns the modifiyed characters back into a string

            // Create an array to keep track of how many times each character appears
                 int[] counts = new int[128];  // This array will count how many times each character shows up
            
            //Loop through each character in the string and count them
            for (int i = 0; i < input.Length; i++)  // This loop goes through the entire string
            {
                
                     char c = input[i];  // Get the current character
                counts[c]++;  // Add 1 to the count of this character, Incrementing. 
            }

            // Step 8: Find the character that appears the most
            int mostCount = -1;  // This will stor the highest number of times a character shows up
            char mostChar = ' ';  // This will store the character that appears the most

            // Go through the counts array to find which character appeared the most
            for (int i = 0; i < 128; i++)  // There are 128 possible characters
            {
                if (counts[i] > mostCount)  // If this character appears more than the previous most common one
                {
                    mostCount = counts[i];  // Update the most common count
                    mostChar = (char)i;  // Save the character that had the highest count
                }
            }

            // Print out the most common character and how many times it appeared
            Console.WriteLine("The most common character is: " + mostChar + " with " + mostCount + " occurrences.");
        }
    }
}
