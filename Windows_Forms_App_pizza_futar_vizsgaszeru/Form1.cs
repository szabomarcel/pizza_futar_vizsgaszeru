using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App_pizza_futar_vizsgaszeru
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

        private void button_Modositas_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            int ftel = 0;
            string fazon = "fazon";
            db.Modositas(ftel, fazon);
        }

        private void button_Lekeres_Click(object sender, EventArgs e)
        {
            List<string> adatok = new List<string>();
            foreach (string adat in adatok) 
            {
                listBox_Adat.Items.Add(adat);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
