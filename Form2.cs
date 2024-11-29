using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_TUAN_4
{
    public partial class Form2 : Form
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void lblNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void DongY_Click(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            MSNV = txtMSNV.Text;
            TenNV = txtTenNV.Text;
            LuongCB = txtLuongCB.Text;
            if (string.IsNullOrWhiteSpace(MSNV) || string.IsNullOrWhiteSpace(TenNV) || string.IsNullOrWhiteSpace(LuongCB))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
            else
            {
                this.DialogResult = DialogResult.OK; // Trả về OK nếu thông tin hợp lệ
                this.Close(); // Đóng form
            }
        }
    }
}
