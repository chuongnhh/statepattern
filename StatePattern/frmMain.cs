using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class frmMain : Form
    {
        private Context context;
        public frmMain()
        {
            InitializeComponent();

            // khoi tao doi tuong context (label)
            context = new Context();
            context.AutoSize = false;
            context.Width = 50;
            context.Height = 50;
            context.BackColor = Color.Black;
            context.Left = (panel1.Width - context.Width) / 2;
            context.Top = (panel1.Height - context.Height) / 2;
            context.ForeColor = Color.White;
            context.TextAlign = ContentAlignment.MiddleCenter;
            context.Font = new Font("Segoe UI", 8);
            panel1.Controls.Add(context);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Up up = new Up();
                up.DoAction(context);
            }
            else if (e.KeyCode == Keys.Down)
            {
                Down down = new Down();
                down.DoAction(context);
            }
            else if (e.KeyCode == Keys.Left)
            {
                Left left = new Left();
                left.DoAction(context);
            }
            else if (e.KeyCode == Keys.Right)
            {
                Right right = new Right();
                right.DoAction(context);
            }
        }
    }
}
