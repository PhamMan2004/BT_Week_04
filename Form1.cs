using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Bitmap fil|*.bmp|JPEG file|*.jpg";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Form2 frm2 = new Form2(openfile.FileName);
                frm2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void TaovanbanmoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            cmbFonts.SelectedItem = "Tahoma"; 
            cmbSizes.SelectedItem = "14";      

            richTextBox1.Font = new Font("Tahoma", 14); 
            richTextBox1.ForeColor = Color.Black; 
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            if (cmbFonts.SelectedItem != null)
            {
                string selectedFont = cmbFonts.SelectedItem.ToString();
                richTextBox1.Font = new Font(selectedFont, richTextBox1.Font.Size);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                địnhDạngToolStripMenuItem.ForeColor = fontDlg.Color;
                địnhDạngToolStripMenuItem.Font = fontDlg.Font;
            }
        }

        private void cmbSizes_Click(object sender, EventArgs e)
        {
            if (cmbSizes.SelectedItem != null)
            {
                float selectedSize;
                if (float.TryParse(cmbSizes.SelectedItem.ToString(), out selectedSize))
                {
                    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, selectedSize);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            cmbFonts.SelectedItem = "Tahoma"; 
            cmbSizes.SelectedItem = "14";      

            richTextBox1.Font = new Font("Tahoma", 14); 
            richTextBox1.ForeColor = Color.Black; 
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
                openFileDialog.Title = "Chọn tập tin văn bản";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (openFileDialog.FileName.EndsWith(".txt"))
                        {
                            richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        }
                        else if (openFileDialog.FileName.EndsWith(".rtf"))
                        {
                            richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở tập tin: " + ex.Message);
                    }
                }
            }
        }
        private string currentFilePath = ""; 
        private bool isNewDocument = true;    
        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isNewDocument)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                    saveFileDialog.Title = "Lưu nội dung văn bản";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                            currentFilePath = saveFileDialog.FileName; 
                            isNewDocument = false; 
                            MessageBox.Show("Lưu văn bản thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi lưu tập tin: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Văn bản đã được lưu thành công trước đó.");
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionLength > 0)
            {
                Font currentFont = richTextBox1.SelectionFont;
                if (currentFont != null)
                {
                    FontStyle newFontStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
                    richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
                }
            }
            else
            {
                MessageBox.Show("Kéo chọn văn bản muốn tô đậm.");
        }
    }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFonts.Text = "Tahoma";
            cmbSizes.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFonts.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                cmbSizes.Items.Add(s);
            }
        }

        private void LưuFile_Click(object sender, EventArgs e)
        {
            if (isNewDocument)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                    saveFileDialog.Title = "Lưu nội dung văn bản";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                            currentFilePath = saveFileDialog.FileName; 
                            isNewDocument = false;
                            MessageBox.Show("Lưu văn bản thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi lưu tập tin: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Văn bản đã được lưu thành công trước đó.");
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                Font currentFont = richTextBox1.SelectionFont;
                if (currentFont != null)
                {
                    FontStyle newFontStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
                    richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
                }
            }
            else
            {
                MessageBox.Show("Kéo chọn văn bản muốn in nghiêng.");
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                Font currentFont = richTextBox1.SelectionFont;
                if (currentFont != null)
                {
                    FontStyle newFontStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;
                    richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
                }
            }
            else
            {
                MessageBox.Show("Kéo chọn văn bản muốn gạch dưới.");
            }
        }
    }

}


