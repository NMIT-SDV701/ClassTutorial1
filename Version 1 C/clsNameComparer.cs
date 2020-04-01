using System.Collections.Generic;

namespace Version_1_C
{
    class ClsNameComparer : IComparer<ClsWork>
    {
        public int Compare(ClsWork x, ClsWork y)
        {
            ClsWork workClassX = x;
            ClsWork workClassY = y;
            string lcNameX = workClassX.Name;
            string lcNameY = workClassY.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
