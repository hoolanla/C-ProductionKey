namespace ProductionKey
{
    partial class FrmRegistration
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
            this.btnOK = new System.Windows.Forms.Button();
            this.textProductKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(506, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 37);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textProductKey
            // 
            this.textProductKey.Location = new System.Drawing.Point(228, 93);
            this.textProductKey.Name = "textProductKey";
            this.textProductKey.Size = new System.Drawing.Size(380, 26);
            this.textProductKey.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Key";
            // 
            // textProductID
            // 
            this.textProductID.Location = new System.Drawing.Point(228, 37);
            this.textProductID.Name = "textProductID";
            this.textProductID.ReadOnly = true;
            this.textProductID.Size = new System.Drawing.Size(380, 26);
            this.textProductID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product ID";
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 231);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textProductKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProductID);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textProductKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProductID;
        private System.Windows.Forms.Label label1;
    }
}