using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "set javahome=" + textBox1.Text;
            txtContent.Text = label1.Text + label2.Text + label3.Text; ;
            if (txtContent.Text != "")
            {
                Clipboard.SetDataObject(txtContent.Text);
                MessageBox.Show("解密文档已复制到剪贴板！\n请认真查看辅助区说明！\n请认真查看辅助区说明！\n请认真查看辅助区说明！");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
