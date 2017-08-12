﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Khim Tang
 * StudentID: 300920672
 * Date: August 10. 2017
 * Description: Calculator Demo project 
 * Version: 0.4 - Created a shared event handler for the Operator Buttons 
*/

namespace Comp123_S2017_CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();// terminate the application
        }
        /// <summary>
        /// This is shared event handler for the Calculator Buttons
        /// not including the Opertor Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button calculatorButton = sender as Button; // this is call downcasting

            ResultTextBox.Text += calculatorButton.Text;

           // Debug.WriteLine("A Calculator Button was Clicked");//This must include a class by picking using System.Diagnostics;
        }
        /// <summary>
        /// This is a shared event handler for the Operator Buttons of the caculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
