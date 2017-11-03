using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Card_Game_2000
{
    class GameController
    {
        private PlayerCharacter player { get; set; }
        private NonPlayerCharacter enemy { get; set; }

        public char ChooseClass(char CharacterClass)
        {
            //The player will choose
            //their character to play as.
            if(CharacterClass = "w")
            { 
            PlayerCharacter player = new Warrior();
            }
            elseif (CharacterClass = "m")
            {
            PlayerCharacter player = new Mage();
            } elseif (CharacterClass = "t") {
                PlayerCharacter player = new Thief();
            }
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
