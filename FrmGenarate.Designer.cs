namespace ProductionKey
{
    partial class FrmGenarate
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
            this.textProductID = new System.Windows.Forms.TextBox();
            this.textProductKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // textProductID
            // 
            this.textProductID.Location = new System.Drawing.Point(192, 38);
            this.textProductID.Name = "textProductID";
            this.textProductID.Size = new System.Drawing.Size(380, 26);
            this.textProductID.TabIndex = 1;
            // 
            // textProductKey
            // 
            this.textProductKey.Location = new System.Drawing.Point(192, 94);
            this.textProductKey.Name = "textProductKey";
            this.textProductKey.ReadOnly = true;
            this.textProductKey.Size = new System.Drawing.Size(380, 26);
            this.textProductKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Key";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(470, 156);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 37);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FrmGenarate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 233);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textProductKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProductID);
            this.Controls.Add(this.label1);
            this.Name = "FrmGenarate";
            this.Text = "FormGenerate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProductID;
        private System.Windows.Forms.TextBox textProductKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
    }
}

