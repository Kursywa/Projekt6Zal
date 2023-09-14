using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programowaniewizualne5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("karta-pracy-dypl_inż.doc");
            comboBox1.Items.Add("promotor-opinia-inz.doc");
            comboBox1.Items.Add("protokol_komisji_egz_inz.doc");
            comboBox1.Items.Add("recenzent-opinia-inz.doc");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "karta-pracy-dypl_inż.doc")
            {
                Form frm2 = new Form2();
                frm2.ShowDialog();
            }
            if (comboBox1.SelectedItem == "promotor-opinia-inz.doc")
            {
                Form3 frm5 = new Form5();
                frm5.ShowDialog();
            }
            if(comboBox1.SelectedItem == "protokol_komisji_egz_inz.doc")
            {
                Form frm4 = new Form4();
                frm4.ShowDialog();
            }
            if(comboBox1.SelectedItem == "recenzent-opinia-inz.doc")
            {
                Form3 frm6 = new Form6();
                frm6.ShowDialog();
            }
        }
    }
}
