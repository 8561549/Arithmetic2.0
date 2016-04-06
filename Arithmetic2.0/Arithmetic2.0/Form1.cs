using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int mode;
        private void but_Start_Click(object sender, EventArgs e)//显示出题界面
        {  
            Form2 form2 = new Form2(txtOPNum.Text,txtSubNum.Text,txtMin.Text,txtMax.Text,mode);
            this.Hide();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void but_Close_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)//数字输入设置
        {
            //Ascii码 45负号 8退格
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (Char)8 && e.KeyChar != (Char)45)
            {
                e.Handled = true;//判断为数字可以输入
            }
        }

        private void rbFraction_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFraction.Checked == true)
            {
                if (cbAdd.Checked == true && cbMultiply.Checked == false)//f +-
                {
                    mode = 3;
                }
                else if (cbAdd.Checked == true && cbMultiply.Checked == true)//f +_*/
                {
                    mode = 4;
                }
                else if (cbAdd.Checked == false && cbMultiply.Checked == true)//f */
                {
                    mode = 5;
                }
                else
                {
                    cbAdd.Checked = true;
                    MessageBox.Show("请至少选择一种模式！");
                }
            }
            else
            {
                if (cbAdd.Checked == true && cbMultiply.Checked == false)//+-
                {
                    mode = 0;
                }
                else if (cbAdd.Checked == true && cbMultiply.Checked == true)// +_*/
                {
                    mode = 1;
                }
                else if (cbAdd.Checked == false && cbMultiply.Checked == true)// */
                {
                    mode = 2;
                }
                else
                {
                    cbAdd.Checked = true;
                    MessageBox.Show("请至少选择一种模式！");
                }
            }
        }

        private void rbBrackets_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBrackets.Checked == true)
            {

            }
        }

        private void cbAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFraction.Checked == true)
            {
                if (cbAdd.Checked == true && cbMultiply.Checked == false)//f +-
                {
                    mode = 3;
                }
                else if (cbAdd.Checked == true && cbMultiply.Checked == true)//f +_*/
                {
                    mode = 4;
                }
                else if (cbAdd.Checked == false && cbMultiply.Checked == true)//f */
                {
                    mode = 5;
                }
                else
                {
                    cbAdd.Checked = true;
                    MessageBox.Show("请至少选择一种模式！");
                }
            }
            else
            {
                if (cbAdd.Checked == true && cbMultiply.Checked == false)//+-
                {
                    mode = 0;
                }
                else if (cbAdd.Checked == true && cbMultiply.Checked == true)// +_*/
                {
                    mode = 1;
                }
                else if (cbAdd.Checked == false && cbMultiply.Checked == true)// */
                {
                    mode = 2;
                }
                else
                {
                    cbAdd.Checked = true;
                    MessageBox.Show("请至少选择一种模式！");
                }
            }
        }
    }
}
