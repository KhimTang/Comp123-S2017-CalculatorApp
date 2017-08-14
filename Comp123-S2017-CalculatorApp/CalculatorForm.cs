using System;
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
 * Version: 1.0 - Added the _calculate and _convertOperand Methods
*/

namespace Comp123_S2017_CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _isDecimalClicked;// must have the properties
        private string _currentOperator;
        private List<double> _operandList;

        // PUBLIC PROPERTIES

        public bool IsDecimalClicked { get { return this._isDecimalClicked; } set { this._isDecimalClicked = value; } }
        public string CurrentOperator { get { return this._currentOperator; } set {this._currentOperator=value; } }
        public List<double> OperandList { get {return this._operandList; } set {this._operandList=value; } }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the CalculatorForm class
        /// </summary>
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

            if ((this.IsDecimalClicked) && (calculatorButton.Text == "."))
            {               
                    return;                
            }
            if (calculatorButton.Text == ".")
            {
                this.IsDecimalClicked = true;
            }

            if (ResultTextBox.Text == "0")
            {
                if (calculatorButton.Text ==".")
                {
                    ResultTextBox.Text += calculatorButton.Text;
                }
                else
                {
                    ResultTextBox.Text = calculatorButton.Text;
                }

            }
            else
            {
                ResultTextBox.Text += calculatorButton.Text;
            }
            

            

           // Debug.WriteLine("A Calculator Button was Clicked");//This must include a class by picking using System.Diagnostics;
        }
        /// <summary>
        /// This is a shared event handler for the Operator Buttons of the caculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button; // This is downcasting

            switch (operatorButton.Text)
            {
                case "C":
                    this._clear();
                    break;               

                case "=":
                    break;
                case "⌫":
                    break;
                case "±":
                    break;
                default:
                    this._calculator(ResultTextBox.Text, operatorButton.Text);
                    break;

            }

        }
        /// <summary>
        /// This method calculates the result of all the operands in the OperandList
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>

        private void _calculator(string operandString, string operatorString)
        {
            double operand = this._convertOperand(operandString);           
        }
        /// <summary>
        /// This method converts the string from the ResultTextBox to a number
        /// </summary>
        /// <param name="operandList"></param>
        /// <returns></returns>
        private double _convertOperand(string operandString)
        {
            try
            {
                return Convert.ToDouble(operandString);
            }
            catch (Exception exception)
            {

                Debug.WriteLine("An Error Occured");
                Debug.WriteLine(exception.Message);

            }
            return 0;
           
        }

        /// <summary>
        /// This is the private _clear method. It resets / clears the calculator.
        /// </summary>
        private void _clear()
        {
            this.IsDecimalClicked = false;
            ResultTextBox.Text = "0";
            this.CurrentOperator = "C";
            this.OperandList = new List<double>();
        }

        /// <summary>
        /// This is the event handler for the "Load" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this._clear();
        }
    }
}
