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
      private bool GameOver = false;
      private char Guess = 'n';
      private bool GuessCorrect = false;
      private string NewShownWord = "";
      private string OldShownWord = "";
      private string CurrentJumper = "";

   // Run Game: controls the gameplay loop.
   public void RunGame()
   {
      // Generates the random word to be guessed.
      word.genRandomWord();
      // Gets the blank word to compare the first guess to.
      OldShownWord = word.GetShownWord();
      videoservice.WriteText(OldShownWord);
      string HiddenWord = word.GetHiddenWord();
      // Runs the game 
      while (!GameOver)
      {
         GetInputs();
         DoUpdates(HiddenWord);
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
   private void DoUpdates(string HiddenWord)
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
      GameOver = jumper.CheckIfDead();
      if( HiddenWord == NewShownWord)
      {
         CurrentJumper = jumper.JumperWon;
      }
      if (CurrentJumper == jumper.JumperWon) 
      {
         GameOver = true;
      }
   }

   // Do Outputs: displays results of the turn to the terminal.
   private void DoOutputs()
   {
      videoservice.WriteText(NewShownWord);
      videoservice.WriteText(CurrentJumper);
   }   
}