using CoolGame.Lib;

namespace CoolGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new CoolGame(new playerOne("Jhon"), new playerTwo());
            game.InitializeGame();
        }
    }
}