using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birim_fiyat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int birimfiyat, miktar, tutar;
            birimfiyat=Convert.ToInt32(txtBirimfiyat.Text);
            miktar=Convert.ToInt32(txtMiktar.Text);
            tutar = birimfiyat * miktar;
            lblSonuc.Text = tutar.ToString();  
        }
    }
}
