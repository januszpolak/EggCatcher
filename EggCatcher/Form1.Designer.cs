namespace EggCatcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wolf = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.egg1 = new System.Windows.Forms.PictureBox();
            this.egg2 = new System.Windows.Forms.PictureBox();
            this.egg3 = new System.Windows.Forms.PictureBox();
            this.egg4 = new System.Windows.Forms.PictureBox();
            this.egg5 = new System.Windows.Forms.PictureBox();
            this.points = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.miss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg5)).BeginInit();
            this.SuspendLayout();
            // 
            // wolf
            // 
            this.wolf.Image = ((System.Drawing.Image)(resources.GetObject("wolf.Image")));
            this.wolf.Location = new System.Drawing.Point(349, 256);
            this.wolf.Name = "wolf";
            this.wolf.Size = new System.Drawing.Size(69, 90);
            this.wolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolf.TabIndex = 0;
            this.wolf.TabStop = false;
            this.wolf.Click += new System.EventHandler(this.wolf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // egg1
            // 
            this.egg1.Image = ((System.Drawing.Image)(resources.GetObject("egg1.Image")));
            this.egg1.Location = new System.Drawing.Point(244, 120);
            this.egg1.Name = "egg1";
            this.egg1.Size = new System.Drawing.Size(18, 27);
            this.egg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg1.TabIndex = 2;
            this.egg1.TabStop = false;
            // 
            // egg2
            // 
            this.egg2.Image = ((System.Drawing.Image)(resources.GetObject("egg2.Image")));
            this.egg2.Location = new System.Drawing.Point(293, 170);
            this.egg2.Name = "egg2";
            this.egg2.Size = new System.Drawing.Size(18, 27);
            this.egg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg2.TabIndex = 3;
            this.egg2.TabStop = false;
            // 
            // egg3
            // 
            this.egg3.Image = ((System.Drawing.Image)(resources.GetObject("egg3.Image")));
            this.egg3.Location = new System.Drawing.Point(362, 136);
            this.egg3.Name = "egg3";
            this.egg3.Size = new System.Drawing.Size(18, 27);
            this.egg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg3.TabIndex = 4;
            this.egg3.TabStop = false;
            // 
            // egg4
            // 
            this.egg4.Image = ((System.Drawing.Image)(resources.GetObject("egg4.Image")));
            this.egg4.Location = new System.Drawing.Point(460, 111);
            this.egg4.Name = "egg4";
            this.egg4.Size = new System.Drawing.Size(18, 27);
            this.egg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg4.TabIndex = 5;
            this.egg4.TabStop = false;
            // 
            // egg5
            // 
            this.egg5.Image = ((System.Drawing.Image)(resources.GetObject("egg5.Image")));
            this.egg5.Location = new System.Drawing.Point(499, 203);
            this.egg5.Name = "egg5";
            this.egg5.Size = new System.Drawing.Size(18, 27);
            this.egg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg5.TabIndex = 6;
            this.egg5.TabStop = false;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points.Location = new System.Drawing.Point(495, 111);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(89, 24);
            this.points.TabIndex = 7;
            this.points.Text = "Wynik: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // miss
            // 
            this.miss.AutoSize = true;
            this.miss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miss.Location = new System.Drawing.Point(481, 141);
            this.miss.Name = "miss";
            this.miss.Size = new System.Drawing.Size(103, 24);
            this.miss.TabIndex = 8;
            this.miss.Text = "Rozbite: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 452);
            this.Controls.Add(this.miss);
            this.Controls.Add(this.points);
            this.Controls.Add(this.egg5);
            this.Controls.Add(this.egg4);
            this.Controls.Add(this.egg3);
            this.Controls.Add(this.egg2);
            this.Controls.Add(this.egg1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wolf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EggCatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox wolf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox egg1;
        private System.Windows.Forms.PictureBox egg2;
        private System.Windows.Forms.PictureBox egg3;
        private System.Windows.Forms.PictureBox egg4;
        private System.Windows.Forms.PictureBox egg5;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label miss;
    }
}

