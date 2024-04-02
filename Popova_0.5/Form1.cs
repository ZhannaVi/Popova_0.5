using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Popova_0._5
{

    public partial class Form1 : Form
    {
        int WrongCount = 0;
        public Form1()
        {
            InitializeComponent();
            createCells();
            startNewGame();
        }
        private void startNewGame()
        {
            loadValues();
            showRandomValuesHints(45);
        }

        private void loadValues()
        {
            // Очищает значения в каждой ячейке
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            // Этот метод будет вызываться рекурсивно 
            // до тех пор, пока не будут найдены подходящие значения для каждой ячейки
            findValueForNextCell(0, -1);
        }

        Random random = new Random();

        private bool findValueForNextCell(int i, int j)
        {
            // Увеличьте значения i и j, чтобы перейти к следующей ячейке
            // и, если столбец заканчивается, перейдет к следующей строке
            if (++j > 8)
            {
                j = 0;

                // Exit 
                if (++i > 8)

                {
                    return true;
                }



            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Find a random and valid number for the cell and go to the next cell 
            // and check if it can be allocated with another random and valid number
            do
            {
                // Находит случайные и действительные номера для ячейки и переходит к следующей ячейке 
                // и проверяет, можно ли присвоить ей другой случайный и действительный номер
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                // Выберает случайное число из числа, оставшегося в списке
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                // Удаляет выделенное значение из списка
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

           
            cells[i, j].Text = value.ToString();

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // Проверяет все ячейки в вертикальном направлении
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Проверит все ячейки в горизонтальном направлении
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Проверяет все ячейки в определенном блоке
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }



        Sudoku[,] cells = new Sudoku[9, 9];


        private void showRandomValuesHints(int hintsCount)
        {
            // Отображает значение в случайных ячейках
            // Количество подсказок зависит от выбранного игроком уровня
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                // Оформдяем ячейки с подсказками по-другому и
                // заблокируем ячейку, чтобы игрок не мог редактировать значение
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }
        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Создает 81 ячейку со стилями и местоположениями на основе индекса
                    cells[i, j] = new Sudoku();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(40, 40);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 40, j * 40);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    // событие нажатия клавиши для каждой ячейки
                    cells[i, j].KeyPress += cell_keyPressed;

                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Sudoku;

            //  ячейка заблокирована
            if (cell.IsLocked)
                return;

            int value;

            // Добавляет значение нажатой клавиши в ячейку только в том случае, если это число
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Clear the cell value if pressed key is zero
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
WrongCount = 0;
            startNewGame();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<Sudoku>();

            // Находит все неправильные входные данные
            foreach (var cell in cells)
            {
               
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell); 
                } 
            }

            // Проверка, правильны ли введенные данные или игрок выигрывает
            if (wrongCells.Any())
               
            {
               
                WrongCount += 1;
                // Выделяет неправильные входные данные
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show($"Wrong inputs: {WrongCount}");
             
            }
            else
            {
                MessageBox.Show("You Wins, Mistakes:");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                // Очисит ячейку, только если она не заблокирована
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            startNewGame();
            var hintsCount = 0;

            // Назначает количество подсказок в зависимости от
           // выбранного игрока уровня
            if (beginnerLevel.Checked)
                hintsCount = 45;
            else if (IntermediateLevel.Checked)
                hintsCount = 30;
            else if (AdvancedLevel.Checked)
                hintsCount = 15;

            showRandomValuesHints(hintsCount);
        }
    }
}

