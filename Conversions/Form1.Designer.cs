namespace Conversions
{
    partial class Form1
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
            this.lblCalculatedLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblToLength = new System.Windows.Forms.Label();
            this.lblFromLength = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cboConversions = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalculatedLength
            // 
            this.lblCalculatedLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalculatedLength.Location = new System.Drawing.Point(172, 140);
            this.lblCalculatedLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCalculatedLength.Name = "lblCalculatedLength";
            this.lblCalculatedLength.Size = new System.Drawing.Size(176, 37);
            this.lblCalculatedLength.TabIndex = 30;
            this.lblCalculatedLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(172, 81);
            this.txtLength.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(173, 29);
            this.txtLength.TabIndex = 25;
            // 
            // lblToLength
            // 
            this.lblToLength.Location = new System.Drawing.Point(26, 140);
            this.lblToLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblToLength.Name = "lblToLength";
            this.lblToLength.Size = new System.Drawing.Size(132, 42);
            this.lblToLength.TabIndex = 29;
            this.lblToLength.Text = "Kilometers:";
            this.lblToLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFromLength
            // 
            this.lblFromLength.Location = new System.Drawing.Point(26, 81);
            this.lblFromLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFromLength.Name = "lblFromLength";
            this.lblFromLength.Size = new System.Drawing.Size(132, 42);
            this.lblFromLength.TabIndex = 28;
            this.lblFromLength.Text = "Miles:";
            this.lblFromLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.CausesValidation = false;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(290, 214);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 42);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(55, 214);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 42);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cboConversions
            // 
            this.cboConversions.DropDownWidth = 160;
            this.cboConversions.Location = new System.Drawing.Point(172, 22);
            this.cboConversions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboConversions.Name = "cboConversions";
            this.cboConversions.Size = new System.Drawing.Size(261, 32);
            this.cboConversions.TabIndex = 24;
            this.cboConversions.SelectedIndexChanged += new System.EventHandler(this.cboConversions_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(26, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(132, 42);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Conversion:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(479, 286);
            this.Controls.Add(this.lblCalculatedLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblToLength);
            this.Controls.Add(this.lblFromLength);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cboConversions);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblCalculatedLength;
        internal System.Windows.Forms.TextBox txtLength;
        internal System.Windows.Forms.Label lblToLength;
        internal System.Windows.Forms.Label lblFromLength;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.ComboBox cboConversions;
        internal System.Windows.Forms.Label Label1;
    }
}

