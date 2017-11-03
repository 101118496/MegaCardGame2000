using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega_Card_Game_2000.Characters;
using Mega_Card_Game_2000.Attacks;

namespace Mega_Card_Game_2000
{
    class GameController
    {
        private PlayerCharacter player { get; set; }
        private NonPlayerCharacter enemy { get; set; }

        public char ChooseClass()
        {
            //The player will choose
            //their character to play as.
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            //Battle commences.
        }

        public void FinishGame()
        {
            //Ends the battle and
            //displays the winner.
        }
    }
}
