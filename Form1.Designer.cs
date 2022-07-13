namespace Einav
{
    partial class Formgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formgame));
            this.instructions = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructions
            // 
            this.instructions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("instructions.BackgroundImage")));
            this.instructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.instructions.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.instructions.Location = new System.Drawing.Point(12, 333);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(172, 82);
            this.instructions.TabIndex = 0;
            this.instructions.Text = " הוראות ";
            this.instructions.UseVisualStyleBackColor = true;
            this.instructions.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(408, 330);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(172, 85);
            this.start.TabIndex = 2;
            this.start.Text = "התחל משחק";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Formgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 447);
            this.Controls.Add(this.start);
            this.Controls.Add(this.instructions);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Location = new System.Drawing.Point(12, 333);
            this.Name = "Formgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formgame";
            this.Load += new System.EventHandler(this.Formgame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button instructions;
        private System.Windows.Forms.Button start;
    }
}

