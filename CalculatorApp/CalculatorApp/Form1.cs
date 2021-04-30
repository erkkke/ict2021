﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        BusinessLogic businessLogic;
        public Form1()
        {
            InitializeComponent();
            DisplayMessage displayMessage = new DisplayMessage(SetDisplayMessage);
            businessLogic = new BusinessLogic(displayMessage);
        }

        void SetDisplayMessage(string text)
        {
            textBox1.Text = text;
        }

        void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            businessLogic.ProcessSignal(button.Text);
        }
    }
}
