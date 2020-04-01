using System;
using System.Collections.Generic;

namespace Version_1_C
{
    class ClsDateComparer : IComparer<ClsWork>
    {
        public int Compare(ClsWork x, ClsWork y)
        {
            ClsWork lcWorkX = x;
            ClsWork lcWorkY = y;
            DateTime lcDateX = lcWorkX.Date;
            DateTime lcDateY = lcWorkY.Date;

            return lcDateX.CompareTo(lcDateY);
        }
    }
}
