using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class GameTime
    {
        int gameTime;
        bool gameOver = false;

        public GameTime(int tickIncrement, bool isDead) {
            gameTime += tickIncrement;
            gameOver = isDead;
        }

        public void SetGameTime(bool setORget, int tickIncrement)
        {
            gameTime += tickIncrement;
        }

        public int GetGameTime() 
        {
            return gameTime;
        }

        public void SetAlive(bool isDead)
        {
            gameOver = isDead;
        }

        public bool GetAlive()
        {
            return gameOver;
        }


    }
}
