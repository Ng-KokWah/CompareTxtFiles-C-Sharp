using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareFiles
{
    public partial class CompareFiles : Form
    {
        public static int num = 0;
        public static int clicks = 0;
        public static string file;
        public CompareFiles()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(clicks == 0)
            {
                comboBox2.Visible = true;
                comboBox2.Enabled = true;
                label4.Visible = true;
                num++;
                clicks++;
            }
            else
            {
                comboBox2.Visible = false;
                comboBox2.Enabled = false;
                label4.Visible = false;
                clicks--;
                num--;
            }
           

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(num == 0)
            {
                String output = "";
                if(comboBox1.SelectedIndex == 0)
                {
                    output = RunCommands.RunCmdAndGetOutput("fc /a \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                    textBox3.Text = output;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    output = RunCommands.RunCmdAndGetOutput("fc /l \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                    textBox3.Text = output;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    output = RunCommands.RunCmdAndGetOutput("fc /n \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                    textBox3.Text = output;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    output = RunCommands.RunCmdAndGetOutput("fc /b \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                    textBox3.Text = output;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    output = RunCommands.RunCmdAndGetOutput("fc /c \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                    textBox3.Text = output;
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    output = RunCommands.RunCmdAndGetOutput("fc /u \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                    textBox3.Text = output;
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    output = RunCommands.RunCmdAndGetOutput("fc /w \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                    textBox3.Text = output;
                }
                else
                {
                    MessageBox.Show("Please select a valid type!");
                }
            }
            else
            {
                String output = "";
                if(comboBox1.SelectedIndex == 0)
                {
                    if(comboBox2.SelectedIndex == 0)
                    {
                        MessageBox.Show("Same type specified! Please select a different type to continue!");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == 1)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /a /l \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if(comboBox2.SelectedIndex == 2)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /a /n \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 3)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /a /b \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 4)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /a /c \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 5)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /a /u \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 6)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /a /w \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid type!");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (comboBox2.SelectedIndex == 1)
                    {
                        MessageBox.Show("Same type specified! Please select a different type to continue!");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /l /a \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /l /n \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 3)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /l /b \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 4)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /l /c \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 5)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /l /u \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 6)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /l /w \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid type!");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    if (comboBox2.SelectedIndex == 2)
                    {
                        MessageBox.Show("Same type specified! Please select a different type to continue!");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /n /a \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /n /l \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 3)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /n /b \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 4)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /n /c \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 5)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /n /u \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 6)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /n /w \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid type!");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    if (comboBox2.SelectedIndex == 3)
                    {
                        MessageBox.Show("Same type specified! Please select a different type to continue!");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /b /a \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /b /l \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /b /n \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 4)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /b /c \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 5)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /b /u \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 6)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /b /w \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid type!");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    if (comboBox2.SelectedIndex == 4)
                    {
                        MessageBox.Show("Same type specified! Please select a different type to continue!");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /c /a \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /c /l \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /c /n \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 3)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /c /b \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 5)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /c /u \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 6)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /c /w \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid type!");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    if (comboBox2.SelectedIndex == 5)
                    {
                        MessageBox.Show("Same type specified! Please select a different type to continue!");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /u /a \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /u /l \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /u /n \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 3)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /u /b \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 4)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /u /c \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 6)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /u /w \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid type!");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    if (comboBox2.SelectedIndex == 6)
                    {
                        MessageBox.Show("Same type specified! Please select a different type to continue!");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /w /a \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /w /l \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /w /n \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 3)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /w /b \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 4)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /w /c \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else if (comboBox2.SelectedIndex == 5)
                        {
                            output = RunCommands.RunCmdAndGetOutput("fc /w /u \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
                            textBox3.Text = output;
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid type!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid type!");
                }
            }
        }

        private void CompareFiles_Load(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox2.Enabled = false;
            label4.Visible = false;
        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT Files|*.txt";
            openFileDialog.InitialDirectory = filepath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT Files|*.txt";
            openFileDialog.InitialDirectory = filepath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog.FileName;
            }
        }

        private string multiselect()
        {
            String additional = "";
            if (comboBox2.SelectedIndex == 0)
            {
                additional = "/a";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                additional = "/l";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                additional =  "/n";
            }
            else if (comboBox2.SelectedIndex == 3)
            {
               additional = "/b";
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                additional = "/c";
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                additional = "/u";
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                additional = "/w";
            }
            else
            {
                MessageBox.Show("Please select a valid type!");
            }
            return additional;
        }
    }
}
