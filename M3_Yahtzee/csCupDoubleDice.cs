using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Yahtzee
{
    class csCupDoubleDice : csCupOfDice, ICupDoubleDice
    {
        public bool IsPair => _dices[0] == _dices[1];

        public csCupDoubleDice():base(2)
        {

        }
    }

}
