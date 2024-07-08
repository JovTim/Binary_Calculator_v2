namespace Binary_Calculator_v2
{
    partial class binConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(binConversion));
            this.label1 = new System.Windows.Forms.Label();
            this.binaryInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deciInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.octalInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hexaInput = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.backToHome1 = new System.Windows.Forms.Button();
            this.helpConversion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 142);
            this.label1.TabIndex = 1;
            this.label1.Text = "BINARY CONVERSION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // binaryInput
            // 
            this.binaryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryInput.Location = new System.Drawing.Point(12, 187);
            this.binaryInput.Name = "binaryInput";
            this.binaryInput.Size = new System.Drawing.Size(388, 27);
            this.binaryInput.TabIndex = 2;
            this.binaryInput.TextChanged += new System.EventHandler(this.binaryInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BINARY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "DECIMAL";
            // 
            // deciInput
            // 
            this.deciInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deciInput.Location = new System.Drawing.Point(12, 252);
            this.deciInput.Name = "deciInput";
            this.deciInput.Size = new System.Drawing.Size(388, 27);
            this.deciInput.TabIndex = 4;
            this.deciInput.TextChanged += new System.EventHandler(this.deciInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "OCTAL";
            // 
            // octalInput
            // 
            this.octalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octalInput.Location = new System.Drawing.Point(12, 316);
            this.octalInput.Name = "octalInput";
            this.octalInput.Size = new System.Drawing.Size(388, 27);
            this.octalInput.TabIndex = 6;
            this.octalInput.TextChanged += new System.EventHandler(this.octalInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "HEXADECIMAL";
            // 
            // hexaInput
            // 
            this.hexaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexaInput.Location = new System.Drawing.Point(12, 382);
            this.hexaInput.Name = "hexaInput";
            this.hexaInput.Size = new System.Drawing.Size(388, 27);
            this.hexaInput.TabIndex = 8;
            this.hexaInput.TextChanged += new System.EventHandler(this.hexaInput_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.IndianRed;
            this.clearButton.Location = new System.Drawing.Point(37, 456);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(135, 52);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.LightGreen;
            this.convertButton.Location = new System.Drawing.Point(233, 456);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(135, 52);
            this.convertButton.TabIndex = 11;
            this.convertButton.Text = "CONVERT";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // backToHome1
            // 
            this.backToHome1.Location = new System.Drawing.Point(3, 8);
            this.backToHome1.Name = "backToHome1";
            this.backToHome1.Size = new System.Drawing.Size(59, 23);
            this.backToHome1.TabIndex = 12;
            this.backToHome1.Text = "Home";
            this.backToHome1.UseVisualStyleBackColor = true;
            this.backToHome1.Click += new System.EventHandler(this.backToHome1_Click);
            // 
            // helpConversion
            // 
            this.helpConversion.AutoSize = true;
            this.helpConversion.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpConversion.LinkColor = System.Drawing.Color.ForestGreen;
            this.helpConversion.Location = new System.Drawing.Point(385, 7);
            this.helpConversion.Name = "helpConversion";
            this.helpConversion.Size = new System.Drawing.Size(19, 21);
            this.helpConversion.TabIndex = 13;
            this.helpConversion.TabStop = true;
            this.helpConversion.Text = "?";
            // 
            // binConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 530);
            this.Controls.Add(this.helpConversion);
            this.Controls.Add(this.backToHome1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hexaInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.octalInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deciInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.binaryInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "binConversion";
            this.Text = "BINARY CONVERSION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox binaryInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deciInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox octalInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hexaInput;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button backToHome1;
        private System.Windows.Forms.LinkLabel helpConversion;
    }
}