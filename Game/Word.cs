using System;
using System.Collections.Generic;
using System.Text;
// Creating the hidden word before the game

  /*  - Word Generator: 
     -responsibility: Generate a random word 
     -attributes: list of possible words?
     -methods:
        selectWord
        GetRandomWord();
        -tell how many letters within word
        splitword */
namespace unit3_Jumper.Game{
    public class Word{
        
        Random rand = new Random();

    //incorporate the word from a list
    //take the word and break it down
    //output the word
        //attributes-
        // char list

        //private List<char> secretword = WordGenerator.whatevs;
        private int NumChar = 0;
        private string[] words = {"Volvo", "BMW"};
        private string hiddenWord = "";
        private string shownWord = "_";

        private char[] splitword = {' ',' '};
    // Methods
        //Get word from list
        public void genRandomWord()
            {
            hiddenWord = words[rand.Next(0, words.Length)]; 
            shownWord = new string('_', hiddenWord.Length);
            // numChar = len(hiddenword)
            }

        // Split list & save
        
        private void SplitList(int numChar,string word){
            // List<List<char>> Guesses = {CurrentGuess};
            splitword = new char[numChar];
                
            for (int i = numChar; i > 0;i--)
                {
                    //split list to create hidden word is being split here
                char[] chars = word.ToCharArray();


                }

            //char[] englishWords = hiddenWord.ToCharArray();
            // char[] englishWords = hiddenword-ToCharArray();
        }

        public string GetShownWord()
            {
            return shownWord;
            }

        public void UpdateShownWord(char guess)
            {
            
            StringBuilder sb = new StringBuilder(shownWord);
            for (int i = 0; i < hiddenWord.Length; i++)
                {
                if (hiddenWord[i] == guess)
                    {
                    sb[i] = guess;
                    }

                }
            shownWord = sb.ToString();
            }

        // create shown word list

        // update shown word 

        // return shown word
                
    }
};
    