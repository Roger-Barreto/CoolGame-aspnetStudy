using CoolGame.Interface;

namespace CoolGame.Lib
{
    public class playerTwo : iPlayer
    {
        public string Kick()
        {
            return " Alex is Kicking \n";
        }

        public string Pass()
        {
            return " Alex is Passing \n";
        }

        public string Run()
        {
            return " Alex is Running \n";
        }
    }
}