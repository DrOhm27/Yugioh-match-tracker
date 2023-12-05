namespace Yugioh_match_tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class match
        {
            public bool win;
            public bool loss;
            public string your_deck_name;
            public string opponents_deck_name;
            public int your_score;
            public int opponents_score;
            public string match_data = " ";
        }

        void win_loss_check()
        {
            if (access.win == true && access.loss == false)
            {
                access.match_data = " " + access.match_data + " WIN ";
            }

            else if (access.loss == true && access.win == false)
            {
                access.match_data = " " + access.match_data + " LOSS ";
            }
        }

        void your_deck_name_check()
        {
            if (access.your_deck_name == " ")
            {
                MessageBox.Show("Your deck name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (access.your_deck_name != " ")
            {
                access.match_data = " " + access.match_data + " " + access.your_deck_name;
            }
        }

        void score_check()
        {
            Convert.ToString(access.your_score);
            Convert.ToString(access.opponents_score);

            access.match_data = " " + access.match_data + " " + access.your_score + " - " + " " + access.opponents_score;
        }

        void your_opponents_deck_name_check()
        {
            if (access.opponents_deck_name == " ")
            {
                MessageBox.Show("Your oppponents deck name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (access.opponents_deck_name != " ")
            {
                access.match_data = " " + access.match_data + " " + access.opponents_deck_name;
            }
        }

        match access = new match();

        private void button1_Click(object sender, EventArgs e)
        {
            win_loss_check();
            your_deck_name_check();
            score_check();
            your_opponents_deck_name_check();

            listBox1.Items.Add(access.match_data);

            access.match_data = " ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                access.win = true;
                access.loss = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                access.win = false;
                access.loss = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            access.your_deck_name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            access.opponents_deck_name = textBox2.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            access.your_score = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            access.opponents_score = (int)numericUpDown2.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string filePath = "database.txt"; // Specify the file name

            // Create or overwrite the file and write ListBox items to it
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in listBox1.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("ListBox content saved to " + filePath, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string filePath = "database.txt"; // Specify the file name

            if (File.Exists(filePath))
            {
                // Clear the existing items in the ListBox
                listBox1.Items.Clear();

                // Read the lines from the text file and add them to the ListBox
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }

                MessageBox.Show("Content loaded from " + filePath, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The file " + filePath + " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}