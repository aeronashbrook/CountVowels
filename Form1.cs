using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = TextInput.Text;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A' || input[i] == 'e' || input[i] == 'E' ||
                    input[i] == 'i' || input[i] == 'I' || input[i] == 'o' || input[i] == 'O' ||
                    input[i] == 'u' || input[i] == 'U')
                {
                    count++;
                }
            }
            TextCount.Text = count.ToString();
        }
        private void textChange(object sender, EventArgs e)
        {
            TextCount.Text = "";
        }
    }
}
