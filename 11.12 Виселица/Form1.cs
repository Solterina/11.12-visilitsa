using System.Drawing.Configuration;
using System.Windows.Forms;

namespace _11._12_Виселица
{
    public partial class Form1 : Form
    {
        string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + "/imageonline/";
        string word;
        Random rnd = new Random();
        string[] words = ["ЕДА", "КУРИЦА", "МАНГО", "ШОКОЛАД",];
        bool gameOver;
        char[] wordd;
        int image = 0;
        int correcterror = 5;
        Dictionary<char, char> rus2ang = new Dictionary<char, char>() { { 'Й', 'Q' }, { 'Ц', 'W' }, { 'У', 'E' }, { 'К', 'R' }, { 'Е', 'T' }, { 'Н', 'Y' }, { 'Г', 'U' }, { 'Ш', 'I' }, { 'Щ', 'O' }, { 'З', 'P' }, { 'Х', '{' }, { 'Ъ', '}' }, { 'Ф', 'A' }, { 'Ы', 'S' }, { 'В', 'D' }, { 'А', 'F' }, { 'П', 'G' }, { 'Р', 'H' }, { 'О', 'J' }, { 'Л', 'K' }, { 'Д', 'L' }, { 'Ж', ':' }, { 'Э', '\"' }, { '/', '|' }, { 'Я', 'Z' }, { 'Ч', 'X' }, { 'С', 'C' }, { 'М', 'V' }, { 'И', 'B' }, { 'Т', 'N' }, { 'Ь', 'M' }, { 'Б', '<' }, { 'Ю', '>' }, { ',', '?' }, { 'Ё', '~' } };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }
        private void NewGame()
        {
            word = words[rnd.Next(words.Length)];
            wordd = word.Select(x => '_').ToArray();

            gameOver = false;

            image = 0;
            correcterror = 5;
            pictureBox.Image = Image.FromFile(path + image + "0.jpg");

            lblOver.Text = "";

            lbl.Text = String.Join(" ", wordd);

            lbl.Left = (this.ClientSize.Width - lbl.Width) / 2;
            pictureBox.Left = (this.ClientSize.Width - pictureBox.Width) / 2;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (gameOver && e.KeyCode == Keys.Space)
            {
                NewGame();
                return;
            }

            if (gameOver) return;

            bool flag = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (e.KeyCode.ToString()[0] == rus2ang[word[i]])
                {
                    wordd[i] = word[i];
                    flag = false;
                }
            }

            if (new string(wordd) == word)
            {
                lblOver.Text = "Нажми пробел!";
                gameOver = true;
                txtClue.Text = "Молодец, сыграем еще раз?";
                txtClue.ForeColor = Color.Black;
                txtClue.Font = new Font("Time new roman", 20, FontStyle.Regular);
                correcterror = 5;
            }

            if (flag)
            {
                image++;

                pictureBox.Image = Image.FromFile(path + image + "0.jpg");

                txtClue.Text = $"Попыток осталось {Math.Abs(image-5)}, осторожно";
                txtClue.ForeColor = Color.Black;
                txtClue.Font = new Font("Time new roman", 20, FontStyle.Regular);

                if (image == 5)
                {
                    wordd = word.ToCharArray();
                    lblOver.Text = "Game Over!";
                    gameOver = true;
                    txtClue.Text = "У вас закончились попытки!";
                    txtClue.ForeColor = Color.Red;
                    txtClue.Font = new Font("Time new roman", 20, FontStyle.Regular);
                }
            }

            lbl.Text = String.Join(" ", wordd);

            lbl.Left = (this.ClientSize.Width - lbl.Width) / 2;
            lblOver.Left = (this.ClientSize.Width - lblOver.Width) / 2;
            txtClue.Left = (this.ClientSize.Width - txtClue.Width) / 2;
        }
    }
}
