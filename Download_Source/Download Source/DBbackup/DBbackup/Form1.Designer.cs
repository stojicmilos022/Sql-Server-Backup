namespace DBbackup
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
            this.labelControl1 = new System.Windows.Forms.Label();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new System.Windows.Forms.Button();
            this.cbservername = new System.Windows.Forms.ComboBox();
            this.cbdatabasename = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.simpleButton3 = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.cbservername.Properties)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.cbdatabasename.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(77, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Select Server Name ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(77, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Select Database Name";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(209, 129);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Backup";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbservername
            // 
            this.cbservername.FormattingEnabled = true;
            this.cbservername.Location = new System.Drawing.Point(220, 41);
            this.cbservername.Name = "cbservername";
            this.cbservername.Size = new System.Drawing.Size(278, 21);
            this.cbservername.TabIndex = 4;
            this.cbservername.SelectedIndexChanged += new System.EventHandler(this.cbservername_SelectedIndexChanged);
            // 
            // cbdatabasename
            // 
            this.cbdatabasename.FormattingEnabled = true;
            this.cbdatabasename.Location = new System.Drawing.Point(220, 89);
            this.cbdatabasename.Name = "cbdatabasename";
            this.cbdatabasename.Size = new System.Drawing.Size(278, 21);
            this.cbdatabasename.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(302, 129);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Restore";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 207);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.cbdatabasename);
            this.Controls.Add(this.cbservername);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBase BackUp/Restore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbservername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbdatabasename)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.Label labelControl2;
        private System.Windows.Forms.Button simpleButton1;
        private System.Windows.Forms.ComboBox cbservername;
        private System.Windows.Forms.ComboBox cbdatabasename;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button simpleButton3;


    }
}
