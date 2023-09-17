namespace SimpleCalculator
{
    partial class SimpleCalculatorForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Operand1Label = new System.Windows.Forms.Label();
            this.Operator2Label = new System.Windows.Forms.Label();
            this.Operand2Label = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.Operand1Textbox = new System.Windows.Forms.TextBox();
            this.OperatorTextbox = new System.Windows.Forms.TextBox();
            this.Operand2Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(55, 218);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(156, 218);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Operand1Label
            // 
            this.Operand1Label.AutoSize = true;
            this.Operand1Label.Location = new System.Drawing.Point(38, 44);
            this.Operand1Label.Name = "Operand1Label";
            this.Operand1Label.Size = new System.Drawing.Size(57, 13);
            this.Operand1Label.TabIndex = 2;
            this.Operand1Label.Text = "Operand 1";
            // 
            // Operator2Label
            // 
            this.Operator2Label.AutoSize = true;
            this.Operator2Label.Location = new System.Drawing.Point(38, 80);
            this.Operator2Label.Name = "Operator2Label";
            this.Operator2Label.Size = new System.Drawing.Size(48, 13);
            this.Operator2Label.TabIndex = 3;
            this.Operator2Label.Text = "Operator";
            // 
            // Operand2Label
            // 
            this.Operand2Label.AutoSize = true;
            this.Operand2Label.Location = new System.Drawing.Point(38, 114);
            this.Operand2Label.Name = "Operand2Label";
            this.Operand2Label.Size = new System.Drawing.Size(57, 13);
            this.Operand2Label.TabIndex = 4;
            this.Operand2Label.Text = "Operand 2";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(38, 154);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Result";
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(156, 154);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.ReadOnly = true;
            this.ResultTextbox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextbox.TabIndex = 6;
            // 
            // Operand1Textbox
            // 
            this.Operand1Textbox.Location = new System.Drawing.Point(156, 44);
            this.Operand1Textbox.Name = "Operand1Textbox";
            this.Operand1Textbox.Size = new System.Drawing.Size(100, 20);
            this.Operand1Textbox.TabIndex = 7;
            this.Operand1Textbox.TextChanged += new System.EventHandler(this.Operand1Textbox_TextChanged);
            // 
            // OperatorTextbox
            // 
            this.OperatorTextbox.Location = new System.Drawing.Point(156, 80);
            this.OperatorTextbox.Name = "OperatorTextbox";
            this.OperatorTextbox.Size = new System.Drawing.Size(100, 20);
            this.OperatorTextbox.TabIndex = 8;
            this.OperatorTextbox.TextChanged += new System.EventHandler(this.OperatorTextbox_TextChanged);
            // 
            // Operand2Textbox
            // 
            this.Operand2Textbox.Location = new System.Drawing.Point(156, 114);
            this.Operand2Textbox.Name = "Operand2Textbox";
            this.Operand2Textbox.Size = new System.Drawing.Size(100, 20);
            this.Operand2Textbox.TabIndex = 9;
            this.Operand2Textbox.TextChanged += new System.EventHandler(this.Operand2Textbox_TextChanged);
            // 
            // SimpleCalculatorForm
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Operand2Textbox);
            this.Controls.Add(this.OperatorTextbox);
            this.Controls.Add(this.Operand1Textbox);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Operand2Label);
            this.Controls.Add(this.Operator2Label);
            this.Controls.Add(this.Operand1Label);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "SimpleCalculatorForm";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Operand1Label;
        private System.Windows.Forms.Label Operator2Label;
        private System.Windows.Forms.Label Operand2Label;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.TextBox Operand1Textbox;
        private System.Windows.Forms.TextBox OperatorTextbox;
        private System.Windows.Forms.TextBox Operand2Textbox;
    }
}

