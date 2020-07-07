﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace EggCatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wolf_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (wolf.Right > 275)
                {
                    wolf.Left += -20;
                }
                
            }
            if (e.KeyCode == Keys.Right)
            {
                if (wolf.Left < 520)
                {
                    wolf.Left += +20;

                }
            }
        }

        Random randomLocation = new Random();

        int score = 0;
        int missing = 0;

        public void falldown(PictureBox egg, int speed)
        {
            if(egg.Top <= 300)
            {
                egg.Top += speed;
            }
            else if (egg.Top > 300)
            {
                egg.Location = new Point((randomLocation.Next(275,520)),100);
            }

            if (egg.Bounds.IntersectsWith(wolf.Bounds))
            {
                egg.Location = new Point((randomLocation.Next(275, 520)), 100);
                score++;
                points.Text = "Wynik: " + Convert.ToString(score);
            }
            else if(egg.Top > 300)
            {
                missing++;
                miss.Text = "Rozbite: " + Convert.ToString(missing);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            falldown(egg1, 5);
            falldown(egg2, 8);
            falldown(egg3, 12);
            falldown(egg4, 3);
            falldown(egg5, 10);
        }

       
    }
}