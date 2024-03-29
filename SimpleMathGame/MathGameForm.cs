using NumberGenerationAndAssignment;
namespace SimpleMathGame
{
    public partial class MathGameForm : Form
    {
        int timeLimit = 15; //Default time limit is 15 seconds.
        int remainingTime = 0;
        int numberOfCorrectAnswers = 0;
        int maxNumber = 100; // The scope of the math problems.
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
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var generateNumbers = new NumbersGenerator(maxNumber);
            numberOfCorrectAnswers = 0;
            remainingTime = timeLimit;

            AssignedNumbersAndResult additionProblem = generateNumbers.GenerateAdditionProblem();
            labelAddNo1.Text = additionProblem.Number1.ToString();
            labelAddNo2.Text = additionProblem.Number2.ToString();
            textBoxResultAdd.Tag = additionProblem.Result;

            AssignedNumbersAndResult subtractionProblem = generateNumbers.GenerateSubtractionProblem();
            labelSubtNo1.Text = subtractionProblem.Number1.ToString();
            labelSubtNo2.Text = subtractionProblem.Number2.ToString();
            textBoxResultSubtract.Tag = subtractionProblem.Result;

            AssignedNumbersAndResult multiplicationProblem = generateNumbers.GenerateMultiplicationProblem();
            labelMultNo1.Text = multiplicationProblem.Number1.ToString();
            labelMultNo2.Text = multiplicationProblem.Number2.ToString();
            textBoxResultMultiply.Tag = multiplicationProblem.Result;

            AssignedNumbersAndResult divisionProblem = generateNumbers.GenerateDivisionProblem();
            labelDivNo1.Text = divisionProblem.Number1.ToString();
            labelDivNo2.Text = divisionProblem.Number2.ToString();
            textBoxResultDivide.Tag = divisionProblem.Result;

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

        private void Timer_Tick(object sender, EventArgs e)
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
                foreach (TextBox textBox in panelAnswers.Controls)
                {
                    CheckResults(textBox);
                }
                CountCorrectAnswers();
                ShowResults();
            }
        }
        private bool CheckResults(TextBox textBox)
        {
            return textBox.Text != string.Empty && textBox.Tag != null && int.Parse(textBox.Text) == (int)textBox.Tag;
        }
        private void ChangeColoursAndDeactivate(TextBox textBox)
        {
            // The results turn green or red based on whether they are correct.
            // The textbox is set as ReadOnly.
            textBox.ReadOnly = true;
            textBox.BackColor = SystemColors.Control;
            if (CheckResults(textBox))
            {
                textBox.ForeColor = Color.Green;
            }
            else
            {
                textBox.ForeColor = Color.Red;
            }
        }
        private void CountCorrectAnswers()
        {
            numberOfCorrectAnswers = 0;
            foreach (TextBox textBox in panelAnswers.Controls) // All user answers are checked.
            {
                if (CheckResults(textBox))
                {
                    numberOfCorrectAnswers++;
                }
            }
            if (numberOfCorrectAnswers == 4) // If all the player's answers are correct, the game ends.
            {
                timer.Stop();
                ShowResults();
            }
        }
        private void ShowResults()
        {
            foreach (TextBox textBox in panelAnswers.Controls) // All user answers are deleted.
            {
                ChangeColoursAndDeactivate(textBox);
            }
            string message = string.Empty;
            switch (numberOfCorrectAnswers)
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

        // When the player types in their answer, the answer gets checked against the result.
        // If the player types in all the correct answers before the time limit runs out, the game ends.
        private void TextBoxResult_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // If the current answer is correct, all the answers get checked.
            if (CheckResults(textBox))
            {
                CountCorrectAnswers();
            }
        }

        private void TrackBarMaxNumber_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            maxNumber = trackBar.Value;
            // The condition makes sure the trackbar moves by the small change increments (easier to get to a rounded value).
            // Default small change is 10.
            if (maxNumber % trackBar.SmallChange != 0)
            {
                maxNumber = (maxNumber / trackBar.SmallChange) * trackBar.SmallChange;
            }
            labelMaxNumber.Text = maxNumber.ToString();
        }

        private void TrackBarTimeLimit_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            timeLimit = trackBar.Value;
            // The condition makes sure the trackbar moves by the small change increments (easier to get to a rounded value).
            // Default small change is 5 seconds.
            if (timeLimit % trackBar.SmallChange != 0)
            {
                timeLimit = (timeLimit / trackBar.SmallChange) * trackBar.SmallChange;
            }
            labelTimeLimit.Text = timeLimit.ToString();
        }
    }
}
