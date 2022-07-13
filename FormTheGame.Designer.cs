namespace Einav
{
    partial class FormTheGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheGame));
            this.back = new System.Windows.Forms.Button();
            this.cardBox1 = new System.Windows.Forms.PictureBox();
            this.cardBox5 = new System.Windows.Forms.PictureBox();
            this.cardBox4 = new System.Windows.Forms.PictureBox();
            this.cardBox3 = new System.Windows.Forms.PictureBox();
            this.cardBox2 = new System.Windows.Forms.PictureBox();
            this.cardComBox5 = new System.Windows.Forms.PictureBox();
            this.cardComBox3 = new System.Windows.Forms.PictureBox();
            this.cardComBox4 = new System.Windows.Forms.PictureBox();
            this.cardComBox1 = new System.Windows.Forms.PictureBox();
            this.cardComBox2 = new System.Windows.Forms.PictureBox();
            this.deckOfCards = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.buttonWin = new System.Windows.Forms.Button();
            this.packk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.computerThink = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckOfCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerThink)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 60);
            this.back.TabIndex = 2;
            this.back.Text = "תפריט";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // cardBox1
            // 
            this.cardBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardBox1.Location = new System.Drawing.Point(70, 451);
            this.cardBox1.Name = "cardBox1";
            this.cardBox1.Size = new System.Drawing.Size(114, 146);
            this.cardBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBox1.TabIndex = 5;
            this.cardBox1.TabStop = false;
            this.cardBox1.Click += new System.EventHandler(this.cardBox1_Click);
            // 
            // cardBox5
            // 
            this.cardBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardBox5.Location = new System.Drawing.Point(630, 451);
            this.cardBox5.Name = "cardBox5";
            this.cardBox5.Size = new System.Drawing.Size(110, 146);
            this.cardBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBox5.TabIndex = 6;
            this.cardBox5.TabStop = false;
            this.cardBox5.Click += new System.EventHandler(this.cardBox5_Click);
            // 
            // cardBox4
            // 
            this.cardBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardBox4.Location = new System.Drawing.Point(490, 451);
            this.cardBox4.Name = "cardBox4";
            this.cardBox4.Size = new System.Drawing.Size(116, 146);
            this.cardBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBox4.TabIndex = 7;
            this.cardBox4.TabStop = false;
            this.cardBox4.Click += new System.EventHandler(this.cardBox4_Click);
            // 
            // cardBox3
            // 
            this.cardBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardBox3.Location = new System.Drawing.Point(350, 451);
            this.cardBox3.Name = "cardBox3";
            this.cardBox3.Size = new System.Drawing.Size(117, 146);
            this.cardBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBox3.TabIndex = 8;
            this.cardBox3.TabStop = false;
            this.cardBox3.Click += new System.EventHandler(this.cardBox3_Click);
            // 
            // cardBox2
            // 
            this.cardBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardBox2.Location = new System.Drawing.Point(210, 451);
            this.cardBox2.Name = "cardBox2";
            this.cardBox2.Size = new System.Drawing.Size(112, 146);
            this.cardBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBox2.TabIndex = 9;
            this.cardBox2.TabStop = false;
            this.cardBox2.Click += new System.EventHandler(this.cardBox2_Click);
            // 
            // cardComBox5
            // 
            this.cardComBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardComBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardComBox5.Location = new System.Drawing.Point(479, 137);
            this.cardComBox5.Name = "cardComBox5";
            this.cardComBox5.Size = new System.Drawing.Size(91, 111);
            this.cardComBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardComBox5.TabIndex = 10;
            this.cardComBox5.TabStop = false;
            // 
            // cardComBox3
            // 
            this.cardComBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardComBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardComBox3.Location = new System.Drawing.Point(285, 137);
            this.cardComBox3.Name = "cardComBox3";
            this.cardComBox3.Size = new System.Drawing.Size(91, 111);
            this.cardComBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardComBox3.TabIndex = 11;
            this.cardComBox3.TabStop = false;
            // 
            // cardComBox4
            // 
            this.cardComBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardComBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardComBox4.Location = new System.Drawing.Point(382, 137);
            this.cardComBox4.Name = "cardComBox4";
            this.cardComBox4.Size = new System.Drawing.Size(91, 111);
            this.cardComBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardComBox4.TabIndex = 12;
            this.cardComBox4.TabStop = false;
            // 
            // cardComBox1
            // 
            this.cardComBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardComBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardComBox1.Location = new System.Drawing.Point(188, 137);
            this.cardComBox1.Name = "cardComBox1";
            this.cardComBox1.Size = new System.Drawing.Size(91, 111);
            this.cardComBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardComBox1.TabIndex = 13;
            this.cardComBox1.TabStop = false;
            // 
            // cardComBox2
            // 
            this.cardComBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardComBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardComBox2.Location = new System.Drawing.Point(576, 137);
            this.cardComBox2.Name = "cardComBox2";
            this.cardComBox2.Size = new System.Drawing.Size(91, 111);
            this.cardComBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardComBox2.TabIndex = 14;
            this.cardComBox2.TabStop = false;
            // 
            // deckOfCards
            // 
            this.deckOfCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deckOfCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deckOfCards.Location = new System.Drawing.Point(363, 277);
            this.deckOfCards.Name = "deckOfCards";
            this.deckOfCards.Size = new System.Drawing.Size(104, 129);
            this.deckOfCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deckOfCards.TabIndex = 15;
            this.deckOfCards.TabStop = false;
            this.deckOfCards.Click += new System.EventHandler(this.deckOfCards_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(350, 268);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(142, 138);
            this.start.TabIndex = 16;
            this.start.Text = "הנח את הקלף כאן";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // buttonWin
            // 
            this.buttonWin.BackColor = System.Drawing.Color.Transparent;
            this.buttonWin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWin.BackgroundImage")));
            this.buttonWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWin.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWin.ForeColor = System.Drawing.Color.Black;
            this.buttonWin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonWin.Location = new System.Drawing.Point(26, 254);
            this.buttonWin.Name = "buttonWin";
            this.buttonWin.Size = new System.Drawing.Size(212, 166);
            this.buttonWin.TabIndex = 17;
            this.buttonWin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWin.UseVisualStyleBackColor = false;
            this.buttonWin.Click += new System.EventHandler(this.buttonWin_Click);
            // 
            // packk
            // 
            this.packk.BackColor = System.Drawing.Color.Transparent;
            this.packk.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.packk.FlatAppearance.BorderSize = 0;
            this.packk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.packk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.packk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.packk.ForeColor = System.Drawing.Color.Transparent;
            this.packk.Location = new System.Drawing.Point(540, 351);
            this.packk.Name = "packk";
            this.packk.Size = new System.Drawing.Size(138, 80);
            this.packk.TabIndex = 18;
            this.packk.UseVisualStyleBackColor = false;
            this.packk.Click += new System.EventHandler(this.packk_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // computerThink
            // 
            this.computerThink.BackColor = System.Drawing.Color.Transparent;
            this.computerThink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerThink.Image = ((System.Drawing.Image)(resources.GetObject("computerThink.Image")));
            this.computerThink.Location = new System.Drawing.Point(-1, 254);
            this.computerThink.Name = "computerThink";
            this.computerThink.Size = new System.Drawing.Size(345, 191);
            this.computerThink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerThink.TabIndex = 19;
            this.computerThink.TabStop = false;
            this.computerThink.Click += new System.EventHandler(this.computerThink_Click);
            // 
            // FormTheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 616);
            this.Controls.Add(this.computerThink);
            this.Controls.Add(this.packk);
            this.Controls.Add(this.buttonWin);
            this.Controls.Add(this.start);
            this.Controls.Add(this.deckOfCards);
            this.Controls.Add(this.cardComBox2);
            this.Controls.Add(this.cardComBox1);
            this.Controls.Add(this.cardComBox4);
            this.Controls.Add(this.cardComBox3);
            this.Controls.Add(this.cardComBox5);
            this.Controls.Add(this.cardBox2);
            this.Controls.Add(this.cardBox3);
            this.Controls.Add(this.cardBox4);
            this.Controls.Add(this.cardBox5);
            this.Controls.Add(this.cardBox1);
            this.Controls.Add(this.back);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "FormTheGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTheGame";
            this.Load += new System.EventHandler(this.FormTheGame_Load);
            this.Click += new System.EventHandler(this.FormTheGame_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormTheGame_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.cardBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardComBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckOfCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerThink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox cardBox1;
        private System.Windows.Forms.PictureBox cardBox5;
        private System.Windows.Forms.PictureBox cardBox4;
        private System.Windows.Forms.PictureBox cardBox3;
        private System.Windows.Forms.PictureBox cardBox2;
        private System.Windows.Forms.PictureBox cardComBox5;
        private System.Windows.Forms.PictureBox cardComBox3;
        private System.Windows.Forms.PictureBox cardComBox4;
        private System.Windows.Forms.PictureBox cardComBox1;
        private System.Windows.Forms.PictureBox cardComBox2;
        private System.Windows.Forms.PictureBox deckOfCards;
        private System.Windows.Forms.Button start;
        public System.Windows.Forms.Button buttonWin;
        private System.Windows.Forms.Button packk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox computerThink;
        

    }
}