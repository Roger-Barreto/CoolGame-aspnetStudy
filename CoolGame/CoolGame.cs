using System;
using CoolGame.Interface;

namespace CoolGame
{
    public class CoolGame
    {   
        private readonly iPlayer _playerOne;
        private readonly iPlayer _playerTwo;
        public CoolGame(iPlayer playerOne, iPlayer playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
        }
        public void InitializeGame()
        {
            Console.Write(_playerOne.Run());
            Console.Write(_playerOne.Kick());
            Console.Write(_playerOne.Pass());

            Console.Write("Next player: \n");

            Console.Write(_playerTwo.Run());
            Console.Write(_playerTwo.Pass());
            Console.Write(_playerTwo.Kick());
        }
    }

}