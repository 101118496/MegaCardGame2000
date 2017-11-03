using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Card_Game_2000
{
    class PlayerCharacter : Player
    {
        private char characterName { get; set; }
        private NormalAttack normalAttack { get; set; }
        private SpecialAttack specialAttack { get; set; }
    }
}
