using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground
{
    public partial class Employeeform : Form
    {
        private String employeeName;

        public Employeeform(String name)
        {
            InitializeComponent();
            this.employeeName = name;
            this.nameInput.Text = employeeName;
            this.header.Text = employeeName;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            employeeName = this.nameInput.Text;
            this.header.Text = employeeName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.doge;

            header.Text = "doge";
            label1.Text = "doge";
            nameInput.Text = "doge";
            Save.Visible = false;
            back1.Visible = true;
        }

        private void back1_Click(object sender, EventArgs e)
        {
            back1.Left -= 10;
            back1.Top -= 10;
            back1.Width += 10;
            back1.Height += 10;
        }
    }
}
