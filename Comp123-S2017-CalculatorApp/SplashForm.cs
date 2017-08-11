using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Khim Tang
 * StudentID: 300920672
 * Date: August 11. 2017
 * Description: This is the SplashForm class
 * Version: 0.2 - Created the SplashFormTimer_Tick event handler
*/

namespace Comp123_S2017_CalculatorApp
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            CalculatorForm calculatorform = new CalculatorForm();
            calculatorform.Show();
            this.Hide();

            SplashFormTimer.Enabled = false;// this turns timer off
        }
    }
}
