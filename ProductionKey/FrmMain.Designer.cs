namespace ProductionKey
{
    partial class FrmMain
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
            this.btnFrmGen = new System.Windows.Forms.Button();
            this.btnFrmRegis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrmGen
            // 
            this.btnFrmGen.Location = new System.Drawing.Point(90, 72);
            this.btnFrmGen.Name = "btnFrmGen";
            this.btnFrmGen.Size = new System.Drawing.Size(117, 61);
            this.btnFrmGen.TabIndex = 0;
            this.btnFrmGen.Text = "Generate";
            this.btnFrmGen.UseVisualStyleBackColor = true;
            this.btnFrmGen.Click += new System.EventHandler(this.btnFrmGen_Click);
            // 
            // btnFrmRegis
            // 
            this.btnFrmRegis.Location = new System.Drawing.Point(290, 72);
            this.btnFrmRegis.Name = "btnFrmRegis";
            this.btnFrmRegis.Size = new System.Drawing.Size(118, 61);
            this.btnFrmRegis.TabIndex = 1;
            this.btnFrmRegis.Text = "Registration";
            this.btnFrmRegis.UseVisualStyleBackColor = true;
            this.btnFrmRegis.Click += new System.EventHandler(this.btnFrmRegis_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 245);
            this.Controls.Add(this.btnFrmRegis);
            this.Controls.Add(this.btnFrmGen);
            this.Name = "FrmMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrmGen;
        private System.Windows.Forms.Button btnFrmRegis;
    }
}