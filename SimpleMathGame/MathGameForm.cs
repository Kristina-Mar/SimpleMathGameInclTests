namespace SimpleMathGame
{
    public partial class MathGameForm : Form
    {
        GenerateNumbers generateNumbers = new GenerateNumbers();
        // The constructor also accepts parameters - highest number/range of the math problems and a time limit in seconds.
        // GenerateNumbers generateNumbers = new GenerateNumbers(10000, 60);
        SetNumbersAndResult setAddition = new SetNumbersAndResult();
        SetNumbersAndResult setSubtraction = new SetNumbersAndResult();
        SetNumbersAndResult setMultiplication = new SetNumbersAndResult();
        SetNumbersAndResult setDivision = new SetNumbersAndResult();
        int remainingTime = 0;
        int correctAnswers = 0;
        public MathGameForm()
        {
            InitializeComponent();
        }
        private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e)
        // Only allows numbers to be entered as results.
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            correctAnswers = 0;
            remainingTime = generateNumbers.TimeLimit;
            setAddition = generateNumbers.Additon();
            labelAddNo1.Text = setAddition.Number1.ToString();
            labelAddNo2.Text = setAddition.Number2.ToString();
            setSubtraction = generateNumbers.Subtraction();
            labelSubtNo1.Text = setSubtraction.Number1.ToString();
            labelSubtNo2.Text = setSubtraction.Number2.ToString();
            setMultiplication = generateNumbers.Multiplication();
            labelMultNo1.Text = setMultiplication.Number1.ToString();
            labelMultNo2.Text = setMultiplication.Number2.ToString();
            setDivision = generateNumbers.Division();
            labelDivNo1.Text = setDivision.Number1.ToString();
            labelDivNo2.Text = setDivision.Number2.ToString();
            foreach (TextBox textBox in panelAnswers.Controls) // All user answers are deleted.
            {
                textBox.ReadOnly = false;
                textBox.ForeColor = Color.Black;
                textBox.BackColor = Color.White;
                textBox.Text = string.Empty;
            }
            labelRemainingTime.Text = remainingTime.ToString();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime -= 1;
                labelRemainingTime.Text = remainingTime.ToString();
            }
            // When the time limit runs out, the user cannot modify their answers anymore and the program checks the results.
            else
            {
                timer.Stop();
                textBoxResultAdd.ReadOnly = true;
                textBoxResultSubtract.ReadOnly = true;
                textBoxResultMultiply.ReadOnly = true;
                textBoxResultDivide.ReadOnly = true;
                checkResults(textBoxResultAdd, setAddition.Result);
                checkResults(textBoxResultSubtract, setSubtraction.Result);
                checkResults(textBoxResultMultiply, setMultiplication.Result);
                checkResults(textBoxResultDivide, setDivision.Result);
                showResults();
            }
        }
        private void checkResults(TextBox textBox, int result)
        {
            textBox.BackColor = SystemColors.Control;
            if (textBox.Text != string.Empty && int.Parse(textBox.Text) == result)
            {
                correctAnswers++;
                textBox.ForeColor = Color.Green;
            }
            else
            {
                textBox.ForeColor = Color.Red;
            }
        }
        private void showResults()
        {
            string message = string.Empty;
            switch (correctAnswers)
            {
                case 4:
                    message = "All correct! Math genius?";
                    break;
                case 3:
                    message = "You have 3 correct answers, well done.";
                    break;
                case 2:
                    message = "You have 2 correct answers, there's room for improvement.";
                    break;
                case 1:
                    message = "You have only 1 correct answer, keep practising!";
                    break;
                default:
                    message = "You have 0 correct answers :( Better luck next time!";
                    break;
            }
            DialogResult playAgain = MessageBox.Show(message + " Would you like to try again?", "Game results", MessageBoxButtons.YesNo);
            if (playAgain == DialogResult.Yes)
            {
                buttonStart.PerformClick();
            }
        }
    }
}
