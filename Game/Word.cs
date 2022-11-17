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
    private string[] words = {"volvo", "honda"};
    private string hiddenWord = "";
    private string shownWord = "_";
    private char[] splitword = {'_','_'};
    
// Methods
    //Get word from list
    // and create shown word
    public void genRandomWord()
        {
        hiddenWord = words[rand.Next(0, words.Length)]; 
        shownWord = new string('_', hiddenWord.Length);
        }
    // Split list & save
    
    private char[] SplitList(int numChar,string word)
        {
          char[] englishWords = word.ToCharArray();
          return englishWords;
          // char[] englishWords = hiddenword-ToCharArray();
        }
    public string GetHiddenWord()
        {
            return hiddenWord;
        }

    public string GetShownWord()
        {
        // return shown word
            return shownWord;
        }

    public void UpdateShownWord(char guess)
        {
        // update shown word 
            
        StringBuilder sb = new StringBuilder(shownWord);
        char[] hidden = SplitList(NumChar,hiddenWord);

            for (int i = 0; i < hidden.Length; i++)
            
            {
                if (hidden[i] == guess)
                {
                    sb[i] = guess;
                }

            }
            shownWord = sb.ToString();
        }      
    }
};
