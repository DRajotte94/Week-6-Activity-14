using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6_Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (textBox.TextLength > 0) // checks that the textbox has anything in it to edit
            {
                // sets the font size for text (listbox)
                int[] sizes = { 10, 12, 14, 16, 18, 20 }; // array of sizes
                textBox.Font = new Font("Microsoft Sans Serif", sizes[fontSize.SelectedIndex]);

                // selects the color for the text (radio buttons)
                if (Red.Checked)
                {
                    textBox.ForeColor = Color.Red;
                }
                else if (Blue.Checked)
                {
                    textBox.ForeColor = Color.Blue;
                }
                else if (Green.Checked)
                {
                    textBox.ForeColor = Color.Green;
                }
                else
                {
                    textBox.ForeColor = Color.Black;
                }

                // sets the effects on the text (check boxes)
                FontStyle style = FontStyle.Regular;
                if (checkBold.Checked)
                {
                    style = style | FontStyle.Bold;
                }
                if (checkItalic.Checked)
                {
                    style = style | FontStyle.Italic;
                }
                if (checkUnder.Checked)
                {
                    style = style | FontStyle.Underline;
                }

                textBox.Font = new Font(textBox.Font, style);
            } 
            else
            {
                MessageBox.Show("Please enter anything in the text box");
            }
        }

        // resets everything back to default positions
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBox.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            textBox.ForeColor = Color.Black;
        }
    }
}
