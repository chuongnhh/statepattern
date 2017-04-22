using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public class Context : Label
    {
        public Context()
        {
            State = null;
            this.Text = "None";
        }
        public State State { get; set; }
    }
}
