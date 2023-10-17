namespace M3_Yahtzee
{

    class csCupYahtzeeDice : csCupOfDice, ICupYahtzeeDice
    {
        public bool IsLargeStraight => throw new System.NotImplementedException();

        public bool IsYahtzee => throw new System.NotImplementedException();

        public int Chance
        {
            get
            {
                var sum = 0;
                foreach (var item in _dices)
                {
                    sum += (int)item;
                }
                return sum;
            }
        }

        public csCupYahtzeeDice():base(5)
        {

        }
    }

}
