using System;
using System.Collections.Generic;
using unit3_Jumper.Game;
/// Director class
/// Responsibility: Guide the process of the game, and call the other claases in the right order.
/// Methods: 
/// RunGame: Generate a random word and start the gameplay loop.
/// GetInputs: Receives inputs from the user
/// DoUpdates: Processes input and determines results
/// DoOutputs: Displays results to the user.

public class Director
{
      private Word word = new Word();
      private VideoService videoservice = new VideoService();
      private Jumper jumper = new Jumper();
      public bool GameOver = false;
      public char Guess = 'n';
      public bool GuessCorrect = false;
      public string NewShownWord = "";
      public string OldShownWord = "";
      public string CurrentJumper = "";

   // Run Game: controls the gameplay loop.
   private void RunGame()
   {
      // Generates the random word to be guessed.
      word.genRandomWord();
      // Gets the blank word to compare the first guess to.
      OldShownWord = word.GetShownWord();

      // Runs the game 
      while (!GameOver)
      {
         GetInputs();
         DoUpdates();
         DoOutputs();
      }
   }

   // Get Input: take a guess
   private void GetInputs()
   {
      Guess = videoservice.ReadText("\n\n\nGuess a letter [a...z]: ");  
   }
   
   //Do Updates: Determines the results after the user takes a guess,
   //and updates the shown word and jumper actor.
   private void DoUpdates()
   {
      word.UpdateShownWord(Guess);
      NewShownWord = word.GetShownWord();
      if (NewShownWord == OldShownWord)
      {
         GuessCorrect = false;
      }
      else
      {
         GuessCorrect = true;
      }
      OldShownWord = NewShownWord;
      CurrentJumper = jumper.UpdateJumper(GuessCorrect);

   }
   
   // Do Outputs: displays results of the turn to the terminal.
   private void DoOutputs()
   {
      videoservice.WriteText(word.GetShownWord());
      videoservice.WriteText(CurrentJumper);
   }   
}