namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        Button[,] dokmeha;
        int ply = 1;
        public Form1()
        {
            InitializeComponent();
            dokmeha = new Button[3, 3] { { button1,button2,button3},
                                          {button4,button5,button6 },
                                          {button7,button8,button9 }};

            new_game();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "X";
                    this_button.BackColor = Color.HotPink;
                    this_button.ForeColor = Color.Pink;
                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "O";
                    this_button.BackColor = Color.DarkGray;
                    this_button.ForeColor = Color.Gray;
                    ply = 1;
                }
            }
            check_game();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new_game();
        }
        private void new_game()
        {
            ply = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].Text = "";
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                }
            }
        }
        private void check_game()
        {
            if (dokmeha[0, 0].Text == "X" && dokmeha[0, 1].Text == "X" && dokmeha[0, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "X" && dokmeha[2, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 0].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 1].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 2].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[0, 1].Text == "O" && dokmeha[0, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "O" && dokmeha[2, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 0].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 1].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 2].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            else if (dokmeha[0, 0].Text != "" && dokmeha[0, 1].Text != "" && dokmeha[0, 2].Text != "" && dokmeha[1, 0].Text != "" && dokmeha[1, 1].Text != "" && dokmeha[1, 2].Text != "" && dokmeha[2, 0].Text != "" && dokmeha[2, 1].Text != "" && dokmeha[2, 2].Text != "")
            {
                MessageBox.Show("مساوی");
                new_game();
            }
        }
    }
}