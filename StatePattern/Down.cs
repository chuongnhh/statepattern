using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Down : State
    {
        public void DoAction(Context context)
        {
            context.Top += 5;
            context.Text = "Down";
        }
    }
}
