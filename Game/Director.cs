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
      
   // Run Game: controls the gameplay loop.
   private void RunGame()
   {


      while (!GameOver)
      {
         Guess = GetInputs();
         DoUpdates();
         DoOutputs();
      }
   }

   // Get Input: take a guess
   private char GetInputs()
   {
      private char Guess = videoservice.ReadText("Guess a letter [a...z]: ");  
      return Guess;
   }
   
   //DoUpdates
   private void DoUpdates()
   {
      
   }
   
   private void DoOutputs()
   {
      videoservice.
   }   
}