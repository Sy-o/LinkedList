using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

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

        private void DynamicCompile(string textCode)
        {
            var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v3.5" } });
            var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, "foo.exe", true);
            parameters.GenerateExecutable = true;
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, textCode);
            results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));
        }

        private void compileBut_Click(object sender, EventArgs e)
        {
            if (compileBox.Text != null)
            {
                DynamicCompile(@compileBox.Text);
            }
            else
                MessageBox.Show("No code to run!");

        }
    }
}
