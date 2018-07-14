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
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtRespone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRequest
            // 
            this.txtRequest.Font = new System.Drawing.Font("Ubuntu Condensed", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(12, 12);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(677, 31);
            this.txtRequest.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Ubuntu Condensed", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(695, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 31);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Send";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtRespone
            // 
            this.txtRespone.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespone.Location = new System.Drawing.Point(644, 49);
            this.txtRespone.Multiline = true;
            this.txtRespone.Name = "txtRespone";
            this.txtRespone.Size = new System.Drawing.Size(356, 403);
            this.txtRespone.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://s.ynet.me/assets/images/movies/ready_player_one_2018/medium-cover.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(45, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRespone);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtRequest);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtRespone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}