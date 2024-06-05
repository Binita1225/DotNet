using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BinitaDotNet
{
    public partial class registerstudent : Form
    {
        public int studentid= 0;
        public registerstudent()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(studentid > 0)
                {
                    string name = textBox1.Text;
                    string email = textBox4.Text;
                    string address = textBox3.Text;
                    string query = "update Student set name = '" + name + "', email= '" + email + "', address= '" + address + "' where id= '" + studentid+ "'";
                    DBConnection db = new DBConnection();
                    db.ExecuteQuery(query);
                    MessageBox.Show("Save Successfully");
                }
                else
                {
                    string name = textBox1.Text;
                    string email = textBox4.Text;
                    string address = textBox3.Text;
                    string query = "insert into student values('" + name + "', '" + email + "','" + address + "')";
                    DBConnection db = new DBConnection();
                    db.ExecuteQuery(query);
                    MessageBox.Show("Save Successfully");
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        public void Loaddataedit(int studentid)
        {
            try
            {
                string query = "SELECT * FROM Student WHERE id = " + studentid;
                DBConnection db = new DBConnection();
                DataTable result = db.GetData(query);
                if (result.Rows.Count > 0)
                {
                    textBox1.Text = result.Rows[0]["Name"].ToString();
                    textBox4.Text = result.Rows[0]["Email"].ToString();
                    textBox3.Text = result.Rows[0]["Address"].ToString();
                }
                else
                {
                    MessageBox.Show("not found id: " + studentid);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
