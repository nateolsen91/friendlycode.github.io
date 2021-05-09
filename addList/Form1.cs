using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addListLecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.One;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pg568
            string[] optionInBox = { "One", "two", "three", "four" };
            for (int x = 0; x < optionInBox.Length; ++x)
                listBox1.Items.Add(optionInBox[x]);
            listBox1.SetSelected(0, true);

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(editTextBox.Text);
            editTextBox.Text = null;
            listBox1.SetSelected(listBox1.Items.Count - 1, true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
                if (listBox1.Items.Count > 0)
                    listBox1.SetSelected(0, true);
                else
                    MessageBox.Show("No items are available in the list");
            }
            else
                MessageBox.Show("The list is empty");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
