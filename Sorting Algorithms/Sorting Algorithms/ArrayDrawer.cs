using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    class ArrayDrawer
    {

        private Form form;
        private int[] array;

        public ArrayDrawer(int[] array, Form form)
        {
            this.form = form;
            this.array = array;
        }

        public void draw()
        {
            Graphics gfx;
            Pen pen = new Pen(Color.White, 2);

            gfx = this.form.CreateGraphics();
            gfx.Clear(Color.Black);

            int pos = 5;
            for(int i = 1; i < array.Length; i++)
            {
                pos = pos + 5;
                gfx.DrawRectangle(pen, new Rectangle(pos, 450 - array[i], 1, array[i]));
            }
        }

    }
}
