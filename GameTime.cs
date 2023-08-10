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
    }
}
