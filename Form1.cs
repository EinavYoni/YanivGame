using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Einav
{
    public partial class Formgame : Form
    {
        bool star=false;
        public Formgame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();// ברגע שנלחץ כפתור ההוראות המסך הנל יוסתר 
            FromInstr frominstr = new FromInstr(this);
            frominstr.Show();// אם לחצו על כפתור זה כלומר צריך לפתוח את מסך ההוראות 
            if (star)// אם זוהתת לחיצה על  כפתור ההתחלה הסתר את הטופס של מסך הפתיחה
            {
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Hide();// ברגע שלחצו על כפתור ההתחל המסך הנל יוסתר 
            FormWIN FormWIN = new FormWIN(this);// מגדיר טופס ניצחון 
            FormLose FormLose = new FormLose(this);// מגדיר טופס הפסד 
            FormTheGame formTheGame = new FormTheGame(this, FormWIN ,FormLose);// מגדיר הפניה בין טופס המשחק לטופס ניצחון וטופס הפסד           
            formTheGame.Show();
        }

        private void Formgame_Load(object sender, EventArgs e)
        {

        }
    }
}
