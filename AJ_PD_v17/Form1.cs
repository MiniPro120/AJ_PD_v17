using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJ_PD_v17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_aprekinat_Click(object sender, EventArgs e)
        {
            string ediens = "";

            if (r_banans.Checked)
            {
                ediens = "banans";
            }
            else if (r_sviestmaize.Checked)
            {
                ediens = "sviestmaize";
            }
            else if (r_abols.Checked)
            {
                ediens = "abols";
            }
            double daudzums = Convert.ToDouble(nr_daudzums.Value);
            KalorijuAprekins(ediens, daudzums);
        }

        private void KalorijuAprekins(string nosaukums, double daudzums)
        {
            double kalorijas = 0;


            if (nosaukums == "banans")
            {
                kalorijas = 105 * daudzums;
            }
            else if (nosaukums == "sviestmaize")
            {
                kalorijas = 75 * daudzums;
            }
            else if (nosaukums == "abols")
            {
                kalorijas = 55 * daudzums;
            }

            txt_izvade.Text = kalorijas.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
