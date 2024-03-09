namespace SimpleMathGame
{
    partial class MathGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelAddNo1 = new Label();
            labelAddNo2 = new Label();
            labelPlus = new Label();
            labelEq1 = new Label();
            labelEqSubt = new Label();
            labelMinus = new Label();
            labelSubtNo2 = new Label();
            labelSubtNo1 = new Label();
            labelEqMult = new Label();
            labelMult = new Label();
            labelMultNo2 = new Label();
            labelMultNo1 = new Label();
            labelEqDiv = new Label();
            labelDiv = new Label();
            labelDivNo2 = new Label();
            labelDivNo1 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            buttonStart = new Button();
            labelRemainingTimeText = new Label();
            labelRemainingTime = new Label();
            labelSeconds = new Label();
            textBoxResultAdd = new TextBox();
            textBoxResultSubtract = new TextBox();
            textBoxResultMultiply = new TextBox();
            textBoxResultDivide = new TextBox();
            panelAnswers = new Panel();
            panelAnswers.SuspendLayout();
            SuspendLayout();
            // 
            // labelAddNo1
            // 
            labelAddNo1.AutoSize = true;
            labelAddNo1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddNo1.ImageAlign = ContentAlignment.TopLeft;
            labelAddNo1.Location = new Point(48, 87);
            labelAddNo1.Name = "labelAddNo1";
            labelAddNo1.Size = new Size(29, 36);
            labelAddNo1.TabIndex = 0;
            labelAddNo1.Text = "x";
            labelAddNo1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAddNo2
            // 
            labelAddNo2.AutoSize = true;
            labelAddNo2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddNo2.Location = new Point(211, 87);
            labelAddNo2.Name = "labelAddNo2";
            labelAddNo2.Size = new Size(30, 36);
            labelAddNo2.TabIndex = 1;
            labelAddNo2.Text = "y";
            labelAddNo2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPlus
            // 
            labelPlus.AutoSize = true;
            labelPlus.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlus.Location = new Point(128, 87);
            labelPlus.Name = "labelPlus";
            labelPlus.Size = new Size(34, 36);
            labelPlus.TabIndex = 2;
            labelPlus.Text = "+";
            labelPlus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEq1
            // 
            labelEq1.AutoSize = true;
            labelEq1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelEq1.Location = new Point(291, 87);
            labelEq1.Name = "labelEq1";
            labelEq1.Size = new Size(34, 36);
            labelEq1.TabIndex = 3;
            labelEq1.Text = "=";
            // 
            // labelEqSubt
            // 
            labelEqSubt.AutoSize = true;
            labelEqSubt.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelEqSubt.Location = new Point(291, 161);
            labelEqSubt.Name = "labelEqSubt";
            labelEqSubt.Size = new Size(34, 36);
            labelEqSubt.TabIndex = 7;
            labelEqSubt.Text = "=";
            // 
            // labelMinus
            // 
            labelMinus.AutoSize = true;
            labelMinus.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelMinus.Location = new Point(136, 161);
            labelMinus.Name = "labelMinus";
            labelMinus.Size = new Size(26, 36);
            labelMinus.TabIndex = 6;
            labelMinus.Text = "-";
            labelMinus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSubtNo2
            // 
            labelSubtNo2.AutoSize = true;
            labelSubtNo2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtNo2.Location = new Point(211, 156);
            labelSubtNo2.Name = "labelSubtNo2";
            labelSubtNo2.Size = new Size(30, 36);
            labelSubtNo2.TabIndex = 5;
            labelSubtNo2.Text = "y";
            labelSubtNo2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelSubtNo1
            // 
            labelSubtNo1.AutoSize = true;
            labelSubtNo1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtNo1.Location = new Point(48, 161);
            labelSubtNo1.Name = "labelSubtNo1";
            labelSubtNo1.Size = new Size(29, 36);
            labelSubtNo1.TabIndex = 4;
            labelSubtNo1.Text = "x";
            labelSubtNo1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelEqMult
            // 
            labelEqMult.AutoSize = true;
            labelEqMult.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelEqMult.Location = new Point(291, 228);
            labelEqMult.Name = "labelEqMult";
            labelEqMult.Size = new Size(34, 36);
            labelEqMult.TabIndex = 11;
            labelEqMult.Text = "=";
            // 
            // labelMult
            // 
            labelMult.AutoSize = true;
            labelMult.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelMult.Location = new Point(136, 228);
            labelMult.Name = "labelMult";
            labelMult.Size = new Size(27, 36);
            labelMult.TabIndex = 10;
            labelMult.Text = "*";
            labelMult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMultNo2
            // 
            labelMultNo2.AutoSize = true;
            labelMultNo2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelMultNo2.Location = new Point(211, 228);
            labelMultNo2.Name = "labelMultNo2";
            labelMultNo2.Size = new Size(30, 36);
            labelMultNo2.TabIndex = 9;
            labelMultNo2.Text = "y";
            labelMultNo2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMultNo1
            // 
            labelMultNo1.AutoSize = true;
            labelMultNo1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelMultNo1.Location = new Point(48, 228);
            labelMultNo1.Name = "labelMultNo1";
            labelMultNo1.Size = new Size(29, 36);
            labelMultNo1.TabIndex = 8;
            labelMultNo1.Text = "x";
            labelMultNo1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelEqDiv
            // 
            labelEqDiv.AutoSize = true;
            labelEqDiv.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelEqDiv.Location = new Point(291, 302);
            labelEqDiv.Name = "labelEqDiv";
            labelEqDiv.Size = new Size(34, 36);
            labelEqDiv.TabIndex = 15;
            labelEqDiv.Text = "=";
            // 
            // labelDiv
            // 
            labelDiv.AutoSize = true;
            labelDiv.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelDiv.Location = new Point(136, 302);
            labelDiv.Name = "labelDiv";
            labelDiv.Size = new Size(33, 36);
            labelDiv.TabIndex = 14;
            labelDiv.Text = "÷";
            labelDiv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDivNo2
            // 
            labelDivNo2.AutoSize = true;
            labelDivNo2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelDivNo2.Location = new Point(211, 302);
            labelDivNo2.Name = "labelDivNo2";
            labelDivNo2.Size = new Size(30, 36);
            labelDivNo2.TabIndex = 13;
            labelDivNo2.Text = "y";
            labelDivNo2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDivNo1
            // 
            labelDivNo1.AutoSize = true;
            labelDivNo1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelDivNo1.Location = new Point(48, 302);
            labelDivNo1.Name = "labelDivNo1";
            labelDivNo1.Size = new Size(29, 36);
            labelDivNo1.TabIndex = 12;
            labelDivNo1.Text = "x";
            labelDivNo1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(0, 192, 0);
            buttonStart.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.ForeColor = SystemColors.ButtonHighlight;
            buttonStart.Location = new Point(211, 376);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(131, 43);
            buttonStart.TabIndex = 20;
            buttonStart.Text = "Start game";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelRemainingTimeText
            // 
            labelRemainingTimeText.AutoSize = true;
            labelRemainingTimeText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelRemainingTimeText.Location = new Point(48, 34);
            labelRemainingTimeText.Name = "labelRemainingTimeText";
            labelRemainingTimeText.Size = new Size(183, 27);
            labelRemainingTimeText.TabIndex = 21;
            labelRemainingTimeText.Text = "Time remaining:";
            // 
            // labelRemainingTime
            // 
            labelRemainingTime.AutoSize = true;
            labelRemainingTime.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelRemainingTime.Location = new Point(257, 34);
            labelRemainingTime.Name = "labelRemainingTime";
            labelRemainingTime.Size = new Size(25, 27);
            labelRemainingTime.TabIndex = 22;
            labelRemainingTime.Text = "0";
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeconds.Location = new Point(301, 34);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(24, 27);
            labelSeconds.TabIndex = 23;
            labelSeconds.Text = "s";
            // 
            // textBoxResultAdd
            // 
            textBoxResultAdd.BackColor = SystemColors.Control;
            textBoxResultAdd.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResultAdd.ForeColor = SystemColors.WindowText;
            textBoxResultAdd.Location = new Point(10, 9);
            textBoxResultAdd.MaxLength = 10;
            textBoxResultAdd.Name = "textBoxResultAdd";
            textBoxResultAdd.ReadOnly = true;
            textBoxResultAdd.Size = new Size(178, 44);
            textBoxResultAdd.TabIndex = 16;
            textBoxResultAdd.TextAlign = HorizontalAlignment.Right;
            textBoxResultAdd.KeyPress += textBoxResult_KeyPress;
            // 
            // textBoxResultSubtract
            // 
            textBoxResultSubtract.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResultSubtract.Location = new Point(10, 84);
            textBoxResultSubtract.MaxLength = 10;
            textBoxResultSubtract.Name = "textBoxResultSubtract";
            textBoxResultSubtract.ReadOnly = true;
            textBoxResultSubtract.Size = new Size(178, 44);
            textBoxResultSubtract.TabIndex = 17;
            textBoxResultSubtract.TextAlign = HorizontalAlignment.Right;
            textBoxResultSubtract.KeyPress += textBoxResult_KeyPress;
            // 
            // textBoxResultMultiply
            // 
            textBoxResultMultiply.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResultMultiply.Location = new Point(10, 150);
            textBoxResultMultiply.MaxLength = 10;
            textBoxResultMultiply.Name = "textBoxResultMultiply";
            textBoxResultMultiply.ReadOnly = true;
            textBoxResultMultiply.Size = new Size(178, 44);
            textBoxResultMultiply.TabIndex = 18;
            textBoxResultMultiply.TextAlign = HorizontalAlignment.Right;
            textBoxResultMultiply.KeyPress += textBoxResult_KeyPress;
            // 
            // textBoxResultDivide
            // 
            textBoxResultDivide.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResultDivide.Location = new Point(10, 224);
            textBoxResultDivide.MaxLength = 10;
            textBoxResultDivide.Name = "textBoxResultDivide";
            textBoxResultDivide.ReadOnly = true;
            textBoxResultDivide.Size = new Size(178, 44);
            textBoxResultDivide.TabIndex = 19;
            textBoxResultDivide.TextAlign = HorizontalAlignment.Right;
            textBoxResultDivide.KeyPress += textBoxResult_KeyPress;
            // 
            // panelAnswers
            // 
            panelAnswers.Controls.Add(textBoxResultDivide);
            panelAnswers.Controls.Add(textBoxResultMultiply);
            panelAnswers.Controls.Add(textBoxResultSubtract);
            panelAnswers.Controls.Add(textBoxResultAdd);
            panelAnswers.Location = new Point(349, 69);
            panelAnswers.Name = "panelAnswers";
            panelAnswers.Size = new Size(205, 287);
            panelAnswers.TabIndex = 24;
            // 
            // MathGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 442);
            Controls.Add(panelAnswers);
            Controls.Add(labelSeconds);
            Controls.Add(labelRemainingTime);
            Controls.Add(labelRemainingTimeText);
            Controls.Add(buttonStart);
            Controls.Add(labelEqDiv);
            Controls.Add(labelDiv);
            Controls.Add(labelDivNo2);
            Controls.Add(labelDivNo1);
            Controls.Add(labelEqMult);
            Controls.Add(labelMult);
            Controls.Add(labelMultNo2);
            Controls.Add(labelMultNo1);
            Controls.Add(labelEqSubt);
            Controls.Add(labelMinus);
            Controls.Add(labelSubtNo2);
            Controls.Add(labelSubtNo1);
            Controls.Add(labelEq1);
            Controls.Add(labelPlus);
            Controls.Add(labelAddNo2);
            Controls.Add(labelAddNo1);
            Name = "MathGameForm";
            Text = "Count on me!";
            panelAnswers.ResumeLayout(false);
            panelAnswers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddNo1;
        private Label labelAddNo2;
        private Label labelPlus;
        private Label labelEq1;
        private Label labelEqSubt;
        private Label labelMinus;
        private Label labelSubtNo2;
        private Label labelSubtNo1;
        private Label labelEqMult;
        private Label labelMult;
        private Label labelMultNo2;
        private Label labelMultNo1;
        private Label labelEqDiv;
        private Label labelDiv;
        private Label labelDivNo2;
        private Label labelDivNo1;
        private System.Windows.Forms.Timer timer;
        private Button buttonStart;
        private Label labelRemainingTimeText;
        private Label labelRemainingTime;
        private Label labelSeconds;
        private TextBox textBoxResultAdd;
        private TextBox textBoxResultSubtract;
        private TextBox textBoxResultMultiply;
        private TextBox textBoxResultDivide;
        private Panel panelAnswers;
    }
}
