using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Matthew T Baker
 * CST - 117
 * August 12, 2019
 * Dominga Gardner
 */
namespace Programming_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_results.Text = "Press play for results.";
        }

        private void Btn_play_Click(object sender, EventArgs e)
        {
            TTT t = new TTT();
            int[,] game = t.Play();
            lab_pos1.Text = game[0, 0].ToString();
            lab_pos2.Text = game[0, 1].ToString();
            lab_pos3.Text = game[0, 2].ToString();
            lab_pos4.Text = game[1, 0].ToString();
            lab_pos5.Text = game[1, 1].ToString();
            lab_pos6.Text = game[1, 2].ToString();
            lab_pos7.Text = game[2, 0].ToString();
            lab_pos8.Text = game[2, 1].ToString();
            lab_pos9.Text = game[2, 2].ToString();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
