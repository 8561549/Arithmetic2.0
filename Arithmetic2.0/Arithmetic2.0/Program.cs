using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic2._0
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Define //变量定义
    {
        public int num1, num2,num3,num4,num5,num6;//随机数
        public string[] falseans = new string[100];//错题数组
        public string[] ans = new string[100];//计算结果
        public string[] userans = new string[100];//使用者输入的答案
        public int rightnum;//答对数量
        public int oprandom;//运算符随机控制
        public int nummax;//上限
        public int nummin;//下限
        public int opnum;//运算符号个数
        public int subnum;//题目总数
        public int opmin;//控制运算符范围
        public int opmax;
        public int correctnum;//答题正确数目
    }

    public class Operation//取得运算结果
    {
        public void Add(Define define, Form2 form2)//加法结果
        {
            define.ans[form2.i] = (define.num1 + define.num2).ToString();
        }
        public void Reduce(Define define, Form2 form2)//减法结果
        {
            define.ans[form2.i] = (define.num2 - define.num1).ToString();
        }
        public void Multiply(Define define, Form2 form2)//乘法结果
        {
            define.ans[form2.i] = (define.num1 * define.num2).ToString();
        }
        public void Divide(Define define, Form2 form2)//除法结果
        {
            define.ans[form2.i] = (define.num2 / define.num1).ToString();
        }
        public void Fadd(Define define, Form2 form2)//分数加法
        {
            define.ans[form2.i] = ((define.num1 * define.num4 + define.num3 * define.num2).ToString() + "/" + (define.num2 * define.num4).ToString());
        }
        public void Freduce(Define define, Form2 form2)//分数减法
        {
            define.ans[form2.i] = ((define.num1 * define.num4 - define.num3 * define.num2).ToString() + "/" + (define.num2 * define.num4).ToString());
        }
        public void Fmultiply(Define define, Form2 form2)//分数乘法
        {
            define.ans[form2.i] = ((define.num1 * define.num3).ToString() + "/" + (define.num2 * define.num4).ToString());
        }
        public void Fdivide(Define define,Form2 form2)//分数除法
        {
            define.ans[form2.i] = ((define.num1 * define.num4).ToString() + "/" + (define.num2 * define.num3).ToString());
        }
    }

    public class Output//打印输出
    {
        public void AddOutput(Define define, Form2 form2)//加法输出
        {
            form2.lb_Topic.Items.Add(define.num1 + "+" + define.num2 + "=");
        }

        public void ReduceOutput(Define define, Form2 form2)//减法输出
        {
            form2.lb_Topic.Items.Add(define.num2 + "-" + define.num1 + "=");   
        }

        public void MultiplyOutput(Define define, Form2 form2)//乘法输出
        {
            form2.lb_Topic.Items.Add(define.num1 + "×" + define.num2 + "=");
        }

        public void DivideOutput(Define define, Form2 form2)//除法输出
        {
            form2.lb_Topic.Items.Add(define.num2 + "÷" + define.num1 + "=");

        }

        public void AnsOutput(Define define, Form2 form2)//答案输出
        {
            for (int i = 0; i < define.subnum; i++)
            {
                form2.lb_Ans.Items.Add(define.ans[i]);
            }
        }

        public int GCD(int a, int b)//求最大公约数并通分
        {
            int c,n;
            n = a;
            while (b != 0)  /* 余数不为0，继续相除，直到余数为0 */
            {
                c = a % b;
                a = b;
                b = c;
            }

            return n / a;
        }

        public void FaddOutput(Define define, Form2 form2)//分数加法
        {
            form2.lb_Topic.Items.Add("(" + GCD(define.num1, define.num2) + "/" + GCD(define.num2, define.num1) + ")" + "+" + "(" + GCD(define.num3, define.num4) + "/" + GCD(define.num4, define.num3) + ")" + "=");
        }

        public void FreduceOutput(Define define, Form2 form2)//分数减法
        {
            form2.lb_Topic.Items.Add("(" + GCD(define.num1, define.num2) + "/" + GCD(define.num2, define.num1) + ")" + "-" + "(" + GCD(define.num3, define.num4) + "/" + GCD(define.num4, define.num3) + ")" + "=");
        }

        public void FmultiplyOutput(Define define, Form2 form2)//分数乘法
        {
            form2.lb_Topic.Items.Add("(" + GCD(define.num1, define.num2) + "/" + GCD(define.num2, define.num1) + ")" + "×" + "(" + GCD(define.num3, define.num4) + "/" + GCD(define.num4, define.num3) + ")" + "=");
        }

        public void FdivideOutput(Define define, Form2 form2)//分数减法
        {
            form2.lb_Topic.Items.Add("(" + GCD(define.num1, define.num2) + "/" + GCD(define.num2, define.num1) + ")" + "÷" + "(" + GCD(define.num3, define.num4) + "/" + GCD(define.num4, define.num3) + ")" + "=");
        }
    }
}
