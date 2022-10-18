using System;

namespace unit3_Jumper.Game
{
    /// <summary>
    /// <para>A service that handles terminal operations.</para>
    /// <para>
    /// The responsibility of a VideoService is to provide input and output operations for the 
    /// terminal.
    /// </para>
    /// </summary>
    public class VideoService
    {
        /// <summary>
        /// Create an instance of VideoService
        /// </summary>
        public VideoService()
        {
        }

        /// <summary>
        /// Display the given text on the terminal
        /// <param name="prompt"> The given text </param>
        /// </summary> 
        public string WriteText (string prompt)
        {
            return Console.WriteLine(prompt);
        }

        /// <summary>
        /// Get input from the terminal. Directs the user with the given prompt.
        /// </summary>
        /// <param name="prompt"> The given prompt </param>
        public char ReadText(string prompt)
        {
            Console.WriteLine(prompt);
            string UserInput = Console.ReadLine();
            PlayerGuess = char.Parse(UserInput);

        }

    }
}