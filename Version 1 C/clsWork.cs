using System;

namespace Version_1_C
{
    [Serializable()] 
    public abstract class clsWork
    {
        protected string _Name;
        protected DateTime _Date = DateTime.Now;
        protected decimal _Value;

        public clsWork()
        {
            EditDetails();
        }

        public abstract void EditDetails();

         public static clsWork NewWork()
         {
             char lcReply;
             InputBox inputBox = new InputBox("Enter P for Painting, S for Sculpture and H for Photograph");
             //inputBox.ShowDialog();
             //if (inputBox.getAction() == true)
             if (inputBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 lcReply = Convert.ToChar(inputBox.getAnswer());

                 switch (char.ToUpper(lcReply))
                 {
                     case 'P': return new clsPainting();
                     case 'S': return new clsSculpture();
                     case 'H': return new clsPhotograph();
                     default: return null;
                 }
             }
             else
             {
                 inputBox.Close();
                 return null;
             }
         }

        public override string ToString()
        {
            return _Name + "\t" + _Date.ToShortDateString();  
        }
        
        public string GetName()
        {
            return _Name;
        }

        public DateTime GetDate()
        {
            return _Date;
        }

        public decimal GetValue()
        {
            return _Value;
        }
    }
}
