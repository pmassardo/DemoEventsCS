using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEventsCS
{
    /// <summary>
    /// Name:           DemoEventsCS
    /// Author:         Alfred Masardo
    /// Date:           01-Jan-2018
    /// Description:    Demostrate some events and the data they produce.
    /// </summary>
    public partial class frmDemoEventsCS : Form
    {
        public frmDemoEventsCS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// lbLabelDemonstrator_Click - Event that happens when the sender control is clicked, in this case a Label.
        ///                - Displays event data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbLabelDemonstrator_Click(object sender, EventArgs e)
        {

            // sender is the control that has
            Label control = (Label)sender;

            // How the event was fired like... 
            //      * Which mouse button was pressed. 
            //      * How many clicks. 
            //      * X coordinate of the mouse
            //      * Y coordinate of the mouse
            MouseEventArgs eventArguments = (MouseEventArgs)e;

            // Display the event data
            lblEventOutput.Text = "Event Handler: lbLabelDemonstrator_Click\n" +
                                    "Event: Click\n" +
                                    "Control: " + control.Name.ToString() + "\n" +
                                    "Control Data: " + control.Text + "\n" +
                                    "Mouse Button Clicked: " + eventArguments.Button + "\n" +
                                    "# Of Clicks: " + eventArguments.Clicks.ToString() + "\n" +
                                    "X Coordinates: " + eventArguments.X.ToString() + "\n" +
                                    "Y Coordinates: " + eventArguments.Y.ToString();
        }

        /// <summary>
        /// lbLabelDemonstrator_MouseHover - Event that happens when the mouse hovers over the sender control, in this case a Label.
        ///                                 - Displays event data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbLabelDemonstrator_MouseHover(object sender, EventArgs e)
        {

            // sender is the control that is 
            // sending the event
            Label control = (Label)sender;

            // Other Event arguments do not pass anything

            // Display the event data
            lblEventOutput.Text = "Event Handler: lbLabelDemonstrator_MouseHover\n" +
                                    "Event: MouseHover\n" +
                                    "Control: " + control.Name.ToString() + "\n" +
                                    "Control Data: " + control.Text + "\n";


        }

        /// <summary>
        /// tbTextBoxDemonstrator_TextChanged - Event that happens when the Text property of the sender control, in this case a TextBox, is changed.
        ///                                     - Displays event data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTextBoxDemonstrator_TextChanged(object sender, EventArgs e)
        {

            // sender is the control that is 
            // sending the event
            TextBox control = (TextBox)sender;

            // Other Event arguments do not pass anything

            // Display the event data
            lblEventOutput.Text = "Event Handler: tbTextBoxDemonstrator_TextChanged\n" +
                                    "Event: TextChanged\n" +
                                    "Control: " + control.Name.ToString() + "\n" +
                                    "Control Data: " + control.Text + "\n";

        }

        /// <summary>
        /// tbTextBoxDemonstrator_MouseHover - Event that happens when the mouse hovers over the sender control, in this case a TextBox.
        ///                                 - Displays event data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTextBoxDemonstrator_MouseHover(object sender, EventArgs e)
        {
            // sender is the control that is 
            // sending the event
            TextBox control = (TextBox)sender;

            // Other Event arguments do not pass anything

            lblEventOutput.Text = "Event Handler: tbTextBoxDemonstrator_MouseHover\n" +
                                    "Event: MouseHover\n" +
                                    "Control: " + control.Name.ToString() + "\n" +
                                    "Control Data: " + control.Text + "\n";
        }

        /// <summary>
        /// btnEnter_Click - Event that happens when the sender control is clicked, in this case a Button.
        ///                - Displays event data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // sender is the control that has
            Button control = (Button)sender;

            //// How the event was fired like... 
            ////      * Which mouse button was pressed. 
            ////      * How many clicks. 
            ////      * X coordinate of the mouse
            ////      * Y coordinate of the mouse

            // If it was a mouse click
            if (e is MouseEventArgs)
            {

                // get the Mouse Events
                MouseEventArgs eventArguments = (MouseEventArgs)e;

                // Display the event data
                lblEventOutput.Text = "Event Handler: btnEnter_Click\n" +
                                        "Event: MouseDoubleClick\n" +
                                        "Control: " + control.Name.ToString() + "\n" +
                                        "Control Data: " + control.Text + "\n" +
                                        "Mouse Button Clicked: " + eventArguments.Button + "\n" +
                                        "# Of Clicks: " + eventArguments.Clicks.ToString() + "\n" +
                                        "X Coordinates: " + eventArguments.X.ToString() + "\n" +
                                        "Y Coordinates: " + eventArguments.Y.ToString();
            }
            else // if the user tabbed to the button and click Enter
            {

                // since a mouse was not used there are no mouse events

                // Display the event data
                lblEventOutput.Text = "Event Handler: btnEnter_Click\n" +
                                        "Event: Click\n" +
                                        "Control: " + control.Name.ToString() + "\n" +
                                        "Control Data: " + control.Text + "\n";
            }
        }

        /// <summary>
        /// btnEnter_MouseHover - Event that happens when the mouse hovers over the sender control, in this case a Button.
        ///                     - Displays event data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_MouseHover(object sender, EventArgs e)
        {
            // sender is the control that is 
            // sending the event
            Button control = (Button)sender;

            // Other Event arguments do not pass anything

            // Display the event data
            lblEventOutput.Text = "Event Handler: btnEnter_MouseHover\n" +
                                    "Event: MouseHover\n" +
                                    "Control: " + control.Name.ToString() + "\n" +
                                    "Control Data: " + control.Text + "\n";
        }

        /// <summary>
        /// btnReset_Click - Event that happens when the sender control is clicked, in this case a Button.
        ///                - Clears the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {

            // loop through the controls on the form
            foreach (Control control in this.Controls)
            {

                if (control is TextBox) // if the control is a TextBox
                {
                    // empty the TextBox
                    control.Text = string.Empty;
                }
                else if (control is Label) // if the control is a Label
                {
                    // output controls are set to have their BorderStyle
                    // set to 3D, so if the label is set to have its 
                    // BorderStyle set to Fixed3D 
                    if (((Label)control).BorderStyle == BorderStyle.Fixed3D)
                    {
                        // empty the TextBox
                        control.Text = string.Empty;
                    }
                }
            }


        }

        /// <summary>
        /// btnExit_Click - Event that happens when the sender control is clicked, in this case a Button.
        ///               - Commences the process of closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the form
            this.Close();
        }

        /// <summary>
        /// frmDemoEventsCS_FormClosing - Event that happens just prior to the form actually closing.
        ///                             - Checks to see if the user actually wants to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDemoEventsCS_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Get the results from the MessageBox
            DialogResult resultOne = MessageBox.Show("Are you sure you wish you would like to close the form?", "Form Close", MessageBoxButtons.YesNo);

            // If the user selected No
            if (resultOne == DialogResult.No)
            {
                // Then Cancel the Closing of the form
                e.Cancel = true;

            }
            else
            {
                // Get the results from the MessageBox
                DialogResult resultTwo = MessageBox.Show("Really? You don't like me, FINE!", "Form Close", MessageBoxButtons.YesNo);

                // If the user selected No
                if (resultTwo == DialogResult.No)
                {
                    // Then Cancel the Closing of the form
                    e.Cancel = true;
                }
            }

        }

        /// <summary>
        /// frmDemoEventsCS_MouseDoubleClick - Event that happens when the sender control (Form) is double clicked.
        ///                - Displays event data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDemoEventsCS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // sender is the control that has
            Form control = (Form)sender;

            //// How the event was fired like... 
            ////      * Which mouse button was pressed. 
            ////      * How many clicks. 
            ////      * X coordinate of the mouse
            ////      * Y coordinate of the mouse
            MouseEventArgs eventArguments = e;

            // Display the event data
            lblEventOutput.Text = "Event Handler: frmDemoEventsCS_MouseDoubleClick\n" +
                                    "Event: MouseDoubleClick\n" +
                                    "Control: " + control.Name.ToString() + "\n" +
                                    "Control Data: " + control.Text + "\n" +
                                    "Mouse Button Clicked: " + eventArguments.Button + "\n" +
                                    "# Of Clicks: " + eventArguments.Clicks.ToString() + "\n" +
                                    "X Coordinates: " + eventArguments.X.ToString() + "\n" +
                                    "Y Coordinates: " + eventArguments.Y.ToString();
        }
    }
}
