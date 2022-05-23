using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_09_02_TicTacToe_kpa
{
    public partial class UxTicTacToeForm : Form
    {
        bool turn = true;
        int turn_count = 0;

        public UxTicTacToeForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Uxbutton8_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Win by forming a horizontal, vertical, or diagonal line of 3 chosen boxes." , "TicTacToe Help");
        }

        private void Uxbutton1_Click(object sender, EventArgs e)
        {

        }

        private void UxTicTacToeForm_Load(object sender, EventArgs e)
        {

        }

        private void Uxbutton2_Click(object sender, EventArgs e)
        {

        }

        private void Uxbutton3_Click(object sender, EventArgs e)
        {

        }

        private void Uxbutton4_Click(object sender, EventArgs e)
        {

        }

        private void Uxbutton6_Click(object sender, EventArgs e)
        {

        }

        private void Uxbutton7_Click(object sender, EventArgs e)
        {

        }

        private void Uxbutton9_Click(object sender, EventArgs e)
        {

        }

        private void UxexitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
