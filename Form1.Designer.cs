namespace geradorSenhasC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            numPasswordLength = new NumericUpDown();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnGenerate = new Button();
            txtPassword = new TextBox();
            btnCopy = new Button();
            lblPasswordLength = new Label();
            chkUppercase = new CheckBox();
            chkLowercase = new CheckBox();
            chKNumbers = new CheckBox();
            chKSymbols = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numPasswordLength).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 47);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // numPasswordLength
            // 
            numPasswordLength.Location = new Point(57, 93);
            numPasswordLength.Name = "numPasswordLength";
            numPasswordLength.Size = new Size(120, 23);
            numPasswordLength.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(47, 260);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Gerar";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 334);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(188, 260);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 8;
            btnCopy.Text = "Copia";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // lblPasswordLength
            // 
            lblPasswordLength.AutoSize = true;
            lblPasswordLength.Location = new Point(306, 337);
            lblPasswordLength.Name = "lblPasswordLength";
            lblPasswordLength.Size = new Size(38, 15);
            lblPasswordLength.TabIndex = 9;
            lblPasswordLength.Text = "label2";
            // 
            // chkUppercase
            // 
            chkUppercase.AutoSize = true;
            chkUppercase.Location = new Point(73, 163);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(85, 19);
            chkUppercase.TabIndex = 10;
            chkUppercase.Text = "Maiusculas";
            chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkLowercase
            // 
            chkLowercase.AutoSize = true;
            chkLowercase.Location = new Point(206, 169);
            chkLowercase.Name = "chkLowercase";
            chkLowercase.Size = new Size(86, 19);
            chkLowercase.TabIndex = 11;
            chkLowercase.Text = "Minusculas";
            chkLowercase.UseVisualStyleBackColor = true;
            // 
            // chKNumbers
            // 
            chKNumbers.AutoSize = true;
            chKNumbers.Location = new Point(333, 169);
            chKNumbers.Name = "chKNumbers";
            chKNumbers.Size = new Size(75, 19);
            chKNumbers.TabIndex = 12;
            chKNumbers.Text = "Numeros";
            chKNumbers.UseVisualStyleBackColor = true;
            // 
            // chKSymbols
            // 
            chKSymbols.AutoSize = true;
            chKSymbols.Location = new Point(475, 169);
            chKSymbols.Name = "chKSymbols";
            chKSymbols.Size = new Size(75, 19);
            chKSymbols.TabIndex = 13;
            chKSymbols.Text = "Simbolos";
            chKSymbols.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chKSymbols);
            Controls.Add(chKNumbers);
            Controls.Add(chkLowercase);
            Controls.Add(chkUppercase);
            Controls.Add(lblPasswordLength);
            Controls.Add(btnCopy);
            Controls.Add(txtPassword);
            Controls.Add(btnGenerate);
            Controls.Add(numPasswordLength);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPasswordLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numPasswordLength;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnGenerate;
        private TextBox txtPassword;
        private Button btnCopy;
        private Label lblPasswordLength;
        private CheckBox chkUppercase;
        private CheckBox chkLowercase;
        private CheckBox chKNumbers;
        private CheckBox chKSymbols;
    }
}
