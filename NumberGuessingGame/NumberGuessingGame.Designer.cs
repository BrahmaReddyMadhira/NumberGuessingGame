using System.Windows.Forms;

namespace NumberGuessingGame
{
    partial class NumberGuessingGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        private Label Inst_Label;
        private TextBox Guess_Textbox;
        private Label Title_Label;
        private Button Exit_Button;
        private Label INST_Label_2;
        private Button Submission_Button;
        private Button Help_Button;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inst_Label = new System.Windows.Forms.Label();
            this.Guess_Textbox = new System.Windows.Forms.TextBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.INST_Label_2 = new System.Windows.Forms.Label();
            this.Submission_Button = new System.Windows.Forms.Button();
            this.Help_Button = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inst_Label
            // 
            this.Inst_Label.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inst_Label.Location = new System.Drawing.Point(33, 27);
            this.Inst_Label.Name = "Inst_Label";
            this.Inst_Label.Size = new System.Drawing.Size(492, 45);
            this.Inst_Label.TabIndex = 0;
            this.Inst_Label.Text = "To Play: Guess the randomly selected number between 1 and 100 in as little tries " +
    "as possible";
            // 
            // Guess_Textbox
            // 
            this.Guess_Textbox.Location = new System.Drawing.Point(218, 89);
            this.Guess_Textbox.Name = "Guess_Textbox";
            this.Guess_Textbox.Size = new System.Drawing.Size(193, 22);
            this.Guess_Textbox.TabIndex = 1;
            // 
            // Title_Label
            // 
            this.Title_Label.BackColor = System.Drawing.SystemColors.Highlight;
            this.Title_Label.Location = new System.Drawing.Point(169, 1);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(200, 26);
            this.Title_Label.TabIndex = 2;
            this.Title_Label.Text = "The Number Guessing Game";
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(467, 304);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(94, 29);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // INST_Label_2
            // 
            this.INST_Label_2.AutoSize = true;
            this.INST_Label_2.Location = new System.Drawing.Point(33, 89);
            this.INST_Label_2.Name = "INST_Label_2";
            this.INST_Label_2.Size = new System.Drawing.Size(161, 17);
            this.INST_Label_2.TabIndex = 4;
            this.INST_Label_2.Text = "Write your guess here->";
            this.INST_Label_2.Click += new System.EventHandler(this.INST_Label_2_Click);
            // 
            // Submission_Button
            // 
            this.Submission_Button.Location = new System.Drawing.Point(218, 122);
            this.Submission_Button.Name = "Submission_Button";
            this.Submission_Button.Size = new System.Drawing.Size(193, 50);
            this.Submission_Button.TabIndex = 5;
            this.Submission_Button.Text = "Press me to test your guess!";
            this.Submission_Button.UseVisualStyleBackColor = true;
            this.Submission_Button.Click += new System.EventHandler(this.Submission_Button_Click);
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(33, 304);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(94, 29);
            this.Help_Button.TabIndex = 6;
            this.Help_Button.Text = "HELP!";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(215, 198);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(0, 17);
            this.lblRandomNumber.TabIndex = 7;
            // 
            // NumberGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 355);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.Submission_Button);
            this.Controls.Add(this.INST_Label_2);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.Guess_Textbox);
            this.Controls.Add(this.Inst_Label);
            this.Name = "NumberGuessingGame";
            this.Text = "Number Guessing Game";
            this.Load += new System.EventHandler(this.NumberGuessingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label lblRandomNumber;
    }
}

