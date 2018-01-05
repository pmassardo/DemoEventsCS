namespace DemoEventsCS
{
    partial class frmDemoEventsCS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.DemoTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbLabelDemonstrator = new System.Windows.Forms.Label();
            this.tbTextBoxDemonstrator = new System.Windows.Forms.TextBox();
            this.lbEvent = new System.Windows.Forms.Label();
            this.lblEventOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(141, 30);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(82, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            this.btnEnter.MouseHover += new System.EventHandler(this.btnEnter_MouseHover);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(117, 266);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(199, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbLabelDemonstrator
            // 
            this.lbLabelDemonstrator.Location = new System.Drawing.Point(55, 7);
            this.lbLabelDemonstrator.Name = "lbLabelDemonstrator";
            this.lbLabelDemonstrator.Size = new System.Drawing.Size(80, 20);
            this.lbLabelDemonstrator.TabIndex = 0;
            this.lbLabelDemonstrator.Text = "&Demonstrator";
            this.lbLabelDemonstrator.Click += new System.EventHandler(this.lbLabelDemonstrator_Click);
            this.lbLabelDemonstrator.MouseHover += new System.EventHandler(this.lbLabelDemonstrator_MouseHover);
            // 
            // tbTextBoxDemonstrator
            // 
            this.tbTextBoxDemonstrator.Location = new System.Drawing.Point(141, 4);
            this.tbTextBoxDemonstrator.Name = "tbTextBoxDemonstrator";
            this.tbTextBoxDemonstrator.Size = new System.Drawing.Size(80, 20);
            this.tbTextBoxDemonstrator.TabIndex = 1;
            this.tbTextBoxDemonstrator.TextChanged += new System.EventHandler(this.tbTextBoxDemonstrator_TextChanged);
            this.tbTextBoxDemonstrator.MouseHover += new System.EventHandler(this.tbTextBoxDemonstrator_MouseHover);
            // 
            // lbEvent
            // 
            this.lbEvent.Location = new System.Drawing.Point(4, 58);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(64, 20);
            this.lbEvent.TabIndex = 3;
            this.lbEvent.Text = "Event Data:";
            // 
            // lblEventOutput
            // 
            this.lblEventOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventOutput.Location = new System.Drawing.Point(5, 78);
            this.lblEventOutput.Name = "lblEventOutput";
            this.lblEventOutput.Size = new System.Drawing.Size(268, 185);
            this.lblEventOutput.TabIndex = 4;
            // 
            // frmDemoEventsCS
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(277, 289);
            this.Controls.Add(this.lblEventOutput);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.tbTextBoxDemonstrator);
            this.Controls.Add(this.lbLabelDemonstrator);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.MaximizeBox = false;
            this.Name = "frmDemoEventsCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c# Events Demonstration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDemoEventsCS_FormClosing);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmDemoEventsCS_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip DemoTip;
        private System.Windows.Forms.Label lbLabelDemonstrator;
        private System.Windows.Forms.TextBox tbTextBoxDemonstrator;
        private System.Windows.Forms.Label lbEvent;
        private System.Windows.Forms.Label lblEventOutput;
    }
}

