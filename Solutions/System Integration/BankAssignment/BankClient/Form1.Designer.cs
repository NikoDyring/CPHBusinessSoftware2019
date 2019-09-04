namespace BankClient
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
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.FundsLabel = new System.Windows.Forms.Label();
            this.fundsValue = new System.Windows.Forms.Label();
            this.accountNoTextbox = new System.Windows.Forms.TextBox();
            this.fundsInput = new System.Windows.Forms.TextBox();
            this.checkBalance_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(46, 182);
            this.DepositButton.Margin = new System.Windows.Forms.Padding(2);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(83, 38);
            this.DepositButton.TabIndex = 1;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(133, 182);
            this.WithdrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(83, 38);
            this.WithdrawButton.TabIndex = 2;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(44, 27);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Account No";
            // 
            // FundsLabel
            // 
            this.FundsLabel.AutoSize = true;
            this.FundsLabel.Location = new System.Drawing.Point(44, 55);
            this.FundsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FundsLabel.Name = "FundsLabel";
            this.FundsLabel.Size = new System.Drawing.Size(46, 13);
            this.FundsLabel.TabIndex = 5;
            this.FundsLabel.Text = "Balance";
            // 
            // fundsValue
            // 
            this.fundsValue.AutoSize = true;
            this.fundsValue.Location = new System.Drawing.Point(126, 55);
            this.fundsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fundsValue.Name = "fundsValue";
            this.fundsValue.Size = new System.Drawing.Size(27, 13);
            this.fundsValue.TabIndex = 6;
            this.fundsValue.Text = "N/A";
            // 
            // accountNoTextbox
            // 
            this.accountNoTextbox.Location = new System.Drawing.Point(129, 24);
            this.accountNoTextbox.Name = "accountNoTextbox";
            this.accountNoTextbox.Size = new System.Drawing.Size(100, 20);
            this.accountNoTextbox.TabIndex = 7;
            // 
            // fundsInput
            // 
            this.fundsInput.Location = new System.Drawing.Point(47, 157);
            this.fundsInput.Name = "fundsInput";
            this.fundsInput.Size = new System.Drawing.Size(100, 20);
            this.fundsInput.TabIndex = 8;
            // 
            // checkBalance_button
            // 
            this.checkBalance_button.Location = new System.Drawing.Point(47, 80);
            this.checkBalance_button.Margin = new System.Windows.Forms.Padding(2);
            this.checkBalance_button.Name = "checkBalance_button";
            this.checkBalance_button.Size = new System.Drawing.Size(83, 38);
            this.checkBalance_button.TabIndex = 9;
            this.checkBalance_button.Text = "Check Balance";
            this.checkBalance_button.UseVisualStyleBackColor = true;
            this.checkBalance_button.Click += new System.EventHandler(this.checkBalance_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 518);
            this.Controls.Add(this.checkBalance_button);
            this.Controls.Add(this.fundsInput);
            this.Controls.Add(this.accountNoTextbox);
            this.Controls.Add(this.fundsValue);
            this.Controls.Add(this.FundsLabel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.DepositButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Fake Bank Solutions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label FundsLabel;
        private System.Windows.Forms.Label fundsValue;
        private System.Windows.Forms.TextBox accountNoTextbox;
        private System.Windows.Forms.TextBox fundsInput;
        private System.Windows.Forms.Button checkBalance_button;
    }
}