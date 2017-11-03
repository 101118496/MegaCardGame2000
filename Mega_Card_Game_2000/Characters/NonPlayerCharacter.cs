using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega_Card_Game_2000.Attacks;

namespace Mega_Card_Game_2000.Characters
{
    class NonPlayerCharacter : Player
    {
        private char EnemyType { get; set; }
        private NormalAttack attack { get; set; }
    }
}
