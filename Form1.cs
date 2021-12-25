using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_test
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LKTB3BK;Initial Catalog=HR;User ID=sa;Password=admin123");
            con.Open();
            SqlCommand cmd= new SqlCommand("insert into Employee_Details values('"+textBox1.Text+"', '"+textBox2.Text+"','"+ComboBox1.Text+"','"+checkedListBox1.Text+"','"+maskedTextBox1.Text+"','"+maskedTextBox2.Text+"','"+Convert.ToInt32(textBox3.Text)+"','"+Convert.ToInt32(textBox4.Text)+"','"+textBox5.Text+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted successfully...");
            
            
        }

        private void radiomale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LKTB3BK;Initial Catalog=HR;User ID=sa;Password=admin123");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Employee_Details", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.DataBindingComplete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
