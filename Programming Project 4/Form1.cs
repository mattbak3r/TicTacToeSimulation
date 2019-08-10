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

            lab_pos1.Text = t.Interpret(game[0, 0]).ToString();
            lab_pos2.Text = t.Interpret(game[0, 1]).ToString();
            lab_pos3.Text = t.Interpret(game[0, 2]).ToString();
            lab_pos4.Text = t.Interpret(game[1, 0]).ToString();
            lab_pos5.Text = t.Interpret(game[1, 1]).ToString();
            lab_pos6.Text = t.Interpret(game[1, 2]).ToString();
            lab_pos7.Text = t.Interpret(game[2, 0]).ToString();
            lab_pos8.Text = t.Interpret(game[2, 1]).ToString();
            lab_pos9.Text = t.Interpret(game[2, 2]).ToString();

            if (t.Results(game) == 0)
            {
                tb_results.Text = "O is the Winner!";
            }
            else if (t.Results(game) == 1)
            {
                tb_results.Text = "X is the Winner!";
            }
            else if (t.Results(game) == 2)
            {
                tb_results.Text = "Draw game!";
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
