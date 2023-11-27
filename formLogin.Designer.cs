
namespace Toko_Bangunan_Watumas_Jaya
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btMasuk = new System.Windows.Forms.Button();
            this.btBatal = new System.Windows.Forms.Button();
            this.txtWarning = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 461);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(296, 395);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(311, 39);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPasswd
            // 
            this.txtPasswd.BackColor = System.Drawing.Color.White;
            this.txtPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswd.Location = new System.Drawing.Point(296, 461);
            this.txtPasswd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(311, 39);
            this.txtPasswd.TabIndex = 3;
            // 
            // btMasuk
            // 
            this.btMasuk.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMasuk.Location = new System.Drawing.Point(390, 601);
            this.btMasuk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMasuk.Name = "btMasuk";
            this.btMasuk.Size = new System.Drawing.Size(219, 60);
            this.btMasuk.TabIndex = 4;
            this.btMasuk.Text = "MASUK";
            this.btMasuk.UseVisualStyleBackColor = false;
            this.btMasuk.Click += new System.EventHandler(this.btMasuk_Click);
            // 
            // btBatal
            // 
            this.btBatal.BackColor = System.Drawing.Color.OrangeRed;
            this.btBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBatal.Location = new System.Drawing.Point(136, 601);
            this.btBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(219, 60);
            this.btBatal.TabIndex = 5;
            this.btBatal.Text = "BATAL";
            this.btBatal.UseVisualStyleBackColor = false;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // txtWarning
            // 
            this.txtWarning.AutoSize = true;
            this.txtWarning.BackColor = System.Drawing.Color.Transparent;
            this.txtWarning.ForeColor = System.Drawing.Color.Red;
            this.txtWarning.Location = new System.Drawing.Point(181, 527);
            this.txtWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(389, 20);
            this.txtWarning.TabIndex = 6;
            this.txtWarning.Text = "Username atau Password yang anda masukkan salah";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(185, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 362);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 763);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btMasuk);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btMasuk;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Label txtWarning;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

