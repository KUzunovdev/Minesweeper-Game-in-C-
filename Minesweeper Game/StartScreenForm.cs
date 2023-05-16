namespace Minesweeper_Game
{
    public partial class StartScreenForm : Form
    {
        public StartScreenForm()
        {
            InitializeComponent();
            // Set the PictureBox SizeMode property
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            // Set the PictureBox Size property to the desired dimensions
            pictureBox1.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            if (difficultyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a difficulty before starting the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string selectedDifficulty = difficultyComboBox.SelectedItem.ToString().Trim();
            MainForm mainForm = new MainForm(selectedDifficulty);
            mainForm.Show();

            
            this.Hide();
            mainForm.Closed += (s, args) => this.Close();
        }
    }
}