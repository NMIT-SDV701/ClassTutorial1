using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsWorksList : List<ClsWork>
    {
        private static ClsNameComparer _NameComparer = new ClsNameComparer();
        private static ClsDateComparer _DateComparer = new ClsDateComparer();
        private byte _sortOrder;

        public byte SortOrder { get => _sortOrder; set => _sortOrder = value; }

        public void AddWork()
        {
            ClsWork lcWork = ClsWork.NewWork();
            if (lcWork != null)
            {
                Add(lcWork);
            }
        }
       
        public void DeleteWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                if (MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.RemoveAt(prIndex);
                }
            }
        }
        
        public void EditWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                ClsWork lcWork = (ClsWork)this[prIndex];
                lcWork.EditDetails();
            }
            else
            {
                MessageBox.Show("Sorry no work selected #" + Convert.ToString(prIndex));
            }
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (ClsWork lcWork in this)
            {
                lcTotal += lcWork.Value;
            }
            return lcTotal;
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
