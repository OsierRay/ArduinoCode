using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace cSharpToArduinoForm
{
    public partial class Form1 : Form
    {
        bool ledState = false;
        public Form1()
        {
            InitializeComponent();

            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            textBox1.Text = "LED is on!";
            button1.Enabled = false;
            button2.Enabled = true;
            ledState = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            textBox1.Text = "LED is off!";
            button1.Enabled = true;
            button2.Enabled = false;
            ledState = false;
        }
    }
}
