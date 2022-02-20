using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace SciCalcZillaLib
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UserControl1: UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UserControl1()
        {
            InitializeComponent();

            // Set the initial values for base modes.
            isBinary = false;
            isDecimal = true;
            isHexadecimal = false;

            // Set other bases to false.
            disableHexButtons();

            listView1.View = View.Details;

            // Set Full Row Select to true so we can populate just one column.
            listView1.FullRowSelect = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }


        /**********************************************************************
         * Region for numbers Zero to Nine.                                   *
         *********************************************************************/
        #region     
        /// <summary>
        /// Event handler for the number "0" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberZeroButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 0;
        }

        /// <summary>
        /// Event handler for the number "1" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberOneButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 1;
        }

        /// <summary>
        /// Event handler for the number "2" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 2;
        }

        /// <summary>
        /// Event handler for the number "3" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 3;
        }

        /// <summary>
        /// Event handler for the number "4" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberFourButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 4;
        }

        /// <summary>
        /// Event handler for the number "5" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 5;
        }

        /// <summary>
        /// Event handler for the number "6" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberSixButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 6;
        }

        /// <summary>
        /// Event handler for the number "7" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 7;
        }

        /// <summary>
        /// Event handler for the number "8" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberEightButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 8;
        }

        /// <summary>
        /// Event handler for the number "9" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberNineButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + 9;
        }
        #endregion


        /**********************************************************************
         * Region for Hexidecimal numbers A to F.                             *
         *********************************************************************/
        #region
        /// <summary>
        /// Event handler for the number "A" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexAButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + "A";
        }

        /// <summary>
        /// Event handler for the number "B" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexBButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + "B";
        }

        /// <summary>
        /// Event handler for the number "C" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexCButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + "C";
        }

        /// <summary>
        /// Event handler for the number "D" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexDButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + "D";
        }

        /// <summary>
        /// Event handler for the number "E" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexEButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + "E";
        }

        /// <summary>
        /// Event handler for the number "F" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexFButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = inputTextbox.Text + "F";
        }
        #endregion


        /**********************************************************************
         * Region for basic calculator panel operations.                      *
         *********************************************************************/
        #region
        /// <summary>
        /// Event handler for the Addition operation "+" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void additionButton_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = float.Parse(inputTextbox.Text);
                operation = 2;
            }
            catch (FormatException ex)
            {
                string newRow = ""; newRow = "Invalid Input - Enter operand before " +
                    "operation/function Addition '+'";
                // Update the list with a new row containing Invalid Input message.
                UpdateListView(newRow);
                operation = 0;
               
            }
            inputTextbox.Focus();
            inputTextbox.Clear();
        }

        /// <summary>
        /// Event handler for the Subtraction operation "-" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void subtractionButton_Click(object sender, EventArgs e)
        {
            try
            { 
                number1 = float.Parse(inputTextbox.Text);
                operation = 1;
            }
            catch (FormatException ex)
            {
                string newRow = ""; newRow = "Invalid Input - Enter operand before " +
                    "operation/function Subraction '-'";
                // Update the list with a new row containing Invalid Input message.
                UpdateListView(newRow);
                operation = 0;
            }
            inputTextbox.Focus();
            inputTextbox.Clear();
        }

        /// <summary>
        /// Event handler for the Multiplication operation "*" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = float.Parse(inputTextbox.Text);
                operation = 3;
            }
            catch (FormatException ex)
            {
                string newRow = ""; newRow = "Invalid Input - Enter operand before " +
                    "operation/function Multipliication '*'";
                // Update the list with a new row containing Invalid Input message.
                UpdateListView(newRow);
                operation = 0;
            }
            inputTextbox.Focus();
            inputTextbox.Clear();
        }

        /// <summary>
        /// Event handler for the Division operation "/" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void divisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = float.Parse(inputTextbox.Text);
                operation = 4;
            }
            catch (FormatException ex)
            {
                string newRow = ""; newRow = "Invalid Input - Enter operand before " +
                    "operation/function Division '/'";
                // Update the list with a new row containing Invalid Input message.
                UpdateListView(newRow);
                operation = 0;
            }
            inputTextbox.Focus();
            inputTextbox.Clear();
        }

        /// <summary>
        /// Event handler for the Equals operation "=" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (isDecimal == true)
            {
                computeDecimalOperations(operation);
            }
            else if(isHexadecimal == true)
            {
                computeHexadecimalOperations(operation);
            }
            else if(isBinary == true)
            {
                computeBinaryOperations(operation);
            }
        }

        /// <summary>
        /// Event handler for the Decimal "." button.  This method will add 
        /// a decimal point to the number that is being input by the user.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void decimalButton_Click(object sender, EventArgs e)
        {
            /* Verify if the number contains a '.'.  If it doesn't contain 
             * a decimal then append it to the end of the string.  If a
             * '.' aleady exists the input is ignored.
             */
            if (!inputTextbox.Text.Contains('.'))
            {
                inputTextbox.Text = inputTextbox.Text + ".";
            }
        }

        /// <summary>
        /// Event handler for the Change Sign operation "+/-" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void changSignButton_Click(object sender, EventArgs e)
        {
            // We the multiply the value by -1.
            answer = -1 * float.Parse(inputTextbox.Text);
            inputTextbox.Text = answer.ToString();
        }

        /// <summary>
        /// Event handler for the Square Root operation button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void squareRootButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Percentage operation "&" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void percentButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Reciprocal operation "1/x" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void reciprocalButton_Click(object sender, EventArgs e)
        {

        }
        #endregion


        /**********************************************************************
         * Region for all other operations.                                   *
         *********************************************************************/
        #region
        /// <summary>
        /// Event handler for the MC operation "MC" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void mcButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the MR operation "MR" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void mrButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the MS operation "MS" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void msButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the M Plus operation "M+" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void mPlusButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the M Minus operation "M-" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void mMinusButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the backspace operation "BS" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void backspaceButton_Click(object sender, EventArgs e)
        {
            // Get length.
            int length = inputTextbox.TextLength - 1;

            // Store input textbox contents in text.
            string text = inputTextbox.Text;

            // Clear the input textbox's input.
            inputTextbox.Clear();

            // Set input textbox's value to itself minus the latest number.
            for(int i = 0; i < length; i++)
            {
                inputTextbox.Text = inputTextbox.Text + text[i];
            }
        }

        /// <summary>
        /// Event handler for the CE operation "CE" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void ceButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Clear operation "C" button.  This method 
        /// will clear the inputTextbox of its contents.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void cButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Clear();
            operation = 0;
        }
        #endregion

        /// <summary>
        ///Set binary to true, others to false, and enables other decimal 
        ///buttons and hex buttions if enabled.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void binaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isBinary = true;
            isDecimal = false;
            isHexadecimal = false;

            // Disable un-needed buttons to avoid confusion from the user.
            disableHexButtons();
            disableNonBinaryDigits();

            // Clear the contents of the text box.
            inputTextbox.Clear();
        }

        /// <summary>
        /// This method performs the binary operatons on the operands entered 
        /// into the calculator.
        /// </summary>
        /// <param name="operation">The type of mathematical operation we 
        /// will perform.</param>
        public void computeBinaryOperations(int operation)
        {

        }

        /// <summary>
        /// This method performs the operatons on the operands entered into 
        /// the calculator.
        /// </summary>
        /// <param name="operation">The type of mathematical operation we 
        /// will perform.</param>
        public void computeDecimalOperations(int operation)
        {
            string newRow = "";
            float number2 = 0;
            string sign = "";

            // Try to get numerical input from inputTextbox.Text.
            try
            {
                number2 = float.Parse(inputTextbox.Text);
                switch (operation)
                {
                    case 1:
                        answer = number1 - float.Parse(inputTextbox.Text);
                        inputTextbox.Text = answer.ToString();
                        sign = "-";
                        break;
                    case 2:
                        answer = number1 + float.Parse(inputTextbox.Text);
                        inputTextbox.Text = answer.ToString();
                        sign = "+";
                        break;
                    case 3:
                        answer = number1 * float.Parse(inputTextbox.Text);
                        inputTextbox.Text = answer.ToString();
                        sign = "*";
                        break;
                    case 4:
                        answer = number1 / float.Parse(inputTextbox.Text);
                        inputTextbox.Text = answer.ToString();
                        sign = "/";
                        break;
                    default:
                        break;
                }
                // Create formatted answer for history output
                newRow = number1 + " " + sign + " " + number2 + " = " +
                     answer.ToString();
            }
            // Catch bad input such as having an equals button with no input.
            catch (FormatException err)
            {
                newRow  = "Invalid Input - Enter operand before " +
                    "operation/function '='";
                inputTextbox.Clear();
                operation = 0;
            }

            // Update the list with a new row.
            UpdateListView(newRow);
        }

        /// <summary>
        /// This method performs the hexadecimal operatons on the operands 
        /// entered into the calculator.
        /// </summary>
        /// <param name="operation">The type of mathematical operation we 
        /// will perform.</param>
        public void computeHexadecimalOperations(int operation)
        {

        }

        /// <summary>
        /// Set decimal to true, others to false, and enables decimal buttons.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void decimalRadioButton_CheckedChanged(object sender, 
            EventArgs e)
        {
            isBinary = false;
            isDecimal = true;
            isHexadecimal = false;

            // Disable these buttons to avoid confusion.
            disableHexButtons();

            // Ensure required buttons are enabled.
            enableNonBinaryDigits();
            // Clear the contents of the text box.
            inputTextbox.Clear();
        }
        
        /// <summary>
        /// Enable the A-F hexadecimal buttons.
        /// </summary>
        private void disableHexButtons()
        {
            hexAButton.Enabled = false;
            hexBButton.Enabled = false;
            hexCButton.Enabled = false;
            hexDButton.Enabled = false;
            hexEButton.Enabled = false;
            hexFButton.Enabled = false;
        }

        /// <summary>
        /// Disable buttons for non-binary base 10 digits.
        /// </summary>
        private void disableNonBinaryDigits()
        {
            numberTwoButton.Enabled = false;
            numberThreeButton.Enabled = false;
            numberFourButton.Enabled = false;
            numberFiveButton.Enabled = false;
            numberSixButton.Enabled = false;
            numberSevenButton.Enabled = false;
            numberEightButton.Enabled = false;
            numberNineButton.Enabled = false;
        }

        /// <summary>
        /// Disable the A-F hexadecimal buttons.
        /// </summary>
        private void enableHexButtons()
        {
            hexAButton.Enabled ^= true;
            hexBButton.Enabled ^= true;
            hexCButton.Enabled ^= true;
            hexDButton.Enabled ^= true;
            hexEButton.Enabled ^= true;
            hexFButton.Enabled ^= true;
        }


        /// <summary>
        /// Enable buttons for non-binary base 10 digits.
        /// </summary>
        private void enableNonBinaryDigits()
        {
            numberTwoButton.Enabled ^= true;
            numberThreeButton.Enabled ^= true;
            numberFourButton.Enabled ^= true;
            numberFiveButton.Enabled ^= true;
            numberSixButton.Enabled ^= true;
            numberSevenButton.Enabled ^= true;
            numberEightButton.Enabled ^= true;
            numberNineButton.Enabled ^= true;
        }

        /// <summary>
        /// Set hexadecimal to true, others to false, and enables hexadecimal 
        /// buttons.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArg object.</param>
        private void hexaecimalRadioButton_CheckedChanged(object sender, 
            EventArgs e)
        {
            // Enable the required buttons for this mode.
            enableHexButtons();

            /*
             * Ensure these buttons are also enabled if previous mode is
             * binary.
             */
            enableNonBinaryDigits();
            isBinary = false;
            isDecimal = false;
            isHexadecimal = true;

            // Clear the contents of the text box.
            inputTextbox.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled= true;
            }
        }

        /// <summary>
        /// Updates instance variable listView1 with new row that represents 
        /// a string for the new row.
        /// </summary>
        /// <param name="newHistoryRowItem">Formatted string that will be
        /// added to listVie1.</param>
        private void UpdateListView(string newHistoryRowItem)
        {
            // Create new row for ListViewItem
            string[] row = { newHistoryRowItem };
            ListViewItem item = new ListViewItem(row);

            // Insert new item at the top.
            listView1.Items.Insert(0, item);
        }

 
        /**********************************************************************
         * INSTANCE VARIABLES.                                                *
         *********************************************************************/
        float answer;
        bool isBinary;
        bool isDecimal;
        bool isHexadecimal;
        int operation;
        float number1;


       public enum Op
        {
            add = 2,
            sub = 1,
            mult = 3,
            div = 4,
            noOp = 0
        }
        
    }
}
