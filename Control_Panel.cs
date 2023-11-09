using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTimeImplementation;

namespace ThreadFormTime
{
    
    public partial class Control_panel : Form
    {
        public Control_panel()
        {
            InitializeComponent();
        }
        Clock cl = new Clock();
        private void Control_panel_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            cl.Show();
        }

        private void btnDontShow_Click(object sender, EventArgs e)
        {
            cl.DontShow();
        }
    }
}
