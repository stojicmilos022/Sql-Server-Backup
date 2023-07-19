using System;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.Odbc;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
namespace DBbackup
{
    public partial class Form1 : Form
    {
        OdbcCommand cmd;
        OdbcDataReader dr;
        public Form1()
        {
            InitializeComponent();
           
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            serverName();
        }

        public void Createconnection()
        {
            DBbackup.DataBaseClass dbc = new DataBaseClass();
          
            cbservername.Items.Clear();
            // select * from sys.databases getting all database name from sql server 
            cmd = new OdbcCommand("select * from sys.databases", dbc.openconn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbdatabasename.Items.Add(dr[0]);
            }
            dr.Close();


        }
        public void serverName()
        {
            try
            {
                DBbackup.DataBaseClass dbc = new DataBaseClass();
                // select *  from sys.servers getting server names that exist
                cmd = new OdbcCommand("select *  from sys.servers", dbc.openconn());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbservername.Items.Add(dr[1]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                //
            }
        }
        public void query(string que)
        {
           
           
            DBbackup.DataBaseClass dbc = new DataBaseClass();
            cmd = new OdbcCommand(que, dbc.openconn());

            cmd.ExecuteNonQuery();
            


        }

        public void newquery(string que)
        {
            
            
            DBbackup.DataBaseClass dbc = new DataBaseClass();
            cmd = new OdbcCommand(que, dbc.openconn());
            cmd.CommandTimeout = 50;
            cmd.ExecuteNonQuery();
        }
        // Backup Database
        public void blank(string str)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (string.IsNullOrEmpty(cbservername.Text) | string.IsNullOrEmpty(cbdatabasename.Text))
                {
                   
                    MessageBox.Show("Server Name & Database can not be Blank", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (str == "backup")
                    {
                        saveFileDialog1.Filter = "Text files (*.bak)|*.bak|All files (*.*)|*.*";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            // the below query get backup of database you specified in combobox
                            query("Backup database " + cbdatabasename.Text + " to disk='" + saveFileDialog1.FileName + "'");
                            
                            MessageBox.Show("Database BackUp has been created successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.DoEvents();
                        }
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report this to Fix it.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.DoEvents();
                Cursor.Current = Cursors.Default;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            blank("backup");
        }

        private void cbservername_SelectedIndexChanged(object sender, EventArgs e)
        {
            Createconnection();
        }
       
        

      
        // Restore database 
       public void Restore(OdbcConnection sqlcon, string DatabaseFullPath, string backUpPath)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (sqlcon)
                {
                    

                    string UseMaster = "USE master";
                    OdbcCommand UseMasterCommand = new OdbcCommand(UseMaster, sqlcon);
                    UseMasterCommand.ExecuteNonQuery();
                    // The below query will rollback any transaction which is running on that database and brings SQL Server database in a single user mode.
                    string Alter1 = @"ALTER DATABASE [" + DatabaseFullPath + "] SET Single_User WITH Rollback Immediate";
                    OdbcCommand Alter1Cmd = new OdbcCommand(Alter1, sqlcon);
                    Alter1Cmd.ExecuteNonQuery();
                    // The below query will restore database file from disk where backup was taken ....
                    string Restore = @"RESTORE DATABASE [" + DatabaseFullPath + "] FROM DISK = N'" + backUpPath + @"' WITH  FILE = 1,  NOUNLOAD,  STATS = 10";
                    OdbcCommand RestoreCmd = new OdbcCommand(Restore, sqlcon);
                    RestoreCmd.ExecuteNonQuery();
                    // the below query change the database back to multiuser
                    string Alter2 = @"ALTER DATABASE [" + DatabaseFullPath + "] SET Multi_User";
                    OdbcCommand Alter2Cmd = new OdbcCommand(Alter2, sqlcon);
                    Alter2Cmd.ExecuteNonQuery();
                    Cursor.Current = Cursors.Default;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report this to Fix it.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbservername.Text) | string.IsNullOrEmpty(cbdatabasename.Text))
            {
                MessageBox.Show("Server Name & Database can not be Blank", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.DoEvents();
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                openFileDialog1.Filter = "Text files (*.bak)|*.bak|All files (*.*)|*.*";

                DBbackup.DataBaseClass dbc = new DataBaseClass();
                Restore(dbc.openconn(), cbdatabasename.SelectedItem.ToString(), openFileDialog1.FileName);
                MessageBox.Show("Obezbedjenje USPESNO", "Kraj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.DoEvents();
            }
        }
    }
}
