using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public class Observer1 : IObserver
    {
        Label stateString;

        public Observer1(ref Label stateString)
        {
            this.stateString = stateString; 
        }

        public void Update(string state)
        {
            stateString.Text = "Observer #1: " + state;
        }
    }
}
