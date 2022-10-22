// Jumper specs
// responsibility: store lives and what the jumper looks like
// attributes: lives
// methods: UpdateJumper

namespace unit3_Jumper.Game{
    public class Jumper
    {
        // attributes: life value, visual parachute status
        private int score = 4;
        private string JumperStatusFull = (
@"  ____________
 /            \
|Your Parachute|
| don't pop it!|
 \____________/
   \  |   |  /
    | |   | |
     \|   |/
      o 0 o
       \|/
        |
       / \
        ");
        private string JumperStatusOneGone = (
@"  ____________
 /           /_/
|  1 life lost|
|      /_/    |
 \____________/
   \  |   |  /
    | |     |
     \|    /
      o 0 o
       \|/
        |
       / \
        ");
        private string JumperStatusHalf = (
            @"  ______
 /     /__
| 2/4    _ \___ 
| gone  /_/    |
 \___/  ______/
   \   /  |  /
      |     |
      |    /
      o 0 o
       \|/
        |
       / \
            "
        );
        private string JumperStatusThree = (
            @"  ____/
 /    /
|  1   //\/\///
| left! /_/    |
 \___/  ______/
  \   /  |   /
     |    \ 
     |    
      o 0 o
       \|/
        |
       / \
            "
        );
        private string JumperStatusDead = (
            @"  ____/
 /    /
 \     //\/\///
 /     /_/    |
 \___/  ___/__/
  \    /  |  /
      |   
        
       o  |
   \  /   |
    o /  \   0
    Splat
            "

        );
        public string JumperWon = (
            @"o 0 o
 \|/
  |
 / \
^^^^^"
        );


        // methods: UpdateJumper, MakeJumperDisplay
        private string MakeJumperDisplay(){
            // this method assigns a display from the JumperStatus variables
            // to a score value, to be used in Update Jumper
            string JumperDisplay = "";
            if (score == 4){
                JumperDisplay = JumperStatusFull;
            }
            else if (score == 3){
                JumperDisplay = JumperStatusOneGone;
            }
            else if (score == 2){
                JumperDisplay = JumperStatusHalf;
            }
            else if (score == 1){
                JumperDisplay = JumperStatusThree;
            }
            else if (score == 0){
                JumperDisplay = JumperStatusDead;
            }
            return JumperDisplay;
        }

        public string UpdateJumper(bool Guess){
            // this method takes in whether or not the guess is correct
            // and uses MakeJumperDisplay to return what VideoService should write
            if (Guess == true){
                this.score += 0;
                //MakeJumperDisplay();
            }
            else if (Guess == false){
                this.score -= 1;
                //MakeJumperDisplay();
            }
            return MakeJumperDisplay();
        }
        public bool CheckIfDead(){
            if (score == 0){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
