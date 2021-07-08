using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFontDialog
{
    public partial class MyFontDialog : UserControl
    {
        public MyFontDialog()
        {
            InitializeComponent();
        }
        private void MyFontDialog_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox_Fonts.Items.Add(font.Name.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult colors = colorDialog1.ShowDialog();
            if (colors == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void comboBox_SIZE_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, float.Parse(comboBox_SIZE.SelectedItem.ToString()));
        }

        private void comboBox_Fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(comboBox_Fonts.Text, textBox1.Font.Size);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Strikeout);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Underline);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Bold);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Italic);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Regular);
        }
    }
}
