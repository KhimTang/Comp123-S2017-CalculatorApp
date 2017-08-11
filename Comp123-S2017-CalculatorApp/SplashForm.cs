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
 * Version: 0.4 - Created a Public Property as an Alias to Program.calculatorForm
*/

namespace Comp123_S2017_CalculatorApp
{
    public partial class SplashForm : Form
    {
        // PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++++
        //private CalculatorForm _calculatorForm; // this is reference type for new object

        // PUBLIC PROPERTIES

        public CalculatorForm CalculatorForm { get { return Program.calculatorForm; } }// does not need a setter
        // CONSTRUCTORS++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the main constructor for the SplashForm
        /// </summary>

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
            
            this.CalculatorForm.Show();
            this.Hide();

            SplashFormTimer.Enabled = false;// this turns timer off
        }
    }
}
