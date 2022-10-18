using System;
using System.Collections.Generic;
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

    private List<char> secretword = WordGenerator.whatevs;
    private int NumChar = 0;
    private string[] words = {"Volvo", "BMW"};
    private string hiddenWord = "-";
  

// Methods
    //Get word from list
    private void genRandomWord(string [] words){
       hiddenWord = words[rand.Next(0, words.Length)]; 
       // numChar = len(hiddenword)

    }
    // Split list & save
    
    private void SplitList(){
            List<List<char>> Guesses = {CurrentGuess}
    
            
            for (int i = numChar; i > 0;i--)
            {

            }
    }

    // Guess a
            
    }
}










    
}
    