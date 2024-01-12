using System;
using System.Collections;

namespace Section_B_Practical_question
{
    public partial class Form1 : Form
    {
        ArrayList addedWords = new ArrayList();
        ArrayList conWords = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                button2.Text = "Concatenate";
            }
            else if (radioButton1.Checked == true)
            {
                button2.Text = "Remove Item";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No text was entered in the textfield.");
            }
            else
            {

                if (comboBox1.FindString(textBox1.Text) != -1)
                {
                    if (comboBox2.FindString(textBox1.Text) != -1)
                    {
                        MessageBox.Show("This word has already been entered in both comboBoxes.");
                    }
                    else
                    {
                        MessageBox.Show("This word has already been entered in comboBox 1.");
                    }

                }
                else if (comboBox2.FindString(textBox1.Text) != -1)
                {
                    MessageBox.Show("This word has already been entered in comboBox 2.");
                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                    comboBox2.Items.Add(textBox1.Text);
                    addedWords.Add(textBox1.Text);
                    MessageBox.Show("The word has been added to both combo boxes.");
                }
                // textBox1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                button2.Text = "Concatenate";
            }
            else if (radioButton2.Checked == true)
            {
                button2.Text = "Remove Item";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Remove Item")
            {
                if (radioButton1.Checked == true)
                {
                    if (comboBox1.Text == "--Words--")
                    {
                        MessageBox.Show("No word was selected for removal!");
                    }
                    else
                    {
                        comboBox1.Items.Remove(comboBox1.SelectedItem);
                        comboBox1.Text = "--Words--";
                        MessageBox.Show("The word has been removed from combo box 1.");
                    }
                    radioButton1.Checked = false;
                }
                if (radioButton2.Checked == true)
                {
                    if (comboBox2.Text == "--Words--")
                    {
                        MessageBox.Show("No word was selected for removal!");
                    }
                    else
                    {
                        comboBox2.Items.Remove(comboBox2.SelectedItem);
                        comboBox2.Text = "--Words--";
                        MessageBox.Show("The word has been removed from combo box 2.");
                    }
                    radioButton2.Checked = false;
                }
            }
            else
            {
                if (comboBox2.Text == "--Words--" || comboBox1.Text == "--Words--")
                {
                    MessageBox.Show("No word was selected in one or both of the combo boxes!");
                }
                else if (comboBox2.Text == comboBox1.Text)
                {
                    MessageBox.Show("Both combo boxes have the same word selected." +
                        " Please change one of the words.");
                }
                else
                {
                    label5.Text = comboBox1.Text + comboBox2.Text;
                    conWords.Add(label5.Text);
                    MessageBox.Show("The concatenated word has been added to the array list.");
                }
            }
        }
    }
}