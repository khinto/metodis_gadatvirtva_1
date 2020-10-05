using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj_1 = new Class1();
            int simagle, pudze, gverdi1, gverdi2, gverdi3,mart_partobi,perimetri;
            gverdi1 = int.Parse(textBox1.Text);
            gverdi2 = int.Parse(textBox2.Text);
            gverdi3 = int.Parse(textBox3.Text);
            simagle = int.Parse(textBox4.Text);
            pudze = int.Parse(textBox5.Text);


            mart_partobi = obj_1.metodi(pudze, simagle);
            perimetri = obj_1.metodi(gverdi1, gverdi2, gverdi3);

            label1.Text = "მართკუთხა სამკუთხედის ფართობია " + mart_partobi.ToString();
            label2.Text = "სამკუთხედის პერიმეტრია " + perimetri.ToString();





        }

        
    }
}
