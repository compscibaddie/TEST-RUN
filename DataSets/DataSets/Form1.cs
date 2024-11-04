using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.displayStudents().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = handler.displayLectures();
        }
    }
}
