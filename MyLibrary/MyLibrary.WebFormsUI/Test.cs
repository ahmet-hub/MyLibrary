using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary.WebFormsUI
{
    public partial class Test : Form
    {
        Business.DbFirstTest test = new Business.DbFirstTest();
        public Test()
        {
            
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
