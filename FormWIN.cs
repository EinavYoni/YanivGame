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
    public partial class FormWIN : Form
    {
        Formgame formgame;
        public FormWIN()
        {
            InitializeComponent();
        }
        public FormWIN(Formgame formgame)
        {
            InitializeComponent();
            this.formgame = formgame;
        } 
        private void FormWIN_Load(object sender, EventArgs e)
        {
            // השתנה של סכום הקלפים של השחקן הוגדר כגלובלי לכן הטופס לוקח מטופס המשחק את זסכום הקלפים של החשקן על מנת להדפיס בסוף את התוצאות
            int h = FormTheGame.humansum;
            int c = FormTheGame.computersum;
            this.score.Text = "The score is: computer-" + c + " you- " + h;  //  משנה את הטקסט בlable ורושם את תוצאות המשחק
        }

        private void win_Click(object sender, EventArgs e)
        {
          
        }

        private void score_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formgame.Show();
            this.Hide();
        }
    }
}
