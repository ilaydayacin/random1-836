using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_ile_ogrenciye_not_verme_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotVer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbNotlar.Items.Clear();
            for (int i = 1; i < 16; i++)
            {
                int not = rnd.Next(0, 100);
                lbNotlar.Items.Add(" + "+not.ToString());
            }
        }
    }
}
