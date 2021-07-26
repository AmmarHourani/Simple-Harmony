using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace hookmebyharmony
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var code = new Calculator();

            // should write 2

            //MessageBox.Show(Convert.ToString(code.Add(1, 1)));
            MessageBox.Show(Convert.ToString(Calculator.Add(1, 1)));

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Process.GetCurrentProcess().Kill();
        }
    }

    public class Calculator
    {
        public static int Add(int x, int y)
        {
            // this is correct
            return x + y;
        }
    }

}
