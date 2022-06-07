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

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Uxbutton8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Win the game by forming a horizontal, vertical, or diagonal line of 3 chosen boxes." , "TicTacToe Help");
        }

        private void Uxbutton1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();

        }

        private void UxTicTacToeForm_Load(object sender, EventArgs e)
        {

        }

        private void Uxbutton2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();

        }

        private void Uxbutton3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();
        }

        private void Uxbutton4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();
        }

        private void Uxbutton6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();
        }

        private void Uxbutton7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();
        }

        private void Uxbutton9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();
        }

        private void UxexitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Uxbutton5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();
        }

        private void checkforWinner()
        {
            bool there_is_a_winner = false;

            //checking left to right, horizontal buttons
            if ((Uxbutton1.Text == Uxbutton2.Text) && (Uxbutton2.Text == Uxbutton3.Text) && (!Uxbutton1.Enabled))
                there_is_a_winner = true;
            else if ((Uxbutton4.Text == Uxbutton5.Text) && (Uxbutton5.Text == Uxbutton6.Text) && (!Uxbutton4.Enabled))
                there_is_a_winner = true;
            else if ((Uxbutton7.Text == Uxbutton8.Text) && (Uxbutton8.Text == Uxbutton9.Text) && (!Uxbutton7.Enabled))
                there_is_a_winner = true;

            //checking top to bottom, Vertical buttons
            if ((Uxbutton1.Text == Uxbutton4.Text) && (Uxbutton4.Text == Uxbutton7.Text) && (!Uxbutton1.Enabled))
                there_is_a_winner = true;
            else if ((Uxbutton2.Text == Uxbutton5.Text) && (Uxbutton5.Text == Uxbutton8.Text) && (!Uxbutton2.Enabled))
                there_is_a_winner = true;
            else if ((Uxbutton3.Text == Uxbutton6.Text) && (Uxbutton6.Text == Uxbutton9.Text) && (!Uxbutton3.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {

                disableButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";


                MessageBox.Show(winner + " is the winner!!");

            }
            else
            {

                if (turn_count == 9)
                    MessageBox.Show("Draw");
            }

        }

            private void disableButtons()
            {
                try
                {
                    foreach (Control c in Controls)
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                }
                catch { }
            }

        private void UxstartNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }

            }
            catch { }
        }
    }
    }

