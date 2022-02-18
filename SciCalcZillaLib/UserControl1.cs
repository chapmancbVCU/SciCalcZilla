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

            listView1.View = View.Details;

            // Set Full Row Select to true so we can populate just one column.
            listView1.FullRowSelect = true;
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
            textBox1.Text = textBox1.Text + 0;
        }

        /// <summary>
        /// Event handler for the number "1" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberOneButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        /// <summary>
        /// Event handler for the number "2" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        /// <summary>
        /// Event handler for the number "3" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        /// <summary>
        /// Event handler for the number "4" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberFourButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        /// <summary>
        /// Event handler for the number "5" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        /// <summary>
        /// Event handler for the number "6" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberSixButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        /// <summary>
        /// Event handler for the number "7" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        /// <summary>
        /// Event handler for the number "8" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberEightButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        /// <summary>
        /// Event handler for the number "9" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void numberNineButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
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
            textBox1.Text = textBox1.Text + "A";
        }

        /// <summary>
        /// Event handler for the number "B" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexBButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "B";
        }

        /// <summary>
        /// Event handler for the number "C" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexCButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "C";
        }

        /// <summary>
        /// Event handler for the number "D" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexDButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "D";
        }

        /// <summary>
        /// Event handler for the number "E" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexEButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "E";
        }

        /// <summary>
        /// Event handler for the number "F" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void hexFButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "F";
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

        }

        /// <summary>
        /// Event handler for the Subtraction operation "-" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void subtractionButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Multiplication operation "*" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void multiplicationButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Division operation "/" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void divisionButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Equals operation "=" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void equalsButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Decimal "." button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void decimalButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Change Sign operation "+/-" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void changSignButton_Click(object sender, EventArgs e)
        {

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
        /// Event handler for the Clear operation "C" button.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">EventArgs object.</param>
        private void cButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        // INSTANCE VARIABLES.
        string answer;
        int operation;
        string number1;
    }
}
