using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Einav
{
    public partial class FromInstr : Form
    {
        Formgame formgame;

        public FromInstr()
        {
            InitializeComponent();
        }

        public FromInstr(Formgame formgame)
        {
            InitializeComponent();
            this.formgame = formgame;
        }
        private void FromInstr_Load(object sender, EventArgs e)
        {

        }


        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formgame.Show();
        }

        private void FromInstr_Load_1(object sender, EventArgs e)
        {

        }
    }
}
