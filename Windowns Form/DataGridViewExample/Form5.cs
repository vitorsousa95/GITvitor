﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class DELETANDO : Form
    {
        public DELETANDO()
        {
            InitializeComponent();
        }

        
        public void piscarLabel()
        {
            // Se o label estiver visível, ele ficará não visível.
            if (label1.Visible == true)
                label1.Visible = false;
            // Se o label estiver não visível, ele ficará visível.
            else
                label1.Visible = true;

        }

        int startXPoss = 0;
        int startLocationY = 0;
        bool incrementX = true;
        bool incrementY = true;


        private void Timer1_Tick(object sender, EventArgs e)
        {
            piscarLabel();
            this.Location = new Point(startXPoss, startLocationY);
            ReturnY();
            ReturnX();
        }
        public void ReturnY()
        {
            if (incrementY)
            {
                startLocationY = startLocationY + 5;

                if ((startLocationY + 149) >= 800)
                {
                    incrementY = false;
                }
            }
            else
            {
                startLocationY = startLocationY - 5;

                if (startLocationY <= 0)
                {
                    incrementY = true;
                }
            }
        }

        public void ReturnX()
        {
            if (incrementX)
            {
                startXPoss = startXPoss + 5;

                if ((startXPoss + 223) >= 1380)
                {
                    incrementX = false;
                }
            }
            else
            {
                startXPoss = startXPoss - 5;

                if (startXPoss <= 0)
                {
                    incrementX = true;
                }
            }
        }

        private void DELETANDO_Load(object sender, EventArgs e)
        {
         
    
         startXPoss = new Random().Next(0, 1000);
         startLocationY = new Random().Next(0, 800);
         timer1.Interval = new Random().Next(0, 200);

            timer1.Start();
        }
    }
}
