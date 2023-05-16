using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_Game
{
    public partial class MainForm : Form
    {
        private string difficulty;
        private int[,] board;
        private Button[,] buttons;
        private const int OFFSET = 50;
        private int attempts = 3;
        private int flagCount;
        public MainForm(string selectedDifficulty)
        {
            InitializeComponent();
            this.difficulty = selectedDifficulty;

        }

        private void init(int width, int height, int bombs)
        {
            board = new int[width, height];
            buttons = new Button[width, height];
            // Limit the number of bombs to 80% of the total cells
            if (bombs > 0.8 * width * height) { bombs = (int)(0.8 * width * height); }
            Random random = new Random();
            while (bombs > 0)
            {
                int x = random.Next(width);
                int y = random.Next(height);
                if (board[x, y] == -1) { continue; }
                board[x, y] = -1;
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        if (x + dx < 0 || y + dy < 0 || x + dx >= width || y + dy >= height) { continue; }
                        if (board[x + dx, y + dy] != -1) { board[x + dx, y + dy]++; }

                    }
                }
                bombs--;

            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int rowCount, colCount, mineCount;


            switch (difficulty)
            {
                case "Easy":
                    rowCount = 9;
                    colCount = 9;
                    mineCount = 10;
                    break;
                case "Medium":
                    rowCount = 13;
                    colCount = 15;
                    mineCount = 40;
                    break;
                case "Hard":
                    rowCount = 16;
                    colCount = 20;
                    mineCount = 99;
                    break;
                default:
                    throw new ArgumentException("Invalid difficulty level");
            }

            init(rowCount, colCount, mineCount);
            flagCount = mineCount;
            remainingFlagsLabel.Text = $"Remaining Flags: {flagCount}";

            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    Button b = new Button();
                    buttons[x, y] = b;
                    b.Font = new Font("Arial", 40);
                    b.Left = x * 80;

                    b.Top = (y * 80) + OFFSET;
                    b.Width = 80;
                    b.Height = 80;
                    b.Text = "";
                    Controls.Add(b);
                    b.MouseDown += B_Click;
                }
            }
        }

        private void B_Click(object? sender, MouseEventArgs e)
        {
            Button b = (Button)sender;


            int x = b.Left / 80;
            int y = b.Top / 80;

            if (e.Button == MouseButtons.Left)
            {

                if (board[x, y] == -1)
                {
                    b.Font = new Font("Arial", 30);
                    b.Text = "\U0001F4A3";
                    attempts--;
                    atemptscount.Text = $"{attempts}";

                    if (attempts <= 0)
                    {
                        MessageBox.Show("You lost! No more attempts left.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if (board[x, y] == 0)
                {
                    b.Text = "";
                    RevealCell(x, y);
                }
                else { b.Text = "" + board[x, y]; }
                b.Enabled = false;

                if (CheckWinCondition())
                {
                    MessageBox.Show("Congratulations! You have won the game!", "You Won", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                
            }
            else if (e.Button == MouseButtons.Right)
            {
                
                // Right-click behavior (add/remove flag)
                if (b.Text == "")
                {
                    if (flagCount > 0)
                    {
                        b.Font = new Font("Arial", 30);
                        b.Text = "\U0001F6A9";
                        flagCount--;
                        remainingFlagsLabel.Text = $"Remaining Flags: {flagCount}";
                    }
                }
                else if (b.Text == "\U0001F6A9")
                {
                    b.Text = "";
                    flagCount++;
                    remainingFlagsLabel.Text = $"Remaining Flags: {flagCount}";
                }

                if (CheckWinCondition())
                {
                    MessageBox.Show("You won! Congratulations!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void RevealCell(int x, int y)
        {
            //depth-first search algorithm to reveal nearby cells
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));
            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                if (p.X < 0 || p.Y < 0) { continue; }
                if (p.X >= board.GetLength(0) || p.Y >= board.GetLength(1)) { continue; }

                if (!buttons[p.X, p.Y].Enabled) { continue; }
                buttons[p.X, p.Y].Enabled = false;
                if (board[p.X, p.Y] != 0) { buttons[p.X, p.Y].Text = "" + board[p.X, p.Y]; }

                if (board[p.X, p.Y] != 0) { continue; }
                stack.Push(new Point(p.X - 1, p.Y));
                stack.Push(new Point(p.X + 1, p.Y));
                stack.Push(new Point(p.X, p.Y - 1));
                stack.Push(new Point(p.X, p.Y - 1));

            }
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private bool CheckWinCondition()
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x, y] != -1 && buttons[x, y].Enabled && buttons[x, y].Text != "\U0001F6A9")
                    {
                        return false;
                    }
                    // If a button has a flag but no bomb, the win condition is not met
                    if (board[x, y] == -1 && buttons[x, y].Enabled && buttons[x, y].Text != "\U0001F6A9")
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        private void atemptscount_Click(object sender, EventArgs e)
        {

        }
    }
}

