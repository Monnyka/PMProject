namespace Prime_Movie_Project
{
    partial class frmAdd
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(373, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(221, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button button1;
    }
}