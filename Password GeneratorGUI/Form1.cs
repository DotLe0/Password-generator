using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Password_GeneratorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<char> letters = new List<char>() { 'a','b','c','d','e','f','g','h','i','j','k','l','m',
                                                'n','o','p','q','r','s','t','u','v','w','x','y','z'};
        List<char> cpitalLetters = new List<char>() { 'A','B','C','D','E','F','G','H','I','J','K','L','M',
                                                      'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        List<char> symbols = new List<char>() { '!', '@', '#', '$', '%', '&' };
        List<char> numbers = new List<char>() { '1','2','3','4','5','6','7','8','9'};
        Random rng = new Random();
        private void bnt_Generate_Click(object sender, EventArgs e)
        {
            List<char> combo = new List<char>();

            if (chb_lower.Checked)
            {
                combo.AddRange(letters);
            }
            if (chb_capital.Checked)
            {
                combo.AddRange(cpitalLetters);
            }
            if (chb_symbols.Checked)
            {
                combo.AddRange(symbols);
            }
            if (chb_nums.Checked)
            {
                combo.AddRange(numbers);
            }

            List<char> output = new List<char>();

            int check = 0;
            for (int i = 0; i < combo.Count; i++)
            {
                int n = rng.Next(0,combo.Count);
                output.Add(combo[n]);
                check++;
                if (check == int.Parse(txtb_lenght.Text))
                {
                    break;
                }
            }
            txtb_output.Text = string.Join(" ", output);
        }
    }
}
