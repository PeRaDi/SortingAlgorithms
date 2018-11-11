using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        ArrayBuilder aBuilder = new ArrayBuilder();

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
            arrayLenght = toInt(num_arraylenght.Value);
            aBuilder.Generate(arrayLenght);
            
        }

        public int toInt(decimal d)
        {
            int value = (int)d;
            return value;
        }
    }
}
