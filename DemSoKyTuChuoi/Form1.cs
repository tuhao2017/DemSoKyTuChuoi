using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemSoKyTuChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * struc chuoi
         */
        
        struct String
        {
            public string Chuoi;
        }

        /*
         * Hàm đếm chuỗi
         */

        private int DemKyTuTrongChuoi(char[] bienChuoi)
        {
            int dem = 0;

            int i = 0;

            while (bienChuoi[i] != ' ')
            {
                dem++;
                i++;
            }
                
            return dem; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mangChuoi = txtChuoi.Text;

            int ketqua = 0; 

            char[] a = mangChuoi.ToCharArray();

            ketqua = DemKyTuTrongChuoi(a);

            txtKetQua.Text = ketqua.ToString();
        }
    }
}
