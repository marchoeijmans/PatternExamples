using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverExample
{
    public partial class Form1 : Form, IObserver
    {
        private Controller controller;
        
        public Form1()
        {
            InitializeComponent();
            this.controller = new Controller();
            this.controller.RegisterObserver(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this .controller.DoIt(textBox1.Text);
        }

        public void Update(object newData)
        {
            textBox2.Text = (string)newData;
        }
    }
}
