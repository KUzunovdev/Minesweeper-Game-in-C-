namespace Minesweeper_Game
{
    partial class MainForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            levelLabel = new Label();
            progressBar1 = new ProgressBar();
            justext = new Label();
            atemptscount = new Label();
            remainingFlagsLabel = new Label();
            SuspendLayout();
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new Point(12, 9);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(66, 25);
            levelLabel.TabIndex = 0;
            levelLabel.Text = "Level 1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(84, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(279, 25);
            progressBar1.TabIndex = 1;
            // 
            // justext
            // 
            justext.AutoSize = true;
            justext.Location = new Point(644, 9);
            justext.Name = "justext";
            justext.Size = new Size(116, 25);
            justext.TabIndex = 2;
            justext.Text = "Attempts left";
            // 
            // atemptscount
            // 
            atemptscount.AutoSize = true;
            atemptscount.Location = new Point(766, 9);
            atemptscount.Name = "atemptscount";
            atemptscount.Size = new Size(22, 25);
            atemptscount.TabIndex = 3;
            atemptscount.Text = "3";
            atemptscount.Click += atemptscount_Click;
            // 
            // remainingFlagsLabel
            // 
            remainingFlagsLabel.AutoSize = true;
            remainingFlagsLabel.Location = new Point(420, 14);
            remainingFlagsLabel.Name = "remainingFlagsLabel";
            remainingFlagsLabel.Size = new Size(138, 25);
            remainingFlagsLabel.TabIndex = 4;
            remainingFlagsLabel.Text = "Remaining flags";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(remainingFlagsLabel);
            Controls.Add(atemptscount);
            Controls.Add(justext);
            Controls.Add(progressBar1);
            Controls.Add(levelLabel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label levelLabel;
        private ProgressBar progressBar1;
        private Label justext;
        private Label atemptscount;
        private Label remainingFlagsLabel;
    }
}