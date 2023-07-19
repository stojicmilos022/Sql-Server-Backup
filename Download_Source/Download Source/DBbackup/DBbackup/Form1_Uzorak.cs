using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace In_formo_Watcher
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string StringForma="";
        public static string STTReportTMP;
        public static bool XMLoviSaServera=false, bPortOpened=false;
        public static string NaslovForme = "Kuconja prati a ne laje";
        public static string XMLFileName = @"\in_formo\WinIn_formo.xml";
        public static string aDaLi = @"\in_formo\AktuelnaVerzija\Radim";
        public static string StringVlasnik = "", StringLokacija = "", StringOperater="in01";
        public static string sms_kome = "", sms_poruka = "", smsPort_in_use = "COM18";

        private void InitializeComponent()
        {
            this.labelControl1 = new System.Windows.Forms.Label();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new System.Windows.Forms.Button();
            this.SimpleButton3 = new System.Windows.Forms.Button();
            this.cbservername = new System.Windows.Forms.ComboBox();
            this.cbdatabasename = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Select Server Name ";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSize = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Select DataBase Name ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(139, 39);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Backup";
            this.simpleButton1.UseVisualStyleBackColor = true;
            // 
            // SimpleButton3
            // 
            this.SimpleButton3.Location = new System.Drawing.Point(139, 87);
            this.SimpleButton3.Name = "SimpleButton3";
            this.SimpleButton3.Size = new System.Drawing.Size(75, 23);
            this.SimpleButton3.TabIndex = 3;
            this.SimpleButton3.Text = "Restore";
            this.SimpleButton3.UseVisualStyleBackColor = true;
            // 
            // cbservername
            // 
            this.cbservername.FormattingEnabled = true;
            this.cbservername.Location = new System.Drawing.Point(220, 41);
            this.cbservername.Name = "cbservername";
            this.cbservername.Size = new System.Drawing.Size(278, 21);
            this.cbservername.TabIndex = 4;
            // 
            // cbdatabasename
            // 
            this.cbdatabasename.FormattingEnabled = true;
            this.cbdatabasename.Location = new System.Drawing.Point(220, 89);
            this.cbdatabasename.Name = "cbdatabasename";
            this.cbdatabasename.Size = new System.Drawing.Size(278, 21);
            this.cbdatabasename.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.cbdatabasename);
            this.Controls.Add(this.cbservername);
            this.Controls.Add(this.SimpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public static string  ConStr="";
        public bool konekcijaUspela = true;
        private Label labelControl1;
        private Label labelControl2;
        private Button simpleButton1;
        private Button SimpleButton3;
        private ComboBox cbservername;
        private ComboBox cbdatabasename;

        /// <param name="Verzija"></param>
        /// <returns></returns>
        public const string Verzija = "V2.A030.36";
        //public static DateTime Sinhron_Start;

        private void Form1_Load(object sender, System.EventArgs e)
        {

            FormVSMSWatcher f = new FormVSMSWatcher();
            f.ShowDialog();
                      
        }
        public static DataTable NapuniDataTable(string aSQL, string aErrStr, bool IgnoreError)
        {
            DataTable rez = new DataTable();
            SqlConnection conG = null;

            conG = new SqlConnection(Form1.ConStr);
            try
            {
                conG.Open();
                SqlDataAdapter daG = new SqlDataAdapter(aSQL, conG);
                daG.Fill(rez);
            }
            catch (Exception ex)
            {
                if (!IgnoreError)
                {
                    //new TGErr(aErrStr +
                    //    " \n SQL :" + aSQL +
                    //    " \n Poruka za Programera: " + ex.Message);
                }
            }
            finally
            { conG.Close(); }
            return rez;
        }


    }
}