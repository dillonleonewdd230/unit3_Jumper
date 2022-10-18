using System;
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

   // Run Game: controls the gameplay loop.
   private void RunGame()
   {


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
      Guess = videoservice.ReadText("Guess a letter [a...z]: ");  
   }
   
   //DoUpdates
   private void DoUpdates()
   {
      word.UpdateWord();
      jumper.UpdateJumper();
   }
   
   private void DoOutputs()
   {
      videoservice.WriteText(word.ShownWord());
      videoservice.WriteText(jumper.Jumper())
   }   
}