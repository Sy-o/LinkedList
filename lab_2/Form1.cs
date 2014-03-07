using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        LinkedList list = new LinkedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBut_Click(object sender, EventArgs e)
        {
            if (inputItemBox.Text != null)
            {
                list.Add(inputItemBox.Text);
            }
            else
                MessageBox.Show("Enter item!");
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            if (inputItemBox.Text != null)
            {
                list.Delete(inputItemBox.Text);
            }
            else
                MessageBox.Show("Enter item!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] itemList = list.Map();
            string text = "";
            foreach (string s in itemList)
                text += s + "\r\n";
            viewBox.Text = text;
        }
    }
}
