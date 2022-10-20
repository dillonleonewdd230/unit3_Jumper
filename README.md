# Jumper
Welcome to Jumper! This is a game in which the player seeks to solve a puzzle by guessing the letters of a secret word one at a time. Think Hangman, but high-altitude.
  ____________               
 /            \         
|              |               
|              |                       
 \____________/                           
   \  |   |  /                          
    | |   | |                           
     \|   |/                             
      o 0 o                              
       \|/                               
        |                                    
       / \                                    
 
 ^^^^^^^^^^

--------------------
# Getting Started:
--------------------
Make sure you have dotnet 6.0 or newer installed on your machine. Open a terminal and browse to the project's root folder. Start the program by running the following commands:

dotnet build
dotnet run

----------------------------
# Project Structure
----------------------------
The project files and folders are organized as follows:
root
+-- Director           (runs the game)
+-- Jumper             (class to create the Jumper and keep track of lives)
+-- Word               (class to keep track of the word and what the player has guessed)
+-- VideoService       (class to reduce lines of code in Director and improve visibility)
+-- Program            (program entry point)
+-- README.md          (general info)
+-- Game.unit3_Jumper  (dotnet project)

----------------------------
# Authors
----------------------------
* Dillon Leone
* Andre Regino
* Emma Quackenbush
* Nathan Marble
* Justin Paystrup
* Madison Brown