using unit3_Jumper.Game;

namespace unit3_Jumper
{
    /// <summary>
    /// Starts the game by calling director
    /// </summary>
    class Program
    {

        static void Main(string[] args)
            {
            Director director = new Director();
            director.RunGame();
            }
    }

    

}




/// static void Main(string[] args)
      //  {
            ///Director director = new Director();
            ///director.StartGame();
      //  }