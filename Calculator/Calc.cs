using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,    int nTopRect,      int nRightRect,    int nBottomRect,  int nWidthEllipse, int nHeightEllipse 
        );

        private string currentInput = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void siticoneButton17_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton17.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton1.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton2.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton3.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton6.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton5.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton4.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton9.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton8.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton7.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton18_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton18.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton10.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton13_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton13.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton14.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton15_Click(object sender, EventArgs e)
        {
            string buttonText = siticoneButton15.Text;
            currentInput += buttonText;
            label2.Text = currentInput;
        }

        private void siticoneButton16_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                try
                {
                    var dataTable = new System.Data.DataTable();
                    var result = dataTable.Compute(currentInput, "");
                    label1.Text = result.ToString();
                    currentInput = result.ToString();
                }
                catch (Exception)
                {
                    label2.Text = "Issue Occured, Calcuation Reset.";
                    currentInput = "";
                }
            }
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                label2.Text = currentInput;
            }
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            currentInput = "";
            label2.Text = "";
        }
    }
}
