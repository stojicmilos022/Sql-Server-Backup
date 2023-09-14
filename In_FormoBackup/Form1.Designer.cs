namespace In_FormoBackup
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.Server = new System.Windows.Forms.Label();
            this.gbParametri = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.labKonekcija_Status = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnUcitajBaze = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbBaze = new System.Windows.Forms.CheckedListBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.gbBackup = new System.Windows.Forms.GroupBox();
            this.btnTmp = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnRemote = new System.Windows.Forms.Button();
            this.txtRemote = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLokalno = new System.Windows.Forms.Button();
            this.btnUcitajIzXml = new System.Windows.Forms.Button();
            this.btnNijedna = new System.Windows.Forms.Button();
            this.btnSveBaze = new System.Windows.Forms.Button();
            this.txtLokalno = new System.Windows.Forms.TextBox();
            this.btnXML = new System.Windows.Forms.Button();
            this.gbMail = new System.Windows.Forms.GroupBox();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.chbSMS = new System.Windows.Forms.CheckBox();
            this.chbFail = new System.Windows.Forms.CheckBox();
            this.chbDone = new System.Windows.Forms.CheckBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.labMail = new System.Windows.Forms.Label();
            this.btnIzv = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.gbVreme = new System.Windows.Forms.GroupBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtIzvestaji = new System.Windows.Forms.TextBox();
            this.gbBaze = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbFolder = new System.Windows.Forms.CheckBox();
            this.chbXML = new System.Windows.Forms.CheckBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labTmp = new System.Windows.Forms.Label();
            this.gbParametri.SuspendLayout();
            this.gbBackup.SuspendLayout();
            this.gbMail.SuspendLayout();
            this.gbVreme.SuspendLayout();
            this.gbBaze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server.Location = new System.Drawing.Point(6, 19);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(50, 17);
            this.Server.TabIndex = 1;
            this.Server.Text = "Server";
            // 
            // gbParametri
            // 
            this.gbParametri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbParametri.Controls.Add(this.txtServer);
            this.gbParametri.Controls.Add(this.labKonekcija_Status);
            this.gbParametri.Controls.Add(this.txtPass);
            this.gbParametri.Controls.Add(this.btnUcitajBaze);
            this.gbParametri.Controls.Add(this.txtUser);
            this.gbParametri.Controls.Add(this.label3);
            this.gbParametri.Controls.Add(this.label2);
            this.gbParametri.Controls.Add(this.txtWS);
            this.gbParametri.Controls.Add(this.label1);
            this.gbParametri.Controls.Add(this.Server);
            this.gbParametri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametri.Location = new System.Drawing.Point(12, 12);
            this.gbParametri.Name = "gbParametri";
            this.gbParametri.Size = new System.Drawing.Size(343, 189);
            this.gbParametri.TabIndex = 2;
            this.gbParametri.TabStop = false;
            this.gbParametri.Text = "Parametri konekcije";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(85, 15);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(247, 21);
            this.txtServer.TabIndex = 12;
            // 
            // labKonekcija_Status
            // 
            this.labKonekcija_Status.AutoSize = true;
            this.labKonekcija_Status.Location = new System.Drawing.Point(8, 146);
            this.labKonekcija_Status.Name = "labKonekcija_Status";
            this.labKonekcija_Status.Size = new System.Drawing.Size(0, 17);
            this.labKonekcija_Status.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(85, 92);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(247, 21);
            this.txtPass.TabIndex = 10;
            // 
            // btnUcitajBaze
            // 
            this.btnUcitajBaze.BackColor = System.Drawing.Color.Aqua;
            this.btnUcitajBaze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUcitajBaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajBaze.Location = new System.Drawing.Point(85, 131);
            this.btnUcitajBaze.Name = "btnUcitajBaze";
            this.btnUcitajBaze.Size = new System.Drawing.Size(247, 47);
            this.btnUcitajBaze.TabIndex = 9;
            this.btnUcitajBaze.Text = "Učitaj baze";
            this.btnUcitajBaze.UseVisualStyleBackColor = false;
            this.btnUcitajBaze.Click += new System.EventHandler(this.btnUcitajBaze_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(85, 68);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(247, 21);
            this.txtUser.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserName";
            // 
            // txtWS
            // 
            this.txtWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWS.Location = new System.Drawing.Point(305, 44);
            this.txtWS.Name = "txtWS";
            this.txtWS.Size = new System.Drawing.Size(27, 21);
            this.txtWS.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "W/S";
            // 
            // clbBaze
            // 
            this.clbBaze.BackColor = System.Drawing.Color.PowderBlue;
            this.clbBaze.CheckOnClick = true;
            this.clbBaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbBaze.FormattingEnabled = true;
            this.clbBaze.Location = new System.Drawing.Point(6, 22);
            this.clbBaze.Name = "clbBaze";
            this.clbBaze.Size = new System.Drawing.Size(297, 349);
            this.clbBaze.TabIndex = 3;
            this.clbBaze.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(23, 575);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(321, 25);
            this.btnSnimi.TabIndex = 8;
            this.btnSnimi.Text = "SNIMI PARAMETRE ZA BACKUP";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // gbBackup
            // 
            this.gbBackup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbBackup.Controls.Add(this.labTmp);
            this.gbBackup.Controls.Add(this.btnTmp);
            this.gbBackup.Controls.Add(this.txtTemp);
            this.gbBackup.Controls.Add(this.btnRemote);
            this.gbBackup.Controls.Add(this.txtRemote);
            this.gbBackup.Controls.Add(this.checkBox2);
            this.gbBackup.Controls.Add(this.checkBox1);
            this.gbBackup.Controls.Add(this.btnLokalno);
            this.gbBackup.Controls.Add(this.btnUcitajIzXml);
            this.gbBackup.Controls.Add(this.btnNijedna);
            this.gbBackup.Controls.Add(this.btnSveBaze);
            this.gbBackup.Controls.Add(this.txtLokalno);
            this.gbBackup.Controls.Add(this.btnXML);
            this.gbBackup.Controls.Add(this.gbMail);
            this.gbBackup.Controls.Add(this.btnIzv);
            this.gbBackup.Controls.Add(this.txtXML);
            this.gbBackup.Controls.Add(this.gbVreme);
            this.gbBackup.Controls.Add(this.txtIzvestaji);
            this.gbBackup.Controls.Add(this.gbBaze);
            this.gbBackup.Controls.Add(this.chbFolder);
            this.gbBackup.Controls.Add(this.chbXML);
            this.gbBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBackup.Location = new System.Drawing.Point(361, 12);
            this.gbBackup.Name = "gbBackup";
            this.gbBackup.Size = new System.Drawing.Size(600, 635);
            this.gbBackup.TabIndex = 4;
            this.gbBackup.TabStop = false;
            this.gbBackup.Text = "Backup Shedule";
            // 
            // btnTmp
            // 
            this.btnTmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTmp.Image = global::In_FormoBackup.Properties.Resources.Icon1;
            this.btnTmp.Location = new System.Drawing.Point(534, 446);
            this.btnTmp.Name = "btnTmp";
            this.btnTmp.Size = new System.Drawing.Size(36, 23);
            this.btnTmp.TabIndex = 26;
            this.btnTmp.UseVisualStyleBackColor = true;
            this.btnTmp.Click += new System.EventHandler(this.btnTmp_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(158, 446);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(369, 23);
            this.txtTemp.TabIndex = 25;
            // 
            // btnRemote
            // 
            this.btnRemote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemote.Image = global::In_FormoBackup.Properties.Resources.Icon1;
            this.btnRemote.Location = new System.Drawing.Point(534, 603);
            this.btnRemote.Name = "btnRemote";
            this.btnRemote.Size = new System.Drawing.Size(36, 23);
            this.btnRemote.TabIndex = 24;
            this.btnRemote.UseVisualStyleBackColor = true;
            this.btnRemote.Click += new System.EventHandler(this.btnRemote_Click);
            // 
            // txtRemote
            // 
            this.txtRemote.Location = new System.Drawing.Point(216, 601);
            this.txtRemote.Name = "txtRemote";
            this.txtRemote.Size = new System.Drawing.Size(311, 23);
            this.txtRemote.TabIndex = 23;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 603);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(198, 21);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Snimi na udaljenu lokaciju :";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 560);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Snimi u folder lokalno :";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnLokalno
            // 
            this.btnLokalno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLokalno.Image = global::In_FormoBackup.Properties.Resources.Icon1;
            this.btnLokalno.Location = new System.Drawing.Point(534, 558);
            this.btnLokalno.Name = "btnLokalno";
            this.btnLokalno.Size = new System.Drawing.Size(36, 23);
            this.btnLokalno.TabIndex = 20;
            this.btnLokalno.UseVisualStyleBackColor = true;
            this.btnLokalno.Click += new System.EventHandler(this.btnLokalno_Click);
            // 
            // btnUcitajIzXml
            // 
            this.btnUcitajIzXml.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUcitajIzXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUcitajIzXml.Location = new System.Drawing.Point(331, 340);
            this.btnUcitajIzXml.Name = "btnUcitajIzXml";
            this.btnUcitajIzXml.Size = new System.Drawing.Size(239, 63);
            this.btnUcitajIzXml.TabIndex = 19;
            this.btnUcitajIzXml.Text = "UČITAJ BAZE IZ XML";
            this.btnUcitajIzXml.UseVisualStyleBackColor = false;
            this.btnUcitajIzXml.Click += new System.EventHandler(this.btnUcitajIzXml_Click);
            // 
            // btnNijedna
            // 
            this.btnNijedna.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNijedna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNijedna.Location = new System.Drawing.Point(178, 409);
            this.btnNijedna.Name = "btnNijedna";
            this.btnNijedna.Size = new System.Drawing.Size(137, 23);
            this.btnNijedna.TabIndex = 18;
            this.btnNijedna.Text = "OD ČEKIRAJ SVE BAZE";
            this.btnNijedna.UseVisualStyleBackColor = false;
            this.btnNijedna.Click += new System.EventHandler(this.btnNijedna_Click);
            // 
            // btnSveBaze
            // 
            this.btnSveBaze.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSveBaze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSveBaze.Location = new System.Drawing.Point(6, 409);
            this.btnSveBaze.Name = "btnSveBaze";
            this.btnSveBaze.Size = new System.Drawing.Size(140, 23);
            this.btnSveBaze.TabIndex = 17;
            this.btnSveBaze.Text = "ČEKIRAJ SVE BAZE";
            this.btnSveBaze.UseVisualStyleBackColor = false;
            this.btnSveBaze.Click += new System.EventHandler(this.btnSveBaze_Click);
            // 
            // txtLokalno
            // 
            this.txtLokalno.Location = new System.Drawing.Point(217, 560);
            this.txtLokalno.Name = "txtLokalno";
            this.txtLokalno.Size = new System.Drawing.Size(311, 23);
            this.txtLokalno.TabIndex = 15;
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(534, 522);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(36, 23);
            this.btnXML.TabIndex = 14;
            this.btnXML.Text = "xml";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // gbMail
            // 
            this.gbMail.Controls.Add(this.txtSMS);
            this.gbMail.Controls.Add(this.chbSMS);
            this.gbMail.Controls.Add(this.chbFail);
            this.gbMail.Controls.Add(this.chbDone);
            this.gbMail.Controls.Add(this.txtMail);
            this.gbMail.Controls.Add(this.labMail);
            this.gbMail.Location = new System.Drawing.Point(331, 187);
            this.gbMail.Name = "gbMail";
            this.gbMail.Size = new System.Drawing.Size(239, 131);
            this.gbMail.TabIndex = 8;
            this.gbMail.TabStop = false;
            this.gbMail.Text = "Adresa za  poruke";
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(89, 80);
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(144, 23);
            this.txtSMS.TabIndex = 15;
            // 
            // chbSMS
            // 
            this.chbSMS.AutoSize = true;
            this.chbSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSMS.Location = new System.Drawing.Point(9, 82);
            this.chbSMS.Name = "chbSMS";
            this.chbSMS.Size = new System.Drawing.Size(83, 19);
            this.chbSMS.TabIndex = 13;
            this.chbSMS.Text = "Šalji SMS:";
            this.chbSMS.UseVisualStyleBackColor = true;
            // 
            // chbFail
            // 
            this.chbFail.AutoSize = true;
            this.chbFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFail.Location = new System.Drawing.Point(9, 64);
            this.chbFail.Name = "chbFail";
            this.chbFail.Size = new System.Drawing.Size(207, 19);
            this.chbFail.TabIndex = 12;
            this.chbFail.Text = "Obaveštenje za neuspeo backup ";
            this.chbFail.UseVisualStyleBackColor = true;
            // 
            // chbDone
            // 
            this.chbDone.AutoSize = true;
            this.chbDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDone.Location = new System.Drawing.Point(9, 46);
            this.chbDone.Name = "chbDone";
            this.chbDone.Size = new System.Drawing.Size(193, 19);
            this.chbDone.TabIndex = 9;
            this.chbDone.Text = "Obaveštenje za uspeo backup ";
            this.chbDone.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(47, 22);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(186, 21);
            this.txtMail.TabIndex = 11;
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMail.Location = new System.Drawing.Point(6, 27);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(42, 13);
            this.labMail.TabIndex = 5;
            this.labMail.Text = "E-Mail :";
            // 
            // btnIzv
            // 
            this.btnIzv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzv.Image = global::In_FormoBackup.Properties.Resources.Icon1;
            this.btnIzv.Location = new System.Drawing.Point(534, 484);
            this.btnIzv.Name = "btnIzv";
            this.btnIzv.Size = new System.Drawing.Size(36, 23);
            this.btnIzv.TabIndex = 13;
            this.btnIzv.UseVisualStyleBackColor = true;
            this.btnIzv.Click += new System.EventHandler(this.btnIzv_Click);
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(159, 524);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(369, 23);
            this.txtXML.TabIndex = 12;
            // 
            // gbVreme
            // 
            this.gbVreme.Controls.Add(this.btnSchedule);
            this.gbVreme.Controls.Add(this.dtpTime);
            this.gbVreme.Location = new System.Drawing.Point(331, 19);
            this.gbVreme.Name = "gbVreme";
            this.gbVreme.Size = new System.Drawing.Size(239, 94);
            this.gbVreme.TabIndex = 7;
            this.gbVreme.TabStop = false;
            this.gbVreme.Text = "Vreme za backup :";
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.Aqua;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(9, 43);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(158, 23);
            this.btnSchedule.TabIndex = 13;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpTime.Location = new System.Drawing.Point(173, 43);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(60, 23);
            this.dtpTime.TabIndex = 6;
            // 
            // txtIzvestaji
            // 
            this.txtIzvestaji.Location = new System.Drawing.Point(158, 484);
            this.txtIzvestaji.Name = "txtIzvestaji";
            this.txtIzvestaji.Size = new System.Drawing.Size(369, 23);
            this.txtIzvestaji.TabIndex = 11;
            // 
            // gbBaze
            // 
            this.gbBaze.Controls.Add(this.groupBox1);
            this.gbBaze.Controls.Add(this.clbBaze);
            this.gbBaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBaze.Location = new System.Drawing.Point(6, 19);
            this.gbBaze.Name = "gbBaze";
            this.gbBaze.Size = new System.Drawing.Size(309, 384);
            this.gbBaze.TabIndex = 5;
            this.gbBaze.TabStop = false;
            this.gbBaze.Text = "Baze :";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(309, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chbFolder
            // 
            this.chbFolder.AutoSize = true;
            this.chbFolder.Checked = true;
            this.chbFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFolder.Location = new System.Drawing.Point(12, 484);
            this.chbFolder.Name = "chbFolder";
            this.chbFolder.Size = new System.Drawing.Size(112, 19);
            this.chbFolder.TabIndex = 10;
            this.chbFolder.Text = "Backup Foldera";
            this.chbFolder.UseVisualStyleBackColor = true;
            // 
            // chbXML
            // 
            this.chbXML.AutoSize = true;
            this.chbXML.Checked = true;
            this.chbXML.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbXML.Location = new System.Drawing.Point(12, 524);
            this.chbXML.Name = "chbXML";
            this.chbXML.Size = new System.Drawing.Size(106, 21);
            this.chbXML.TabIndex = 9;
            this.chbXML.Text = "Backup XML";
            this.chbXML.UseVisualStyleBackColor = true;
            //this.chbXML.CheckedChanged += new System.EventHandler(this.chbXML_CheckedChanged);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.PaleGreen;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(21, 612);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(323, 25);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "ZAPOČNI BACKUP";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labTmp
            // 
            this.labTmp.AutoSize = true;
            this.labTmp.Location = new System.Drawing.Point(28, 446);
            this.labTmp.Name = "labTmp";
            this.labTmp.Size = new System.Drawing.Size(56, 17);
            this.labTmp.TabIndex = 27;
            this.labTmp.Text = "Temp  :";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.gbBackup);
            this.Controls.Add(this.gbParametri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(808, 350);
            this.Name = "Test";
            this.Text = "In_Formo Backup Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbParametri.ResumeLayout(false);
            this.gbParametri.PerformLayout();
            this.gbBackup.ResumeLayout(false);
            this.gbBackup.PerformLayout();
            this.gbMail.ResumeLayout(false);
            this.gbMail.PerformLayout();
            this.gbVreme.ResumeLayout(false);
            this.gbBaze.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.GroupBox gbParametri;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUcitajBaze;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.CheckedListBox clbBaze;
        private System.Windows.Forms.GroupBox gbBackup;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.GroupBox gbBaze;
        private System.Windows.Forms.GroupBox gbMail;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.CheckBox chbFail;
        private System.Windows.Forms.CheckBox chbDone;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox gbVreme;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.CheckBox chbXML;
        private System.Windows.Forms.CheckBox chbFolder;
        private System.Windows.Forms.TextBox txtIzvestaji;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.Button btnIzv;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.CheckBox chbSMS;
        private System.Windows.Forms.TextBox txtLokalno;
        private System.Windows.Forms.Label labKonekcija_Status;
        private System.Windows.Forms.Button btnNijedna;
        private System.Windows.Forms.Button btnSveBaze;
        private System.Windows.Forms.Button btnUcitajIzXml;
        private System.Windows.Forms.Button btnLokalno;
        private System.Windows.Forms.Button btnRemote;
        private System.Windows.Forms.TextBox txtRemote;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnTmp;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label labTmp;
    }
}

