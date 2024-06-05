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
    public partial class Poly : Form
    {
        public Poly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parent p = new Child();
            string message = p.Play();
            MessageBox.Show(message);
            MessageBox.Show(p.Eat());
        }
    }
}
