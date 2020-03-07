using System;
using System.Collections;

namespace Version_1_C
{
    class clsDateComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            clsWork _WorkX = (clsWork)x;
            clsWork _WorkY = (clsWork)y;
            DateTime _DateX = _WorkX.GetDate();
            DateTime lcDateY = _WorkY.GetDate();

            return _DateX.CompareTo(lcDateY);
        }
    }
}
