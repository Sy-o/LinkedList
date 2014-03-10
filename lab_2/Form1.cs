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
        LinkedList list;
        IObserver observer1, observer2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            observer1label.Text = "";
            list = new LinkedList();
            observer1 = new Observer1(ref observer1label);
            observer2 = new Observer2(ref viewBox, ref list);
            list.AddObserver(observer1);
            list.AddObserver(observer2);
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
    }
}
