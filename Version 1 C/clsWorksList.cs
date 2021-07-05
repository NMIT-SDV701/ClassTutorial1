using System;
using System.Collections;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsWorksList : ArrayList
    {
        private static clsNameComparer _NameComparer = new clsNameComparer();
        private static clsDateComparer _DateComparer = new clsDateComparer();
        private byte sortOrder;

        public byte SortOrder { get => sortOrder; set => sortOrder = value; }

        public void AddWork()
        {
            clsWork _Work = clsWork.NewWork();
            if (_Work != null)
            {
                Add(_Work);
            }
        }
       
        public void DeleteWork(int _Index)
        {
            if (_Index >= 0 && _Index < this.Count)
            {
                if (MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.RemoveAt(_Index);
                }
            }
        }
        
        public void EditWork(int _Index)
        {
            if (_Index >= 0 && _Index < this.Count)
            {
                clsWork _Work = (clsWork)this[_Index];
                _Work.EditDetails();
            }
            else
            {
                MessageBox.Show("Sorry no work selected #" + Convert.ToString(_Index));
            }
        }

        public decimal GetTotalValue()
        {
            decimal _Total = 0;
            foreach (clsWork lcWork in this)
            {
                _Total += lcWork.GetValue();
            }
            return _Total;
        }

         public void SortByName()
         {
             Sort(_NameComparer);
         }
    
        public void SortByDate()
        {
            Sort(_DateComparer);
        }
    }
}
