using NumberGenerationAndAssignment;
using System.Windows.Forms;
namespace SimpleMathGame
{
    public partial class MathGameForm : Form
    {
        NumbersGenerator generateNumbers = new NumbersGenerator();
        // The constructor also accepts a parameter - highest number/range of the math problems.
        // GenerateNumbers generateNumbers = new GenerateNumbers(10000);
        AssignedNumbersAndResult additionProblem = new AssignedNumbersAndResult();
        AssignedNumbersAndResult subtractionProblem = new AssignedNumbersAndResult();
        AssignedNumbersAndResult multiplicationProblem = new AssignedNumbersAndResult();
        AssignedNumbersAndResult divisionProblem = new AssignedNumbersAndResult();
        int timeLimit = 15; //Default time limit is 15 seconds.
        int remainingTime = 0;
        int correctAnswers = 0;
        bool isAdditionResultCorrect = false;
        bool isSubtractionResultCorrect = false;
        bool isMultiplicationResultCorrect = false;
        bool isDivisionResultCorrect = false;
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
            remainingTime = timeLimit;
            isAdditionResultCorrect = false;
            isSubtractionResultCorrect = false;
            isMultiplicationResultCorrect = false;
            isDivisionResultCorrect = false;
            additionProblem = generateNumbers.GenerateAdditionProblem();
            labelAddNo1.Text = additionProblem.Number1.ToString();
            labelAddNo2.Text = additionProblem.Number2.ToString();
            subtractionProblem = generateNumbers.GenerateSubtractionProblem();
            labelSubtNo1.Text = subtractionProblem.Number1.ToString();
            labelSubtNo2.Text = subtractionProblem.Number2.ToString();
            multiplicationProblem = generateNumbers.GenerateMultiplicationProblem();
            labelMultNo1.Text = multiplicationProblem.Number1.ToString();
            labelMultNo2.Text = multiplicationProblem.Number2.ToString();
            divisionProblem = generateNumbers.GenerateDivisionProblem();
            labelDivNo1.Text = divisionProblem.Number1.ToString();
            labelDivNo2.Text = divisionProblem.Number2.ToString();
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
                isAdditionResultCorrect = checkResults(textBoxResultAdd, additionProblem.Result);
                isSubtractionResultCorrect = checkResults(textBoxResultSubtract, subtractionProblem.Result);
                isMultiplicationResultCorrect = checkResults(textBoxResultMultiply, multiplicationProblem.Result);
                isDivisionResultCorrect = checkResults(textBoxResultDivide, divisionProblem.Result);
                countCorrectAnswers();
                showResults();
            }
        }
        private bool checkResults(TextBox textBox, int result)
        {
            if (textBox.Text != string.Empty && int.Parse(textBox.Text) == result)
            {
                return true;
            }
            return false;
        }
        private void changeColoursAndDeactivate(TextBox textBox, bool isResultCorrect)
        {
            // The results turn green or red based on whether they are correct.
            // The textbox is set as ReadOnly.
            textBox.ReadOnly = true;
            textBox.BackColor = SystemColors.Control;
            if (isResultCorrect)
            {
                textBox.ForeColor = Color.Green;
            }
            else
            {
                textBox.ForeColor = Color.Red;
            }
        }
        private int countCorrectAnswers()
        {
            correctAnswers = 0;
            bool[] correctAnswersArray = {isAdditionResultCorrect, isSubtractionResultCorrect, isMultiplicationResultCorrect, isDivisionResultCorrect };
            for (int i = 0; i < correctAnswersArray.Length; i++)
            {
                if (correctAnswersArray[i])
                {
                    correctAnswers++;
                }
            }
            if (correctAnswers == 4) // If all the player's answers are correct, the game ends.
            {
                timer.Stop();
                showResults();
            }
            return correctAnswers;
        }
        private void showResults()
        {
            changeColoursAndDeactivate(textBoxResultAdd, isAdditionResultCorrect);
            changeColoursAndDeactivate(textBoxResultSubtract, isSubtractionResultCorrect);
            changeColoursAndDeactivate(textBoxResultMultiply, isMultiplicationResultCorrect);
            changeColoursAndDeactivate(textBoxResultDivide, isDivisionResultCorrect);
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

        // These four methods ensure that if the player types in all the correct answers before the time limit runs out,
        // the game ends.
        private void textBoxResultAdd_TextChanged(object sender, EventArgs e)
        {
            isAdditionResultCorrect = checkResults(textBoxResultAdd, additionProblem.Result);
            countCorrectAnswers();
        }

        private void textBoxResultSubtract_TextChanged(object sender, EventArgs e)
        {
            isSubtractionResultCorrect = checkResults(textBoxResultSubtract, subtractionProblem.Result);
            countCorrectAnswers();
        }

        private void textBoxResultMultiply_TextChanged(object sender, EventArgs e)
        {
            isMultiplicationResultCorrect = checkResults(textBoxResultMultiply, multiplicationProblem.Result);
            countCorrectAnswers();
        }

        private void textBoxResultDivide_TextChanged(object sender, EventArgs e)
        {
            isDivisionResultCorrect = checkResults(textBoxResultDivide, divisionProblem.Result);
            countCorrectAnswers();
        }
    }
}
