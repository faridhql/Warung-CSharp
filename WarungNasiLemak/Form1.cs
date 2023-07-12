using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarungNasiLemak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormListMenu form2 = new FormListMenu();
            form2.ShowDialog();
            
                

            
        }

        
    }
}
