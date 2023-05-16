namespace Minesweeper_Game
{
    partial class StartScreenForm
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
            difficultyComboBox = new ComboBox();
            label1 = new Label();
            startButton = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Exitbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // difficultyComboBox
            // 
            difficultyComboBox.FormattingEnabled = true;
            difficultyComboBox.Items.AddRange(new object[] { "Easy", "Medium ", "Hard" });
            difficultyComboBox.Location = new Point(190, 184);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(388, 33);
            difficultyComboBox.TabIndex = 0;
            difficultyComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 124);
            label1.Name = "label1";
            label1.Size = new Size(242, 40);
            label1.TabIndex = 1;
            label1.Text = "Chose a Level";
            label1.Click += label1_Click;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.Control;
            startButton.FlatAppearance.BorderColor = Color.Black;
            startButton.FlatAppearance.BorderSize = 10;
            startButton.FlatAppearance.MouseOverBackColor = Color.Black;
            startButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.LimeGreen;
            startButton.Location = new Point(190, 270);
            startButton.Name = "startButton";
            startButton.Size = new Size(380, 62);
            startButton.TabIndex = 2;
            startButton.Text = "Start Game";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(190, 18);
            label2.Name = "label2";
            label2.Size = new Size(398, 65);
            label2.TabIndex = 3;
            label2.Text = "MineSweeper";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mine;
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 181);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.mine;
            pictureBox2.Location = new Point(616, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 181);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = SystemColors.Control;
            Exitbutton.FlatAppearance.BorderColor = Color.Black;
            Exitbutton.FlatAppearance.BorderSize = 10;
            Exitbutton.FlatAppearance.MouseOverBackColor = Color.Black;
            Exitbutton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Exitbutton.ForeColor = Color.Red;
            Exitbutton.Location = new Point(190, 338);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(380, 62);
            Exitbutton.TabIndex = 6;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // StartScreenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exitbutton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(startButton);
            Controls.Add(label1);
            Controls.Add(difficultyComboBox);
            Name = "StartScreenForm";
            Text = "MineSweeper";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox difficultyComboBox;
        private Label label1;
        private Button startButton;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Exitbutton;
    }
}