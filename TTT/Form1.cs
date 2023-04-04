using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label10.Visible = false;
        }
        int j = 1;//daca e impar X, par O
        int counterX = 0;
        int counterO = 0;
        void verif()
        {
            if (label1.Text == label2.Text && label2.Text == label3.Text && label3.Text == "X"
                || label4.Text == label5.Text && label5.Text == label6.Text && label6.Text == "X"
                || label7.Text == label8.Text && label8.Text == label9.Text && label9.Text == "X"
                || label1.Text == label4.Text && label4.Text == label7.Text && label7.Text == "X"
                || label2.Text == label5.Text && label5.Text == label8.Text && label8.Text == "X"
                || label3.Text == label6.Text && label6.Text == label9.Text && label9.Text == "X"
                || label1.Text == label5.Text && label5.Text == label9.Text && label9.Text == "X"
                || label3.Text == label5.Text && label5.Text == label7.Text && label7.Text == "X")
            {
                label10.Visible = true;
                label10.Text = "A castgat X!";
                counterX++;
                scor.Text = "Punctaj: X=" + counterX.ToString() + " O=" + counterO.ToString();
            }
            else if (label1.Text == label2.Text && label2.Text == label3.Text && label3.Text == "O"
                || label4.Text == label5.Text && label5.Text == label6.Text && label6.Text == "O"
                || label7.Text == label8.Text && label8.Text == label9.Text && label9.Text == "O"
                || label1.Text == label4.Text && label4.Text == label7.Text && label7.Text == "O"
                || label2.Text == label5.Text && label5.Text == label8.Text && label8.Text == "O"
                || label3.Text == label6.Text && label6.Text == label9.Text && label9.Text == "O"
                || label1.Text == label5.Text && label5.Text == label9.Text && label9.Text == "O"
                || label3.Text == label5.Text && label5.Text == label7.Text && label7.Text == "O")
            {
                label10.Visible = true;
                label10.Text = "A castigat O!";
                counterO++;
                scor.Text = "Punctaj: X=" + counterX.ToString() + " O=" + counterO.ToString();
            }

            else if (label1.Text != "" && label2.Text != ""
                && label3.Text != "" && label4.Text != ""
                && label5.Text != "" && label6.Text != ""
                && label7.Text != "" && label8.Text != "" && label9.Text != "")
            {
                label10.Visible = true;
                label10.Text = "Remiza!";
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

            if (label1.Text == "")
            {
                if (j % 2 != 0)
                    label1.Text = "X";
                else
                    label1.Text = "O";
                j++;
                verif();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
            {
                if (j % 2 != 0)
                    label2.Text = "X";
                else
                    label2.Text = "O";
                j++;
                verif();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                if (j % 2 != 0)
                    label3.Text = "X";
                else
                    label3.Text = "O";
                j++;
                verif();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "")
            {
                if (j % 2 != 0)
                    label4.Text = "X";
                else
                    label4.Text = "O";
                j++;
                verif();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "")
            {
                if (j % 2 != 0)
                    label5.Text = "X";
                else
                    label5.Text = "O";
                j++;
                verif();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "")
            {
                if (j % 2 != 0)
                    label6.Text = "X";
                else
                    label6.Text = "O";
                j++;
                verif();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
            {
                if (j % 2 != 0)
                    label7.Text = "X";
                else
                    label7.Text = "O";
                j++;
                verif();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "")
            {
                if (j % 2 != 0)
                    label8.Text = "X";
                else
                    label8.Text = "O";
                j++;
                verif();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "")
            {
                if (j % 2 != 0)
                    label9.Text = "X";
                else
                    label9.Text = "O";
                j++;
                verif();

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void btn_Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            j = 1;
            label10.Visible = false;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
