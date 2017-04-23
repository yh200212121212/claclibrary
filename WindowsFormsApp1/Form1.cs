using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            double a, b, c;
            a = Convert.ToDouble(textBox2.Text);
            b = Convert.ToDouble(textBox3.Text);
            c = Convert.ToDouble(textBox1.Text);
            ClassLibrary2.Class1 cc = new ClassLibrary2.Class1(a,b,c);
            textBox7.Text = cc.clac().ToString();
            }
            catch (Exception ex)
            {
                using (FileStream fs=File.Open(Resource1.log,FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite))
                {
                    using (StreamWriter sw=new StreamWriter(fs))
                    {
                        sw.WriteLine(ex.Message);
                        sw.WriteLine(ex.TargetSite);
                        sw.WriteLine(ex.StackTrace);
                        sw.WriteLine(ex.InnerException);
                        sw.WriteLine(ex.HResult);
                        sw.WriteLine(DateTime.Now);
                        sw.Flush();
                        sw.Close();
                    }
                    fs.Close();
                }  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = Convert.ToDouble(textBox4.Text);
                b = Convert.ToDouble(textBox6.Text);
                c = Convert.ToDouble(textBox5.Text);
                ClassLibrary3.Class1 cc = new ClassLibrary3.Class1(a, b, c);
                textBox8.Text = cc.clac().ToString();
            }
            catch (Exception ex)
            {
                using (FileStream fs = File.Open(Resource1.log, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(ex.Message);
                        sw.WriteLine(ex.TargetSite);
                        sw.WriteLine(ex.StackTrace);
                        sw.WriteLine(ex.InnerException);
                        sw.WriteLine(ex.HResult);
                        sw.WriteLine(DateTime.Now);
                        sw.Flush();
                        sw.Close();
                    }
                    fs.Close();
                }
            }
        }
    }
}
