using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinitaDotNet
{
    public partial class VirtualDemo : Form
    {
        public VirtualDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        BaseClass bc = new DerivedClass("hello");
            MessageBox.Show(bc.Method1());
            MessageBox.Show(bc.Method2());
        }
    }
}
