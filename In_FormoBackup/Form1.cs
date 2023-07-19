using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.IO;
using System.IO.Compression;
using System.Threading;
using Quartz;
using Quartz.Impl;
//using System.Data.SqlClient;



namespace In_FormoBackup
{
  
    public partial class Test : Form
    {

        public Test()
        {
          InitializeComponent();
        }


        private NotifyIcon trayIcon;
        private ContextMenuStrip trayContextMenu;
        private Form mainForm;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSchedule.PerformClick();

            trayIcon = new NotifyIcon();
            trayIcon.Icon = new System.Drawing.Icon("trayIcon.ico");
            trayIcon.Text = "In_FormoBackupSql";
            trayIcon.Visible = true;

            trayContextMenu = new ContextMenuStrip();
            trayContextMenu.Items.Add("Prikazi");
            trayContextMenu.Items.Add("Izadji");
            trayContextMenu.ItemClicked += TrayContextMenu_ItemClicked;
            trayIcon.ContextMenuStrip = trayContextMenu;

            mainForm = this;
            mainForm.FormClosing += MainForm_FormClosing;
            mainForm.WindowState = FormWindowState.Minimized;
            //mainForm.ShowInTaskbar = false;
            mainForm.Hide();

            XmlDocument doc = new XmlDocument();
            doc.Load("parametri.xml");

            XmlNode root = doc.DocumentElement;

            // ucitavam Polje server iz XML ako postoji, ako ne nikom nista :)

            try
            {
                txtServer.Text = root["Server"].InnerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Polje server nije ucitano proveri xml... " + ex.Message);
                Application.DoEvents();
            }
            // ucitavam Polje Auth iz XML ako postoji, ako ne nikom nista :)

            try
            {
                txtWS.Text = root["Auth"].InnerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Polje auth nije ucitano proveri xml...  " + ex.Message);
                Application.DoEvents();
            }
            // ucitavam Polje user iz XML ako postoji, ako ne nikom nista :)

            try
            {
                txtUser.Text = root["User"].InnerText;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Polje User nije ucitano proveri xml...  " + ex.Message);
                Application.DoEvents();
            }

            // ucitavam Polje password iz XML ako postoji, ako ne nikom nista :)

            try
            {
                txtPass.Text = root["Pass"].InnerText;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Polje Pass nije ucitano proveri xml... " + ex.Message);
                Application.DoEvents();
            }

            // ucitavam Polje Izvestaji iz XML ako postoji, ako ne nikom nista :)

            try
            {
                txtIzvestaji.Text = root["Izvestaji"].InnerText;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Polje Izvestaji nije ucitano proveri xml... " + ex.Message);
                Application.DoEvents();
            }
            // ucitavam Polje XML iz XML ako postoji, ako ne nikom nista :)

            try
            {
                txtXML.Text = root["XML"].InnerText;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Polje XML nije ucitano proveri xml... " + ex.Message);
                Application.DoEvents();
            }
            // ucitavam Polje Lokalno iz XML ako postoji, ako ne nikom nista :)

            try
            {
                txtLokalno.Text = root["Lokalno"].InnerText;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Polje Lokalno nije ucitano proveri xml... " + ex.Message);
                Application.DoEvents();
            }

            // ucitavam Polje Remote iz XML ako postoji, ako ne nikom nista :)

            try
            {
                txtRemote.Text = root["Remote"].InnerText;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Polje Remote nije ucitano proveri xml... " + ex.Message);
                Application.DoEvents();
            }
            // ucitava temp folder iz xml-a
            try
            {
                txtTemp.Text = root["Temp"].InnerText;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Polje Temp nije ucitano proveri xml... " + ex.Message);
                Application.DoEvents();
            }

            // ucitavam check box za dnevni backup



            /*
            cboServer.Text = root["Server"].InnerText;
            txtWS.Text = root["Auth"].InnerText;
            txtUser.Text = root["User"].InnerText;
            txtPass.Text = root["Pass"].InnerText;
            txtIzvestaji.Text = root["Izvestaji"].InnerText;
            txtXML.Text = root["XML"].InnerText;
            txtLokalno.Text = root["Lokalno"].InnerText;
            txtRemote.Text = root["Remote"].InnerText;
            */

            string server = root["Server"].InnerText;
            string username = root["User"].InnerText;
            string password = root["Pass"].InnerText;
            string connectionString = "Data Source=" + server + ";DataBase=master;User ID=" + username + ";Password=" + password;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT top 30 name FROM sys.databases  WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clbBaze.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Neuspešna konekcija sa zadatim parametrima proverite parametre za konekciju " + ex.Message);
                    Application.DoEvents();
                }
            }





            // OVO radi posao puni listu 

            List<string> xmlItems = new List<string>();
            XmlDocument docBaze = new XmlDocument();
            var bazeFolder = System.IO.Path.GetDirectoryName(
System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var xmlBazePath = bazeFolder + @"\BazeZaBackup.xml";
            docBaze.Load(xmlBazePath);
            XmlNodeList nodes = docBaze.SelectNodes("//BazeZaBackup/Item");

            foreach (XmlNode node in nodes)
            {
                xmlItems.Add(node.InnerText);
            }

            if(clbBaze.Items.Count>0)
            {
                for (int i = 0; i<clbBaze.Items.Count; i++)
                {
                    if (xmlItems.Contains(clbBaze.Items[i].ToString()))
                    {
                        clbBaze.SetItemChecked(i, true);
                    }
                }
            }

            // ucitavam vreme iz xml fajla
            var timeFolder = System.IO.Path.GetDirectoryName(
System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var xmlFilePath = timeFolder + @"\parametri.xml";
            //string filePath = @"C:\dates.xml"; // Replace with the path to your XML file
            XDocument document = XDocument.Load(xmlFilePath);
            XElement dateElement = document.Root.Element("Time");
            if (dateElement != null)
            {
                DateTime time = DateTime.ParseExact(dateElement.Value, "HH:mm", null);
                dtpTime.Value = time;
            }


            /*
              foreach (ListItem item in CheckBoxList1.Items)
{
    if (valuesList.Contains(item.Text))
    {
        item.Selected = true;
    }
}
             */


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                mainForm.Hide();
            }
        }

        private void TrayContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Prikazi":
                    mainForm.Show();
                    break;
                case "Izadji":
                    Application.Exit();
                    break;
            }
        }






        public class SqlBackupJob : IJob
        {


            public async Task Execute(IJobExecutionContext context)
            {
                /*
                XmlDocument doc = new XmlDocument();
                doc.Load("parameters.xml");
                XmlNodeList nodes = doc.SelectNodes("/parameters/parameter");
                foreach (XmlNode node in nodes)
                {
                    string name = node.Attributes["name"].Value;
                    string value = node.Attributes["value"].Value;
                    // set the parameter value in your Quartz.NET configuration
                }
                */

                try
                {
                    /*
                    XmlDocument doc = new XmlDocument();
                    var rootFolder = System.IO.Path.GetDirectoryName(
    System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                    var xmlFilePath = rootFolder + @"\parametri.xml";
                    doc.Load(xmlFilePath);
                    XmlNodeList nodes = doc.SelectNodes("/FormData");
                    foreach (XmlNode node in nodes)
                    {
                        string name = node.Attributes["name"].Value;
                        string value = node.Attributes["value"].Value;
                        // set the parameter value in your Quartz.NET configuration
                    }
                    */
                    XmlDocument doc = new XmlDocument();
                    var rootFolder = System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                    var xmlFilePath = rootFolder + @"\parametri.xml";
                    doc.Load(xmlFilePath);
                    XmlNode root = doc.DocumentElement;
                    string sourcePath = root["Izvestaji"].InnerText;
                    string targetPath = root["Temp"].InnerText;
                    string date = DateTime.Now.ToString("yyyyMMddHHmm");
                    string xmlPathIn = root["XML"].InnerText;
                    string xmlName = Path.Combine(targetPath + "\\" + (Path.GetFileName(xmlPathIn)));

                    if (Directory.Exists(sourcePath))

                    {
                        string[] files = Directory.GetFiles(sourcePath);
                        string folderName = new DirectoryInfo(sourcePath).Name;
                        Directory.CreateDirectory(targetPath + "\\" + folderName + date);
                        string target = Path.Combine(targetPath, folderName + date);
                        string zipPath = Path.Combine(targetPath, folderName + date + ".zip");
                        foreach (string file in files)
                        {
                            string name = Path.GetFileName(file);
                            string destFile = Path.Combine(target, name);
                            File.Copy(file, destFile, true);
                        }
                        ZipFile.CreateFromDirectory(target, zipPath);
                        Directory.Delete(target, true);
                    }

                    if (File.Exists(xmlPathIn))

                    {
                        File.Copy(xmlPathIn, xmlName, true);
                    }

                    /*
                    string server = root["Server"].InnerText;
                    string username = root["User"].InnerText;
                    string password = root["Pass"].InnerText;

                    string database = "MMONt";
                    */
                    //List<string> xmlItems = new List<string>();
                    //XmlDocument docBazeS = new XmlDocument();

                    var xmlBaze = rootFolder + @"\BazeZaBackup.xml";
                    XmlDocument docBazeS = new XmlDocument();
                    docBazeS.Load(xmlBaze);
                    XmlNodeList nodes = docBazeS.SelectNodes("//BazeZaBackup/Item");
                    //XElement parentNode = docBazeS.Root.Element("BazeZaBackup");
                    //List<string> xmlItems = parentNode.Elements("item").Select(x => x.Value).ToList();
                    List<string> xmlItems = new List<string>();

                    foreach (XmlNode node in nodes)
                    {
                        xmlItems.Add(node.InnerText);
                    }

                    for (int i = 0; i < xmlItems.Count; i++)
                    {
                        string server = root["Server"].InnerText;
                        string username = root["User"].InnerText;
                        string password = root["Pass"].InnerText;
                        string database = xmlItems[i].ToString();
                        string tempBackup = root["Temp"].InnerText;
                        //string database = databases.ToString;

                        string dateBackup = DateTime.Now.ToString("yyyyMMddHHmm");
                        string backupFileS = Path.Combine(tempBackup, database + dateBackup);
                        string backupFileZ = Path.Combine(tempBackup, database + dateBackup + ".bak");
                        //string fileName = database+dateBackup+".bak";
                        string zipFile = Path.Combine(tempBackup, database + dateBackup + ".zip");


                        string connectionString = "Data Source=" + server + ";DataBase=" + database + ";User ID=" + username + ";Password=" + password;
                        /*using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            //command.CommandText = $"BACKUP DATABASE {database} TO DISK = '{backupFileS}.bak'";
                            using (SqlCommand command = new SqlCommand())
                            {
                                await  connection.OpenAsync(); 
                                command.CommandText = $"BACKUP DATABASE {database} TO DISK = '{backupFileS}.bak'";
                                await command.ExecuteNonQueryAsync();
                            }
                            try
                            {
                                using (ZipArchive archive = new ZipArchive(new FileStream(zipFile, FileMode.Create), ZipArchiveMode.Create))
                                {
                                    archive.CreateEntryFromFile(backupFileZ, Path.GetFileName(backupFileZ));
                                }
                                File.Delete(backupFileZ);
                            }
                            catch { }
                        }
                        */
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = connection;
                                command.CommandText = $"BACKUP DATABASE {database} TO DISK = '{backupFileS}.bak'";
                                command.ExecuteNonQuery();
                            }
                            try
                            {
                                using (ZipArchive archive = new ZipArchive(new FileStream(zipFile, FileMode.Create), ZipArchiveMode.Create))
                                {
                                    archive.CreateEntryFromFile(backupFileZ, Path.GetFileName(backupFileZ));
                                }
                                File.Delete(backupFileZ);
                            }
                            catch { }
                        }

                    }

                    string tempFolder = root["Temp"].InnerText;
                    string backupLokalno = root["Lokalno"].InnerText;
                    string backupRemote = root["Remote"].InnerText;
                    string fileName = "test.txt";

                    string sourceFile = System.IO.Path.Combine(tempFolder, fileName);
                    string destFileLokalno = System.IO.Path.Combine(backupLokalno, fileName);
                    string destFileRemote = System.IO.Path.Combine(backupLokalno, fileName);


                    if (System.IO.Directory.Exists(tempFolder))
                    {
                        string[] files = System.IO.Directory.GetFiles(tempFolder);

                        // Copy the files and overwrite destination files if they already exist.
                        foreach (string s in files)
                        {
                            // Use static Path methods to extract only the file name from the path.
                            fileName = System.IO.Path.GetFileName(s);
                            destFileLokalno = System.IO.Path.Combine(backupLokalno, fileName);
                            destFileRemote = System.IO.Path.Combine(backupRemote, fileName);
                            System.IO.File.Copy(s, destFileLokalno, true);
                            System.IO.File.Copy(s, destFileRemote, true);
                        }

                        foreach (string file in Directory.EnumerateFiles(tempFolder))
                        {
                            File.Delete(file);
                        }
                    }


                    /*
                    // database connection string
                    string connString = "Data Source=" + server + ";DataBase=" + database + ";User ID=" + username + ";Password=" + password;

                    // backup file path
                    string backupFile = @"C:\In_Formo\MMONT.bak";

                    // create the backup command
                    string backupCommand = $"BACKUP DATABASE MMONT TO DISK='{backupFile}'";

                    // create the connection
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        // create the command
                        using (SqlCommand cmd = new SqlCommand(backupCommand, conn))
                        {
                            // open the connection
                            await conn.OpenAsync();

                            // execute the command
                            await cmd.ExecuteNonQueryAsync();
                        }
                    }
                    */
                    Console.WriteLine("SQL Backup Successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL Backup Failed: " + ex.Message);
                    Application.DoEvents();
                }
            }
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             using (SqlConnection connection = new SqlConnection("Data Source=server;Initial Catalog=master;User ID=username;Password=password"))
            {
                try

                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT name FROM sys.databases", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clbBaze.Items.Add(reader["name"].ToString());
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error connecting to the database: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }*/
            /*
            using (SqlConnection connection = new SqlConnection("Data Source=cboServer.Text;Initial Catalog=master;User ID=txtUser;Password=txtPass"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT name FROM sys.databases", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clbBaze.Items.Add(reader.GetString(0));
                        }
                    }
                }
                connection.Close();
            }
            */


        }






        private void btnIzv_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

                // Set the folder browser's description
            folderBrowser.Description = "Select the folder you want to use";

                // Show the folder browser
                DialogResult result = folderBrowser.ShowDialog();

                // Check if the user selected a folder
                if (result == DialogResult.OK)
                {
                    // Get the selected folder's path
                    string selectedFolder = folderBrowser.SelectedPath;
                // Do something with the selected folder
                txtIzvestaji.Text = selectedFolder;
                }
            
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();

            // Set the file browser's filter
            fileBrowser.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";

            // Show the file browser
            DialogResult result = fileBrowser.ShowDialog();

            // Check if the user selected a file
            if (result == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFile = fileBrowser.FileName;
                // Do something with the selected file
                txtXML.Text = selectedFile;
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {

            XDocument xdoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("FormData",
                    new XElement("Server", txtServer.Text),
                    new XElement("Auth", txtWS.Text),
                    new XElement("User", txtUser.Text),
                    new XElement("Pass", txtPass.Text),
                    new XElement("Izvestaji", txtIzvestaji.Text),
                    new XElement("XML", txtXML.Text),
                    new XElement("Lokalno", txtLokalno.Text),
                    new XElement("Remote", txtRemote.Text),
                    new XElement("Temp", txtTemp.Text),
                    new XElement("Time", dtpTime.Value.ToString("HH:mm"))
                  
                )
            );

            xdoc.Save("parametri.xml");



            List<string> selectedDatabases = new List<string>();



            foreach (var item in clbBaze.CheckedItems)
            {
                selectedDatabases.Add(item.ToString());
    
            }

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("BazeZaBackup");
            doc.AppendChild(root);

            foreach (object item in selectedDatabases)
            {
                XmlElement newElement = doc.CreateElement("Item");
                newElement.InnerText = item.ToString();
                root.AppendChild(newElement);
            }

            doc.Save("BazeZaBackup.xml");
        }
        /* ovo ne koristim vise prelazim na txtServer umesto cboServera
         
        private void cboServer_MouseClick(object sender, MouseEventArgs e)
        {
            //if(cboServer.)
            if (cboServer.Items.Count == 0)
            {
                string myServer = Environment.MachineName;

                DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
                for (int i = 0; i < servers.Rows.Count; i++)
                {
                    if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                    {
                        if ((servers.Rows[i]["InstanceName"] as string) != null)
                            cboServer.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                        else
                            cboServer.Items.Add(servers.Rows[i]["ServerName"]);
                    }
                }
            }
            else { }
        }
        */

        private void clbBaze_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=txtServer.Text;Initial Catalog=master;User ID=txtUser;Password=txtPass"))
            {
                try

                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT name FROM sys.databases", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clbBaze.Items.Add(reader["name"].ToString());
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error connecting to the database: " + ex.Message);
                    Application.DoEvents();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string sourcePath = @txtIzvestaji.Text;
            string targetPath = @txtTemp.Text;
            string date = DateTime.Now.ToString("yyyyMMddHHmm");

            if (Directory.Exists(sourcePath))

            {
                string[] files = Directory.GetFiles(sourcePath);
                string folderName = new DirectoryInfo(sourcePath).Name;
                Directory.CreateDirectory(targetPath + "\\" + folderName + date);
                string target = Path.Combine(targetPath, folderName + date);
                string zipPath = Path.Combine(targetPath, folderName + date + ".zip");
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);
                    string destFile = Path.Combine(target, name);
                    File.Copy(file, destFile, true);
                }
                ZipFile.CreateFromDirectory(target, zipPath);
                Directory.Delete(target, true);
            }


            for (int i = 0; i < clbBaze.CheckedItems.Count; i++)
            {
                string server = txtServer.Text;
                string username = txtUser.Text;
                string password = txtPass.Text;
                string database = clbBaze.CheckedItems[i].ToString();
                string tempBackup = @txtTemp.Text;
                string dateBackup = DateTime.Now.ToString("yyyyMMddHHmmss");
                string backupFile = Path.Combine(tempBackup, database + dateBackup);
                string backupFileZ = Path.Combine(tempBackup, database + dateBackup+ ".bak");
                //string fileName = database+dateBackup+".bak";
                string zipFile = Path.Combine(tempBackup, database + dateBackup + ".zip"); 


                string connectionString = "Data Source=" + server + ";DataBase="+database+";User ID=" + username + ";Password=" + password;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"BACKUP DATABASE {database} TO DISK = '{backupFile}.bak'";
                        command.ExecuteNonQuery();
                    }
                    try
                    {
                        using (ZipArchive archive = new ZipArchive(new FileStream(zipFile, FileMode.Create), ZipArchiveMode.Create))
                        {
                            archive.CreateEntryFromFile(backupFileZ, Path.GetFileName(backupFileZ));
                        }
                        File.Delete(backupFileZ);
                    }
                    catch { }
                }

            }

            //kopiram XML fajl
            string xmlPathIn = txtXML.Text;
            string xmlPathOut = @txtTemp.Text;
            string xmlName = Path.Combine(xmlPathOut+"\\"+(Path.GetFileName(xmlPathIn)));

            if (File.Exists(xmlPathIn))

            {
                File.Copy(xmlPathIn,xmlName,true);
            }

            // FInish kopiram u lokalni folder

            string tempFolder = txtTemp.Text;
            string backupLokalno = txtLokalno.Text;
            string backupRemote = txtRemote.Text;
            string fileName= "test.txt"; 

            string sourceFile = System.IO.Path.Combine(tempFolder, fileName);
            string destFileLokalno = System.IO.Path.Combine(backupLokalno, fileName);
            string destFileRemote = System.IO.Path.Combine(backupLokalno, fileName);


            if (System.IO.Directory.Exists(tempFolder))
            {
                string[] files = System.IO.Directory.GetFiles(tempFolder);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFileLokalno = System.IO.Path.Combine(backupLokalno, fileName);
                    destFileRemote = System.IO.Path.Combine(backupRemote, fileName);
                    System.IO.File.Copy(s, destFileLokalno, true);
                    System.IO.File.Copy(s, destFileRemote, true);    
                }

                foreach (string file in Directory.EnumerateFiles(tempFolder))
                {
                    File.Delete(file);
                }
            }


        }

        private void btnSveBaze_Click(object sender, EventArgs e)
        {
            if (clbBaze.Items.Count > 0)
            {
                for (int i = 0; i < clbBaze.Items.Count; i++)
                {
                        clbBaze.SetItemChecked(i, true);
                }
            }
        }

        private void btnNijedna_Click(object sender, EventArgs e)
        {
            if (clbBaze.Items.Count > 0)
            {
                for (int i = 0; i < clbBaze.Items.Count; i++)
                {
                    clbBaze.SetItemChecked(i, false);
                }
            }
        }

        private void btnUcitajIzXml_Click(object sender, EventArgs e)
        {
            if (clbBaze.Items.Count > 0)
            {
                for (int i = 0; i < clbBaze.Items.Count; i++)
                {
                    clbBaze.SetItemChecked(i, false);
                }
            }

            List<string> xmlItems = new List<string>();
            XmlDocument docBaze = new XmlDocument();
            docBaze.Load("BazeZaBackup.xml");
            XmlNodeList nodes = docBaze.SelectNodes("//BazeZaBackup/Item");

            foreach (XmlNode node in nodes)
            {
                xmlItems.Add(node.InnerText);
            }

            if (clbBaze.Items.Count > 0)
            {
                for (int i = 0; i < clbBaze.Items.Count; i++)
                {
                    if (xmlItems.Contains(clbBaze.Items[i].ToString()))
                    {
                        clbBaze.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void btnLokalno_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            // Set the folder browser's description
            folderBrowser.Description = "Select the folder you want to use";

            // Show the folder browser
            DialogResult result = folderBrowser.ShowDialog();

            // Check if the user selected a folder
            if (result == DialogResult.OK)
            {
                // Get the selected folder's path
                string selectedFolder = folderBrowser.SelectedPath;
                // Do something with the selected folder
                txtLokalno.Text = selectedFolder;
            }
        }

        private void btnRemote_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            // Set the folder browser's description
            folderBrowser.Description = "Select the folder you want to use";

            // Show the folder browser
            DialogResult result = folderBrowser.ShowDialog();

            // Check if the user selected a folder
            if (result == DialogResult.OK)
            {
                // Get the selected folder's path
                string selectedFolder = folderBrowser.SelectedPath;
                // Do something with the selected folder
                txtRemote.Text = selectedFolder;
            }
        }

        private void btnTmp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            // Set the folder browser's description
            folderBrowser.Description = "Select the folder you want to use";

            // Show the folder browser
            DialogResult result = folderBrowser.ShowDialog();

            // Check if the user selected a folder
            if (result == DialogResult.OK)
            {
                // Get the selected folder's path
                string selectedFolder = folderBrowser.SelectedPath;
                // Do something with the selected folder
                txtTemp.Text = selectedFolder;
            }

        }

        private async void btnSchedule_Click(object sender, EventArgs e)
        {
            var timeFolder = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var xmlFilePath = timeFolder + @"\parametri.xml";
            //string filePath = @"C:\dates.xml"; // Replace with the path to your XML file
            XDocument document = XDocument.Load(xmlFilePath);
            XElement dateElement = document.Root.Element("Time");

            if (dateElement != null)
            {
                DateTime time = DateTime.ParseExact(dateElement.Value, "HH:mm", null);
                dtpTime.Value = time;

                string hours = time.ToString("HH");
                string minutes = time.ToString("mm");

                int iHH;
                if (int.TryParse(hours, out iHH))
                {
                    // success, result is now 123
                }
                else
                {
                    // str could not be parsed as an int
                }

                int imm;
                if (int.TryParse(minutes, out imm))
                {
                    // success, result is now 123
                }
                else
                {
                    // str could not be parsed as an int
                }


                // create scheduler factory
                ISchedulerFactory schedulerFactory = new StdSchedulerFactory();

                // create scheduler
                IScheduler scheduler = await schedulerFactory.GetScheduler();

                // create job
                IJobDetail job = JobBuilder.Create<SqlBackupJob>().Build();

                // create trigger
                ITrigger trigger = TriggerBuilder.Create()
                    .WithDailyTimeIntervalSchedule
                      (s =>
                         s.WithIntervalInHours(24)
                        .OnEveryDay()
                        .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(iHH,imm))
                      )
                    .Build();

                // schedule job
                scheduler.ScheduleJob(job, trigger);

                // start scheduler
                scheduler.Start();
            }
            
        }

        private void btnUcitajBaze_Click(object sender, EventArgs e)
        {
            clbBaze.Items.Clear();
            string server = txtServer.Text;
            string username = txtUser.Text;
            string password = txtPass.Text;
            string connectionString = "Data Source=" + server + ";DataBase=master;User ID=" + username + ";Password=" + password;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT name FROM sys.databases  WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clbBaze.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Neuspešna konekcija sa zadatim parametrima proverite parametre za konekciju " + ex.Message);
                }
            }
        }

    }
}
