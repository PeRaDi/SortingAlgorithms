﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public partial class Form1 : Form
    {

        Form graphForm = new Graph();

        public Form1()
        {
            InitializeComponent();
        }


        public int arrayLenght;

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(Lang.Confirmation_Exit, Lang.Confirmation_Exit_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            arrayLenght = toInt(num_arraylenght.Value - 1);
            ArrayBuilder.Generate(arrayLenght);

            //ArrayDrawer drawer = new ArrayDrawer(ArrayBuilder.randomArray, new Graph());
            //drawer.draw();


            Graphics gfx;
            Pen pen = new Pen(Color.White, 2);

            gfx = graphForm.CreateGraphics();
            gfx.Clear(Color.Black);

            int pos = 5;
            for (int i = 1; i < ArrayBuilder.randomArray.Length; i++)
            {
                pos = pos + 5;
                gfx.DrawRectangle(pen, new Rectangle(pos, 450 - ArrayBuilder.randomArray[i], 1, ArrayBuilder.randomArray[i]));
            }


        }

        public int toInt(decimal d)
        {
            int value = (int)d;
            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphForm.Show();
        }
    }
}
