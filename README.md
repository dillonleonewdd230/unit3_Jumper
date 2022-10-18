n # unit3_Jumper
    ____
   /____\
   \    /
    \  /
     O
    /|\
    / \
 
 ^^^^^^^^^^
"Getters good! Setters dangerous!" -- Bro. Manley
"Just ask yourself, Why are you doing it?" -- Bro. Manley
"But, someone still dies... that's good" -- Bro. Manley

-solid advice for anything honestly
testify

---------------------------------------------------------------------------------------------------------
Game specs:
The puzzle is a secret word randomly chosen from a list.
The player guesses a letter in the puzzle.
If the guess is correct, the letter is revealed.
If the guess is incorrect, a line is cut on the player's parachute.
If the puzzle is solved the game is over.
If the player has no more parachute the game is over.

The program must also meet the following requirements.

The program must include a README file.
The program must include class and method comments.
The program must have at least four classes.
The program must remain true to game play described in the overview.

Classes:
    -Director: Justin
     -responsibility: 'guide the process of the game', 'calling the other classes in the right order'
     -attributes:
     -methods:
        GetInputs
            take in guess
        DoUpdates
            check if guess is correct
                take off layer of parachute or add letter to word display
            update jumper
        DoOutputs
            display word
            display jumper
            
            

        

    -Word: Nathan
     -responsibility: Generate a random word 
     -attributes: list of possible words?
     -methods:
        selectWord
        isGuessCorrect
        GetRandomWord();
        -tell how many letters within word
        -insert letters from guess

    -jumper: Emma
     -responsibility: 
        keep track of current life of jumper
     -attributes:
        lives
     -methods
        update jumper
        display jumper

    - TerminalService; Andre
     -responsibility: 
     -attributes:
        
     -methods:

    - Word Generator: Dillon
     -responsibility: 
     -attributes:
        
     -methods:
    