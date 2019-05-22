using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm
{
   public static  class FormHelper
    {
        public static Form Create(Type t)
        {
            Form m = Application.OpenForms[t.Name];
            if (m == null)
            {
                m =(Form) Activator.CreateInstance(t);
            }
            return m;
        }

    }
}
