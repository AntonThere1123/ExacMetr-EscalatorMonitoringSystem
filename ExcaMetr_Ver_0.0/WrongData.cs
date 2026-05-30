using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExcaMetr_Ver_0._0
{
    public partial class WrongData : Form
    {

        public bool WantToRegister = false;
        public WrongData()
        {
            InitializeComponent();



            EXIT_ERROR.ForeColor = Color.Black;
        }



        private void Answer_Of_Problem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void EXIT_ERROR_MouseEnter(object sender, EventArgs e)
        {
            EXIT_ERROR.ForeColor = Color.Red;
        }

        private void EXIT_ERROR_MouseLeave(object sender, EventArgs e)
        {
            EXIT_ERROR.ForeColor = Color.Black;
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WrongData_Load(object sender, EventArgs e)
        {

        }
    }
}
