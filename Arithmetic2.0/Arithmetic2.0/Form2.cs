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
    public partial class Form2 : Form
    {
        Define define = new Define();
        Random random = new Random();
        Output output = new Output();
        Operation operation = new Operation();
        public int i;//控制循环数
        public Form2(string opnum, string subnum, string nummin, string nummax,int mode)
        {
            InitializeComponent();
            define.opnum = int.Parse(opnum);
            define.subnum = int.Parse(subnum);
            define.nummin = int.Parse(nummin);
            define.nummax = int.Parse(nummax);
            switch (mode)
            {
                case 0://整数加减法
                    define.opmin = 0;
                    define.opmax = 2;
                    break;
                case 1://整数四则
                    define.opmin = 0;
                    define.opmax = 4;
                    break;
                case 2://整数乘除法
                    define.opmin = 2;
                    define.opmax = 4;
                    break;
                case 3://分数加减法
                    define.opmin = 4;
                    define.opmax = 6;
                    break;
                case 4://分数四则
                    define.opmin = 4;
                    define.opmax = 8;
                    break;
                case 5://分数乘除法
                    define.opmin = 6;
                    define.opmax = 8;
                    break;
                default:break;
            }
        }

        private void but_Topic_Click(object sender, EventArgs e)//出题
        {
            
            for (i = 0; i < define.subnum; i++)
            {
                int n1, n2, n3, n4;
                n1 = random.Next(define.nummin, define.nummax + 1);//随机生成数字
                n2 = random.Next(define.nummin, define.nummax + 1);
                n3 = random.Next(define.nummin, define.nummax + 1);
                n4 = random.Next(define.nummin, define.nummax + 1);
                //大小排序
                if (n1 >= n2)
                {
                    define.num1 = n2;
                    define.num2 = n1;
                }
                else
                {
                    define.num1 = n1;
                    define.num2 = n2;
                }
                if (n3 >= n4)
                {
                    define.num3 = n4;
                    define.num4 = n3;
                }
                else
                {
                    define.num3 = n3;
                    define.num4 = n4;
                }
                define.oprandom = random.Next(define.opmin, define.opmax);//随机生成运算符号
                switch (define.oprandom)
                {
                    case 0://整数加法
                        output.AddOutput(define, this);
                        operation.Add(define, this);
                        break;
                    case 1://整数减法
                        output.ReduceOutput(define, this);
                        operation.Reduce(define, this);
                        break;
                    case 2://整数乘法
                        output.MultiplyOutput(define, this);
                        operation.Multiply(define, this);
                        break;
                    case 3://整数除法
                        output.DivideOutput(define, this);
                        operation.Divide(define, this);
                        break;
                    case 4://分数加法
                        output.FaddOutput(define, this);
                        break;
                    case 5://分数减法
                        output.FreduceOutput(define, this);
                        break;
                    case 6://分数乘法
                        output.FmultiplyOutput(define, this);
                        break;
                    case 7://分数除法
                        output.FdivideOutput(define, this);
                        break;
                    default: break;
                }
            }
        }

        private void but_Return_Click(object sender, EventArgs e)//返回一级菜单
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void but_Ans_Click(object sender, EventArgs e)//显示答案
        {      
            output.AnsOutput(define, this);
        }

        private void but_Judge_Click(object sender, EventArgs e)//判断
        {
            define.userans = txt_Ans.Lines;
            for(int i = 0; i < define.subnum; i++)
            {
                if(define.ans[i] == define.userans[i])
                {
                    define.falseans[i] = lb_Topic.Items[i].ToString();
                    define.correctnum++;
                }
            }
            label5.Text = define.correctnum.ToString();
        }

        private void but_Clear_Click(object sender, EventArgs e)//清空
        {
            txt_Ans.Text = null;
            lb_Ans.Items.Clear();
            lb_Topic.Items.Clear();
        }
    }
}
