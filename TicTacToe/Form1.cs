namespace TicTacToe
{
    public partial class Form1 : Form
    {
        string[,] tictactoe = new string[3, 3];

        public Form1()
        {
            InitializeComponent();
        }

        int X = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "X" || button1.Text == "0")
            {
                button1.Text = button1.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button1.Text = "X";
                    X++;
                    tictactoe[0, 0] = "X";
                }
                else
                {
                    button1.Text = "0";
                    X++;
                    tictactoe[0, 0] = "0";
                }
                CheckWinner();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (button2.Text == "X" || button2.Text == "0")
            {
                button2.Text = button2.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button2.Text = "X";
                    X++;
                    tictactoe[0, 1] = "X";
                }
                else
                {
                    button2.Text = "0";
                    X++;
                    tictactoe[0, 1] = "0";
                }
                CheckWinner();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.Text == "X" || button3.Text == "0")
            {
                button3.Text = button3.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button3.Text = "X";
                    X++;
                    tictactoe[0, 2] = "X";
                }
                else
                {
                    button3.Text = "0";
                    X++;
                    tictactoe[0, 2] = "0";
                }
                CheckWinner();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (button4.Text == "X" || button4.Text == "0")
            {
                button4.Text = button4.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button4.Text = "X";
                    X++;
                    tictactoe[1, 0] = "X";
                }
                else
                {
                    button4.Text = "0";
                    X++;
                    tictactoe[1, 0] = "0";
                }
                CheckWinner();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (button5.Text == "X" || button5.Text == "0")
            {
                button5.Text = button5.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button5.Text = "X";
                    X++;
                    tictactoe[1, 1] = "X";
                }
                else
                {
                    button5.Text = "0";
                    X++;
                    tictactoe[1, 1] = "0";
                }
                CheckWinner();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (button6.Text == "X" || button6.Text == "0")
            {
                button6.Text = button6.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button6.Text = "X";
                    X++;
                    tictactoe[1, 2] = "X";
                }
                else
                {
                    button6.Text = "0";
                    X++;
                    tictactoe[1, 2] = "0";
                }
                CheckWinner();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (button7.Text == "X" || button7.Text == "0")
            {
                button7.Text = button7.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button7.Text = "X";
                    X++;
                    tictactoe[2, 0] = "X";
                }
                else
                {
                    button7.Text = "0";
                    X++;
                    tictactoe[2, 0] = "0";
                }
                CheckWinner();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (button8.Text == "X" || button8.Text == "0")
            {
                button8.Text = button8.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button8.Text = "X";
                    X++;
                    tictactoe[2, 1] = "X";
                }
                else
                {
                    button8.Text = "0";
                    X++;
                    tictactoe[2, 1] = "0";
                }
                CheckWinner();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (button9.Text == "X" || button9.Text == "0")
            {
                button9.Text = button9.Text;
            }
            else
            {
                if (X % 2 == 0)
                {
                    button9.Text = "X";
                    X++;
                    tictactoe[2, 2] = "X";
                }
                else
                {
                    button9.Text = "0";
                    X++;
                    tictactoe[2, 2] = "0";
                }
                CheckWinner();
            }
        }

        public void button10_Click(object sender, EventArgs e)
        {
            X = 0;
            textBox1.Text = "";
            EnableButtons();

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            tictactoe = new string[3, 3];
        }


        public void CheckWinner()
        {
            for (int row = 0; row < 3; row++)
            {
                if (tictactoe[row, 0] != null && tictactoe[row, 0] == tictactoe[row, 1] && tictactoe[row, 1] == tictactoe[row, 2])
                {
                    textBox1.Text = (tictactoe[row, 0] + " wins!");
                    DisableButtons();

                }
            }

            for (int col = 0; col < 3; col++)
            {
                if (tictactoe[0, col] != null && tictactoe[0, col] == tictactoe[1, col] && tictactoe[1, col] == tictactoe[2, col])
                {
                    textBox1.Text = (tictactoe[0, col] + " wins!");
                    DisableButtons();
                }
            }

            if (tictactoe[0, 0] != null && tictactoe[0, 0] == tictactoe[1, 1] && tictactoe[1, 1] == tictactoe[2, 2])
            {
                textBox1.Text = (tictactoe[0, 0] + " wins!");
                DisableButtons();
            }

            if (tictactoe[0, 2] != null && tictactoe[0, 2] == tictactoe[1, 1] && tictactoe[1, 1] == tictactoe[2, 0])
            {
                textBox1.Text = (tictactoe[0, 2] + " wins!");
                DisableButtons();
            }

            if (X == 9)
            {
                textBox1.Text = ("Draw");
            }
        }

        private void DisableButtons()
        {
            button1.Enabled = false;
            button1.UseVisualStyleBackColor = true;

            button2.Enabled = false;
            button2.UseVisualStyleBackColor = true;

            button3.Enabled = false;
            button3.UseVisualStyleBackColor = true;

            button4.Enabled = false;
            button4.UseVisualStyleBackColor = true;

            button5.Enabled = false;
            button5.UseVisualStyleBackColor = true;

            button6.Enabled = false;
            button6.UseVisualStyleBackColor = true;

            button7.Enabled = false;
            button7.UseVisualStyleBackColor = true;

            button8.Enabled = false;
            button8.UseVisualStyleBackColor = true;

            button9.Enabled = false;
            button9.UseVisualStyleBackColor = true;
        }

        private void EnableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
    }
}
