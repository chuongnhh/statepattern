using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Right : State
    {
        public void DoAction(Context context)
        {
            context.Left += 5;
            context.Text = "Right";
        }
    }
}
