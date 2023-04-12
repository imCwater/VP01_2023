using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _024_TwoForm
{
    public partial class Form1 : Form
    {
        Form2 f = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(f ==null)
                f = new Form2(this);
            f.Show();
            this.Hide();   //form1은 숨긴다
        }
    }
}
