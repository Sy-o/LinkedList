using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    class Observer2: IObserver
    {
        LinkedList list;
        TextBox textBox;

        public Observer2(ref TextBox textBox, ref LinkedList list)
        {
            this.textBox = textBox;
            this.list = list;
        }

        public void Update(string state)
        {
            View(state);
        }

        private void View(string state)
        {
            string[] itemList = list.Map();
            string text = "";
            foreach (string s in itemList)
                text += s + "\r\n";
            textBox.Text = "Observer #2: \r\n" + state + "\r\n------------------\r\n";
            textBox.Text += text;
        }
    }
}
