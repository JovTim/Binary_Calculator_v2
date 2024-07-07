namespace Binary_Calculator_v2
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConversion = new System.Windows.Forms.Button();
            this.buttonOperation = new System.Windows.Forms.Button();
            this.helpMain = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 142);
            this.label1.TabIndex = 0;
            this.label1.Text = "BINARY CALCULATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConversion
            // 
            this.buttonConversion.Location = new System.Drawing.Point(87, 192);
            this.buttonConversion.Name = "buttonConversion";
            this.buttonConversion.Size = new System.Drawing.Size(188, 66);
            this.buttonConversion.TabIndex = 1;
            this.buttonConversion.Text = "Conversion";
            this.buttonConversion.UseVisualStyleBackColor = true;
            this.buttonConversion.Click += new System.EventHandler(this.buttonConversion_Click);
            // 
            // buttonOperation
            // 
            this.buttonOperation.Location = new System.Drawing.Point(87, 282);
            this.buttonOperation.Name = "buttonOperation";
            this.buttonOperation.Size = new System.Drawing.Size(188, 66);
            this.buttonOperation.TabIndex = 2;
            this.buttonOperation.Text = "Operation";
            this.buttonOperation.UseVisualStyleBackColor = true;
            this.buttonOperation.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // helpMain
            // 
            this.helpMain.AutoSize = true;
            this.helpMain.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMain.LinkColor = System.Drawing.Color.ForestGreen;
            this.helpMain.Location = new System.Drawing.Point(359, 0);
            this.helpMain.Name = "helpMain";
            this.helpMain.Size = new System.Drawing.Size(15, 21);
            this.helpMain.TabIndex = 3;
            this.helpMain.TabStop = true;
            this.helpMain.Text = "!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.helpMain);
            this.Controls.Add(this.buttonOperation);
            this.Controls.Add(this.buttonConversion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BINARY CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConversion;
        private System.Windows.Forms.Button buttonOperation;
        private System.Windows.Forms.LinkLabel helpMain;
    }
}