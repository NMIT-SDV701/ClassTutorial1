using System;
using System.Collections;

namespace Version_1_C
{
    class clsNameComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            clsWork workClassX = (clsWork)x;
            clsWork workClassY = (clsWork)y;
            string _NameX = workClassX.GetName();
            string _NameY = workClassY.GetName();

            return _NameX.CompareTo(_NameY);
        }
    }
}
