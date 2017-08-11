using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Khim Tang
 * StudentID: 300920672
 * Date: August 10. 2017
 * Description: Calculator Demo project showcase windows forms and UI Controls
 * Version: 0.3 - Created an instance of the calculatorForm object
*/

namespace Comp123_S2017_CalculatorApp
{
    public static class Program
    {
        //Create Reference to Forms
        public static CalculatorForm calculatorForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            calculatorForm = new CalculatorForm();// this is where i instantiate new object of type CalculatorForm
            Application.Run(new SplashForm());
        }
    }
}
