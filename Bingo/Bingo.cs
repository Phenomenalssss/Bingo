using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public static class Bingo
    {
        private static Random random = new Random();
        private static int size = 5;
        private static List<bool[,]> playersFields = new List<bool[,]>();
        private static string difficulty = "Лёгкая";
        private static int boardSize;
        private static int fontSize;

        public static void StartGame(string difficulty, int players, Form form, int x, int y, int sizeField, int sizeFont, string modificator = "Две линии")
        {
            boardSize = sizeField;
            fontSize = sizeFont;
            Panel gamePanel = new Panel();
            gamePanel.Location = new Point(x, y);
            gamePanel.Size = new Size(boardSize, boardSize);
            gamePanel.BackColor = Color.Transparent;
            form.Controls.Add(gamePanel);
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.Transparent;
            gamePanel.Controls.Add(panel);
            SetDifficulty(difficulty);

            for (int i = 0; i < players; i++)
            {
                bool[,] field = new bool[size, size];
                playersFields.Add(field);
                TableLayoutPanel board = CreateBoard(i);
                panel.Controls.Add(board);
            }
        }

        private static TableLayoutPanel CreateBoard(int player)
        {
            TableLayoutPanel table = new TableLayoutPanel();
            table.Width = boardSize;
            table.Height = boardSize;
            table.RowCount = size;
            table.ColumnCount = size;

            for (int i = 0; i < size; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            }

            List<int> numbers = Enumerable.Range(1, 99).OrderBy(x => random.Next()).Take(25).ToList();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Text = numbers[row * size + col].ToString();
                    btn.Font = new Font("Inter", fontSize, FontStyle.Bold);
                    btn.Tag = new CellData() { Player = player, Row = row, Col = col };
                    btn.Click += CellClick;
                    table.Controls.Add(btn, col, row);
                }
            }

            return table;
        }

        private static void CellClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CellData data = (CellData)btn.Tag;
            playersFields[data.Player][data.Row, data.Col] = true;
            btn.BackColor = Color.LightGreen;
            if (CheckWin(data.Player))
            {
                MessageBox.Show($"Игрок {data.Player + 1} победил!");
            }
        }

        private static void SetDifficulty(string value)
        {
            difficulty = value;
        }

        private static bool CheckWin(int player)
        {
            switch (difficulty)
            {
                case "Лёгкая":
                    return CheckLine(player);
                case "Средняя":
                    return CheckTwoLines(player);
                case "Сложная":
                    return CheckAll(player);
            }

            return false;
        }

        private static bool CheckLine(int player)
        {
            bool[,] field = playersFields[player];

            for (int r = 0; r < size; r++)
            {
                bool win = true;

                for (int c = 0; c < size; c++)
                {
                    if (!field[r, c])
                    {
                        win = false;
                    }
                }

                if (win)
                {
                    return true;
                }
            }

            for (int c = 0; c < size; c++)
            {
                bool win = true;

                for (int r = 0; r < size; r++)
                {
                    if (!field[r, c])
                    {
                        win = false;
                    }
                }

                if (win)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckAll(int player)
        {
            bool[,] field = playersFields[player];

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    if (!field[r, c])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool CheckTwoLines(int player)
        {
            bool[,] field = playersFields[player];
            int lines = 0;

            for (int r = 0; r < size; r++)
            {
                bool ok = true;

                for (int c = 0; c < size; c++)
                {
                    if (!field[r, c])
                    {
                        ok = false;
                    }
                }

                if (ok)
                {
                    lines++;
                }
            }

            for (int c = 0; c < size; c++)
            {
                bool ok = true;

                for (int r = 0; r < size; r++)
                {
                    if (!field[r, c])
                    {
                        ok = false;
                    }
                }

                if (ok)
                {
                    lines++;
                }
            }

            return lines >= 2;
        }
    }
}
