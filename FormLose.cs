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
    public partial class FormLose : Form
    {
        Formgame formgame;
        //FormTheGame formTheGame;
        public FormLose()
        {
            InitializeComponent();
        }
        //public FormLose(FormTheGame formTheGame)
        //{
        //    InitializeComponent();
        //    this.formTheGame = formTheGame;
        //}
        public FormLose(Formgame formgame)
        {
            InitializeComponent();
            this.formgame = formgame;
        } 
        private void FormLose_Load(object sender, EventArgs e)
        {
            //formTheGame.Hide();
            // השתנה של סכום הקלפים של השחקן הוגדר כגלובלי לכן הטופס לוקח מטופס המשחק את זסכום הקלפים של החשקן על מנת להדפיס בסוף את התוצאות
            int h = FormTheGame.humansum; 
            int c = FormTheGame.computersum;
            this.score.Text = "The score is: computer-" + c + " you- " + h;  //  משנה את הטקסט בlable ורושם את תוצאות המשחק
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //formTheGame = new FormTheGame();
            //formTheGame.Show();
            formgame.Show();
            this.Hide();
        }
    }
}
