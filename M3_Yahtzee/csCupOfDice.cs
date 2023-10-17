using System;
using System.Collections.Generic;
using Helpers;

namespace M3_Yahtzee
{
    //Sprint 2
    /// <summary>
    /// Cup with 1 to 10 dice
    /// </summary>

    
    class csCupOfDice : ICupOfDice
    {
        csSeedGenerator _rnd = new csSeedGenerator();
        protected List<enDiceFace> _dices = new List<enDiceFace>();

        public int Count => _dices.Count;

        public bool CountFace(enDiceFace df, out int count)
        {
            count = 0;
            foreach (var item in _dices)
            {
                if (item == df)
                {
                    count++;
                }
            }
            if (count == 0)
                return false;
            else
                return true;
        }

        public enDiceFace Highest
        {
            get
            {
                var _max = enDiceFace.One;
                foreach (var item in _dices)
                {
                    if (item > _max)
                        _max = item;
                }
                return _max;
            }
        }

        public enDiceFace Lowest
        {
            get
            {
                var _min = enDiceFace.Six;
                foreach (var item in _dices)
                {
                    if (item < _min)
                        _min = item;
                }
                return _min;
            }
        }

        public enDiceFace this[int idx] => _dices[idx];

        public override string ToString()
        {
            var sRet = "";
            foreach (var item in _dices)
            {
                sRet += $"{item}, ";
            }
            return sRet;
        }

        public ICupOfDice Sort()
        {
            _dices.Sort();
            return this;
        }

        public ICupOfDice Shake()
        {
            for (int i = 0; i < _dices.Count; i++)
            {
                _dices[i] = _rnd.FromEnum<enDiceFace>();
            }
            return this;
        }

        public csCupOfDice(int _nrOfDices)
        {
            if (_nrOfDices < 1 || _nrOfDices > 10)
                throw new ArgumentOutOfRangeException("Tjabba");

            for (int i = 0; i < _nrOfDices; i++)
            {
                //_dice.Add((enDiceFace)_rnd.Next(1,7));
                _dices.Add(_rnd.FromEnum<enDiceFace>());
            }
        }
    }
}
