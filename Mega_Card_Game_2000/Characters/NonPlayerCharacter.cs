using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Card_Game_2000
{
    class NonPlayerCharacter : Player
    {
        private char EnemyType { get; set; }
        private NormalAttack attack { get; set; }
    }
}
