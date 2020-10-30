using CoolGame.Interface;

namespace CoolGame.Lib
{
    public class playerOne : iPlayer
    {
        public string _Name { get; set; }

        public playerOne(string name)
        {
            _Name = name;
        }

        public string Run()
        {
            return $"{_Name} is running \n";
        }

        public string Kick()
        {
            return $"{_Name} is kicking \n";
        }

        public string Pass()
        {
            return $"{_Name} is passing \n";
        }
    }
}