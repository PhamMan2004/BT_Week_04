using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT_TUAN_4
{
    public partial class lblListView : Form
    {
        public lblListView()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

            
        private void dtaListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form2
                string MSNV = form2.MSNV;
                string TenNV = form2.TenNV;
                string LuongCB = form2.LuongCB;

                // Thêm hàng mới vào DataGridView
               // listView1.Rows.Add(MSNV, TenNV, LuongCB);
            }
        }
            int vt;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedRows.Count > 0)
            {

                var selectedRow = listView1.SelectedRows[0];
                Form2 form2 = new Form2();

                // Điền dữ liệu vào Form2
                form2.MSNV = selectedRow.Cells[0].Value.ToString();
                form2.TenNV = selectedRow.Cells[1].Value.ToString();
                form2.LuongCB = selectedRow.Cells[2].Value.ToString();

                // Hiển thị Form2
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật thông tin trong DataGridView
                    selectedRow.Cells[0].Value = form2.MSNV;
                    selectedRow.Cells[1].Value = form2.TenNV;
                    selectedRow.Cells[2].Value = form2.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedRows.Count > 0)
            {
                // Xóa hàng được chọn
                listView1.Rows.RemoveAt(listView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}