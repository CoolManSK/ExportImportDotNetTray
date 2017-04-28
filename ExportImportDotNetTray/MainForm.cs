using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Deployment.Application;

using ExportImportDotNetTray.OtherForms;


namespace ExportImportDotNetTray
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Hide();

            Int32 n_majorOSVersion = Environment.OSVersion.Version.Major;

            if (n_majorOSVersion == 5) this.ConfigPath = @"C:\Documents and Settings\All Users\Application Data\ExportImport\";
            else if (n_majorOSVersion == 6) this.ConfigPath = @"C:\Users\Public\ExportImport\";
            else
            {
                this.ErrorMessageBoxShow("Neznama verzia operacneho systemu. Zavolajte prosim testovacieho inziniera");
                this.Dispose();
                return;
            }

            if (!File.Exists(String.Concat(this.ConfigPath, "ExportImportConfig.xml")))
            {
                if (!this.GenerateDefaultXMLConfiguration())
                {                    
                    MessageBox.Show("Fatal Error. Call Test Engineer");
                    this.Dispose();
                    return;
                }
            }
            
            myXMLConfig = new XmlDocument();
            myXMLConfig.Load(String.Concat(this.ConfigPath, "ExportImportConfig.xml"));

            this.CheckIntegrityOfXMLConfig();

            XmlNode bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/ShowNotificationsExport");
            if (bufferNode.InnerText == "Y")
            {
                this.showNotificationsExport = true;
            }

            bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/ShowNotificationsImport");
            if (bufferNode.InnerText == "Y")
            {
                this.showNotificationsImport = true;
            }

            this.timer_Main.Interval = Convert.ToInt32(myXMLConfig.SelectSingleNode("./Configuration/StartupInterval").InnerText) * 1000;
            this.timer_Main.Start();
            this.timer_HTML.Interval = Convert.ToInt32(myXMLConfig.SelectSingleNode("./Configuration/HTML/Interval").InnerText) * 1000;
            if (!Convert.ToBoolean(myXMLConfig.SelectSingleNode("./Configuration/HTML/Disable").InnerText)) this.timer_HTML.Start();
            this.timer_XML.Interval = Convert.ToInt32(myXMLConfig.SelectSingleNode("./Configuration/XML/Interval").InnerText) * 1000;
            if (!Convert.ToBoolean(myXMLConfig.SelectSingleNode("./Configuration/XML/Disable").InnerText)) this.timer_XML.Start();

        }

        private String ConfigPath = "";
        private XmlDocument myXMLConfig;
        private Boolean afterUpdate = false;
        private Boolean showNotificationsImport = false;
        private Boolean showNotificationsExport = false;

        private Boolean GenerateDefaultXMLConfiguration()
        {
            Boolean retValue = true;

            try
            {                
                if (!Directory.Exists(this.ConfigPath))
                {
                    Directory.CreateDirectory(this.ConfigPath);
                    this.timer_Main.Stop();
                }
                if (!Directory.Exists(this.ConfigPath)) MessageBox.Show("Chyba -1");
                File.Copy("ConfigFiles/ExportImportConfig.xml", String.Concat(this.ConfigPath, "ExportImportConfig.xml"));
                return retValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Concat("Fatal Error. Original error: ", ex.Message, " Call Test Engineer."));
                return false;
            }
        }
        private void MoveDirectoryContent(String SourceDirectory, String DestinationDirectory, String FileFilter, Boolean IncludeSubdirs)
        {
            if (IncludeSubdirs)
            {
                foreach (String actDir in Directory.GetDirectories(SourceDirectory))
                {
                    String newDestDir = String.Concat(DestinationDirectory, actDir.Substring(0, actDir.Length - 1).Substring(actDir.LastIndexOf('\\')), '\\');
                    if (!Directory.Exists(newDestDir))
                    {
                        Directory.CreateDirectory(newDestDir);
                    }
                    this.MoveDirectoryContent(actDir, newDestDir, FileFilter, IncludeSubdirs);
                }
            }
            if (Directory.Exists(SourceDirectory) && Directory.Exists(DestinationDirectory))
            {
                foreach (String actFile in Directory.GetFiles(SourceDirectory))
                {
                    FileInfo fi = new FileInfo(actFile);
                    if (fi.Length == 0) continue;
                    if ((actFile.Substring(actFile.Length - FileFilter.Length).ToUpper() == FileFilter) || (FileFilter == ".*"))
                    {
                        if (!File.Exists(actFile)) continue;
                        try
                        {   
                            String newFilePath = String.Concat(DestinationDirectory, actFile.Substring(actFile.LastIndexOf("\\") + 1));
                            if (File.Exists(newFilePath))
                            {
                                try
                                {
                                    File.Replace(actFile, newFilePath, null);
                                }
                                catch
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                try
                                {
                                    File.Move(actFile, newFilePath);
                                }
                                catch
                                {
                                    Application.Exit();
                                }
                            }
                        }
                        catch
                        {
                            //MessageBox.Show(String.Concat(ex.Message, "\n", actFile, "\n", DestinationDirectory, "\nMove Operation"));
                        }
                    }
                }
            }
        }
        private void CopyDirectoryContent(String SourceDirectory, String DestinationDirectory, String FileFilter, Boolean IncludeSubdirs)
        {
            if (Directory.Exists(DestinationDirectory) && Directory.Exists(SourceDirectory))
            {
                if (IncludeSubdirs)
                {
                    foreach (String actDir in Directory.GetDirectories(SourceDirectory))
                    {
                        String newDestDir = String.Concat(DestinationDirectory, actDir.Substring(0, actDir.Length).Substring(actDir.LastIndexOf('\\') + 1), "\\");
                        if (!Directory.Exists(newDestDir))
                        {                            
                            Directory.CreateDirectory(newDestDir);
                        }
                        this.CopyDirectoryContent(actDir, newDestDir, FileFilter, IncludeSubdirs);
                    }
                }
                foreach (String actFile in Directory.GetFiles(SourceDirectory))
                {
                    FileInfo fi = new FileInfo(actFile);
                    if (fi.Length == 0) continue;                    
                    if ((actFile.Substring(actFile.Length - FileFilter.Length).ToUpper() == FileFilter) || (FileFilter == ".*"))
                    {
                        if (File.Exists(String.Concat(DestinationDirectory, actFile.Substring(actFile.LastIndexOf("\\") + 1))))
                        {
                            FileInfo actFI_source = new FileInfo(actFile);
                            FileInfo actFi_destination = new FileInfo(String.Concat(DestinationDirectory, actFile.Substring(actFile.LastIndexOf("\\") + 1)));
                            if (actFI_source.LastWriteTimeUtc != actFi_destination.LastWriteTimeUtc)
                            {
                                try
                                {
                                    File.Copy(actFile, String.Concat(DestinationDirectory, actFile.Substring(actFile.LastIndexOf("\\") + 1)), true);
                                }
                                catch
                                {
                                    Application.Exit();
                                    //MessageBox.Show(String.Concat(ex.Message, "\n", actFile, "\n", DestinationDirectory, "\nCopy Operation"));
                                }
                            }
                        }
                        else
                        {
                            try
                            {
                                
                                File.Copy(actFile, String.Concat(DestinationDirectory, actFile.Substring(actFile.LastIndexOf("\\") + 1)), true);
                                
                            }
                            catch //(Exception ex)
                            {
                                Application.Exit();
                                //MessageBox.Show(String.Concat(ex.Message, "\n", actFile, "\n", DestinationDirectory, "\nCopy Operation"));
                            }
                        }
                    }
                }
            }
        }
        private void ErrorMessageBoxShow(String Message)
        {
            MessageBox.Show(Message, "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void CheckIntegrityOfXMLConfig()
        {
            foreach (XmlNode actNode in this.myXMLConfig.SelectSingleNode("./Configuration").ChildNodes)
            {
                XmlNode DisableNode = actNode.SelectSingleNode("./Disable");
                if (DisableNode != null)
                {
                    XmlNode IncludeSubdirsNode = actNode.SelectSingleNode("/IncludeSubdirs");
                    if (IncludeSubdirsNode == null)
                    {
                        XmlElement newElem = this.myXMLConfig.CreateElement("IncludeSubdirs");
                        newElem.InnerText = "0"; // Default Value 0 = Disable; 1 - Enabled
                        actNode.AppendChild(newElem);
                        this.myXMLConfig.Save(this.myXMLConfig.BaseURI.Substring(this.myXMLConfig.BaseURI.IndexOf("//") + 3));
                    }
                }
            }
            XmlNode ShowNotificationsExportNode = this.myXMLConfig.SelectSingleNode("./Configuration/ShowNotificationsExport");
            if (ShowNotificationsExportNode == null)
            {
                XmlNode newNode = this.myXMLConfig.CreateNode("element", "ShowNotificationsExport", "");
                newNode.InnerText = "N";
                this.myXMLConfig.SelectSingleNode("./Configuration").AppendChild(newNode);
                this.myXMLConfig.Save(this.myXMLConfig.BaseURI.Substring(this.myXMLConfig.BaseURI.IndexOf("C:/")));
            }

            XmlNode ShowNotificationsImportNode = this.myXMLConfig.SelectSingleNode("./Configuration/ShowNotificationsImport");
            if (ShowNotificationsImportNode == null)
            {
                XmlNode newNode = this.myXMLConfig.CreateNode("element", "ShowNotificationsImport", "");
                newNode.InnerText = "N";
                this.myXMLConfig.SelectSingleNode("./Configuration").AppendChild(newNode);
                this.myXMLConfig.Save(this.myXMLConfig.BaseURI.Substring(this.myXMLConfig.BaseURI.IndexOf("C:/")));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            XmlNode bufferNode = myXMLConfig.SelectSingleNode("./Configuration/XML");
            this.chB_XMLDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_XmlSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_XmlDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            this.nud_XML.Value = Convert.ToInt32(bufferNode.SelectSingleNode("./Interval").InnerText);
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_XML_IncSub.Checked = false;
            else this.chb_XML_IncSub.Checked = true;

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/HTML");
            this.chB_HTMLDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_HtmlSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_HtmlDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            this.nud_HTML.Value = Convert.ToInt32(bufferNode.SelectSingleNode("./Interval").InnerText);
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_HTML_IncSub.Checked = false;
            else this.chb_HTML_IncSub.Checked = true;

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/DLL");
            this.chB_TestmodulesDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_TestmodulesSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_TestmodulesDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_TESTMODULES_IncSub.Checked = false;
            else this.chb_TESTMODULES_IncSub.Checked = true;

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/UINI");
            this.chB_UsersDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_UsersSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_UsersDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_USERS_IncSub.Checked = false;
            else this.chb_USERS_IncSub.Checked = true;

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/CINI");
            this.chB_ConfigsDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_ConfigsSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_ConfigsDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_CONFIGS_IncSub.Checked = false;
            else this.chb_CONFIGS_IncSub.Checked = true;

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/TINI");
            this.chB_TypesDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_TypesSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_TypesDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_TYPES_IncSub.Checked = false;
            else this.chb_TYPES_IncSub.Checked = true;

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/TPS");
            this.chB_TestProgramsDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_TestProgramsSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_TestProgramsDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_TESTPROGRAMS_IncSub.Checked = false;
            else this.chb_TESTPROGRAMS_IncSub.Checked = true;

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/SEQ");
            this.chB_ModelsDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_ModelsSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_ModelsDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_MODELS_IncSub.Checked = false;
            else this.chb_MODELS_IncSub.Checked = true;

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/BelMES");
            this.chB_BelMESDisable.Checked = Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText);
            this.tb_BelMESSourcePath.Text = bufferNode.SelectSingleNode("./SourcePath").InnerText;
            this.tb_BelMESDestinationPath.Text = bufferNode.SelectSingleNode("./DestinationPath").InnerText;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "0") this.chb_BELMES_IncSub.Checked = false;
            else this.chb_BELMES_IncSub.Checked = true;            

            this.timer_Main.Stop();
            this.timer_HTML.Stop();
            this.timer_XML.Stop();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.timer_Main.Interval = Convert.ToInt32(myXMLConfig.SelectSingleNode("./Configuration/StartupInterval").InnerText) * 1000;
            this.timer_Main.Start();
            this.timer_HTML.Interval = Convert.ToInt32(myXMLConfig.SelectSingleNode("./Configuration/HTML/Interval").InnerText) * 1000;
            if (!Convert.ToBoolean(myXMLConfig.SelectSingleNode("./Configuration/HTML/Disable").InnerText)) this.timer_HTML.Start();
            this.timer_XML.Interval = Convert.ToInt32(myXMLConfig.SelectSingleNode("./Configuration/XML/Interval").InnerText) * 1000;
            if (!Convert.ToBoolean(myXMLConfig.SelectSingleNode("./Configuration/XML/Disable").InnerText)) this.timer_XML.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TrayIcon.Dispose();
            Application.Exit();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.setupToolStripMenuItem_Click(new object(), new EventArgs());
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.timer_Main.Stop();
            LoginForm myLoginForm = new LoginForm();
            myLoginForm.ShowDialog();
            if (!myLoginForm.Validation) return;
            else
            {
                this.ShowDialog();
                //this.timer_Main.Start();
            }            
            myLoginForm.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!afterUpdate)
            {
                e.Cancel = true;
                this.Hide();
                this.timer_Main.Start();
                this.timer_HTML.Interval = Convert.ToInt32(myXMLConfig.SelectSingleNode("./Configuration/HTML/Interval").InnerText) * 1000;
                if (!Convert.ToBoolean(myXMLConfig.SelectSingleNode("./Configuration/HTML/Disable").InnerText)) this.timer_HTML.Start();
                this.timer_XML.Interval = Convert.ToInt32(myXMLConfig.SelectSingleNode("./Configuration/XML/Interval").InnerText) * 1000;
                if (!Convert.ToBoolean(myXMLConfig.SelectSingleNode("./Configuration/XML/Disable").InnerText)) this.timer_XML.Start();
            }
            this.afterUpdate = false;
            base.OnFormClosing(e);
        }

        private void btn_SaveAll_Click(object sender, EventArgs e)
        {
            XmlNode bufferNode = myXMLConfig.SelectSingleNode("./Configuration/XML");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_XMLDisable.Checked.ToString().ToLower();
            if (this.tb_XmlSourcePath.Text.Length > 0)
            {
                if (this.tb_XmlSourcePath.Text.Substring(this.tb_XmlSourcePath.Text.Length - 1) != @"\")
                    this.tb_XmlSourcePath.Text = String.Concat(this.tb_XmlSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_XmlSourcePath.Text;

            if (this.tb_XmlDestinationPath.Text.Length > 0)
            {
                if (this.tb_XmlDestinationPath.Text.Substring(this.tb_XmlDestinationPath.Text.Length - 1) != @"\")
                    this.tb_XmlDestinationPath.Text = String.Concat(this.tb_XmlDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_XmlDestinationPath.Text;
            bufferNode.SelectSingleNode("./Interval").InnerText = this.nud_XML.Value.ToString();
            if (this.chb_XML_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";

            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/HTML");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_HTMLDisable.Checked.ToString().ToLower();
            if (this.tb_HtmlSourcePath.Text.Length > 0)
            {
                if (this.tb_HtmlSourcePath.Text.Substring(this.tb_HtmlSourcePath.Text.Length - 1) != @"\")
                    this.tb_HtmlSourcePath.Text = String.Concat(this.tb_HtmlSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_HtmlSourcePath.Text;

            if (this.tb_HtmlDestinationPath.Text.Length > 0)
            {
                if (this.tb_HtmlDestinationPath.Text.Substring(this.tb_HtmlDestinationPath.Text.Length - 1) != @"\")
                    this.tb_HtmlDestinationPath.Text = String.Concat(this.tb_HtmlDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_HtmlDestinationPath.Text;
            bufferNode.SelectSingleNode("./Interval").InnerText = this.nud_HTML.Value.ToString();
            if (this.chb_HTML_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";


            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/DLL");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_TestmodulesDisable.Checked.ToString().ToLower();
            if (this.tb_TestmodulesSourcePath.Text.Length > 0)
            {
                if (this.tb_TestmodulesSourcePath.Text.Substring(this.tb_TestmodulesSourcePath.Text.Length - 1) != @"\")
                    this.tb_TestmodulesSourcePath.Text = String.Concat(this.tb_TestmodulesSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_TestmodulesSourcePath.Text;

            if (this.tb_TestmodulesDestinationPath.Text.Length > 0)
            {
                if (this.tb_TestmodulesDestinationPath.Text.Substring(this.tb_TestmodulesDestinationPath.Text.Length - 1) != @"\")
                    this.tb_TestmodulesDestinationPath.Text = String.Concat(this.tb_TestmodulesDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_TestmodulesDestinationPath.Text;
            if (this.chb_TESTMODULES_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";


            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/UINI");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_UsersDisable.Checked.ToString().ToLower();
            if (this.tb_UsersSourcePath.Text.Length > 0)
            {
                if (this.tb_UsersSourcePath.Text.Substring(this.tb_UsersSourcePath.Text.Length - 1) != @"\")
                    this.tb_UsersSourcePath.Text = String.Concat(this.tb_UsersSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_UsersSourcePath.Text;

            if (this.tb_UsersDestinationPath.Text.Length > 0)
            {
                if (this.tb_UsersDestinationPath.Text.Substring(this.tb_UsersDestinationPath.Text.Length - 1) != @"\")
                    this.tb_UsersDestinationPath.Text = String.Concat(this.tb_UsersDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_UsersDestinationPath.Text;
            if (this.chb_USERS_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";


            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/CINI");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_ConfigsDisable.Checked.ToString().ToLower();
            if (this.tb_ConfigsSourcePath.Text.Length > 0)
            {
                if (this.tb_ConfigsSourcePath.Text.Substring(this.tb_ConfigsSourcePath.Text.Length - 1) != @"\")
                    this.tb_ConfigsSourcePath.Text = String.Concat(this.tb_ConfigsSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_ConfigsSourcePath.Text;

            if (this.tb_ConfigsDestinationPath.Text.Length > 0)
            {
                if (this.tb_ConfigsDestinationPath.Text.Substring(this.tb_ConfigsDestinationPath.Text.Length - 1) != @"\")
                    this.tb_ConfigsDestinationPath.Text = String.Concat(this.tb_ConfigsDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_ConfigsDestinationPath.Text;
            if (this.chb_CONFIGS_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";


            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/TINI");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_TypesDisable.Checked.ToString().ToLower();
            if (this.tb_TypesSourcePath.Text.Length > 0)
            {
                if (this.tb_TypesSourcePath.Text.Substring(this.tb_TypesSourcePath.Text.Length - 1) != @"\")
                    this.tb_TypesSourcePath.Text = String.Concat(this.tb_TypesSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_TypesSourcePath.Text;

            if (this.tb_TypesDestinationPath.Text.Length > 0)
            {
                if (this.tb_TypesDestinationPath.Text.Substring(this.tb_TypesDestinationPath.Text.Length - 1) != @"\")
                    this.tb_TypesDestinationPath.Text = String.Concat(this.tb_TypesDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_TypesDestinationPath.Text;
            if (this.chb_TYPES_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";


            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/TPS");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_TestProgramsDisable.Checked.ToString().ToLower();
            if (this.tb_TestProgramsSourcePath.Text.Length > 0)
            {
                if (this.tb_TestProgramsSourcePath.Text.Substring(this.tb_TestProgramsSourcePath.Text.Length - 1) != @"\")
                    this.tb_TestProgramsSourcePath.Text = String.Concat(this.tb_TestProgramsSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_TestProgramsSourcePath.Text;

            if (this.tb_TestProgramsDestinationPath.Text.Length > 0)
            {
                if (this.tb_TestProgramsDestinationPath.Text.Substring(this.tb_TestProgramsDestinationPath.Text.Length - 1) != @"\")
                    this.tb_TestProgramsDestinationPath.Text = String.Concat(this.tb_TestProgramsDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_TestProgramsDestinationPath.Text;
            if (this.chb_TESTPROGRAMS_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";


            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/SEQ");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_ModelsDisable.Checked.ToString().ToLower();
            if (this.tb_ModelsSourcePath.Text.Length > 0)
            {
                if (this.tb_ModelsSourcePath.Text.Substring(this.tb_ModelsSourcePath.Text.Length - 1) != @"\")
                    this.tb_ModelsSourcePath.Text = String.Concat(this.tb_ModelsSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_ModelsSourcePath.Text;

            if (this.tb_ModelsDestinationPath.Text.Length > 0)
            {
                if (this.tb_ModelsDestinationPath.Text.Substring(this.tb_ModelsDestinationPath.Text.Length - 1) != @"\")
                    this.tb_ModelsDestinationPath.Text = String.Concat(this.tb_ModelsDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_ModelsDestinationPath.Text;
            if (this.chb_MODELS_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";


            bufferNode = myXMLConfig.SelectSingleNode("./Configuration/BelMES");
            bufferNode.SelectSingleNode("./Disable").InnerText = this.chB_BelMESDisable.Checked.ToString().ToLower();
            if (this.tb_BelMESSourcePath.Text.Length > 0)
            {
                if (this.tb_BelMESSourcePath.Text.Substring(this.tb_BelMESSourcePath.Text.Length - 1) != @"\")
                    this.tb_BelMESSourcePath.Text = String.Concat(this.tb_BelMESSourcePath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./SourcePath").InnerText = this.tb_BelMESSourcePath.Text;

            if (this.tb_BelMESDestinationPath.Text.Length > 0)
            {
                if (this.tb_BelMESDestinationPath.Text.Substring(this.tb_BelMESDestinationPath.Text.Length - 1) != @"\")
                    this.tb_BelMESDestinationPath.Text = String.Concat(this.tb_BelMESDestinationPath.Text, @"\");
            }
            bufferNode.SelectSingleNode("./DestinationPath").InnerText = this.tb_BelMESDestinationPath.Text;
            if (this.chb_BELMES_IncSub.Checked) bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "1";
            else bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText = "0";


            this.myXMLConfig.Save(this.myXMLConfig.BaseURI.Substring(this.myXMLConfig.BaseURI.IndexOf("//") + 3));
        }

        private void btn_XmlSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_XmlSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_XmlSourcePath.Text;                
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_XmlSourcePath.Text = myFBD.SelectedPath;
        }

        private void btn_XmlDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_XmlDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_XmlDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_XmlDestinationPath.Text = myFBD.SelectedPath;            
        }

        private void btn_HtmlSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_HtmlSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_HtmlSourcePath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_HtmlSourcePath.Text = myFBD.SelectedPath;            
        }

        private void btn_HtmlDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_HtmlDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_HtmlDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_HtmlDestinationPath.Text = myFBD.SelectedPath;
        }

        private void btn_TypesSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_TypesSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_TypesSourcePath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_TypesSourcePath.Text = myFBD.SelectedPath;
        }

        private void btn_TypesDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_TypesDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_TypesDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_TypesDestinationPath.Text = myFBD.SelectedPath;
        }

        private void btn_TestmodulesSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_TestmodulesSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_TestmodulesSourcePath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_TestmodulesSourcePath.Text = myFBD.SelectedPath;
        }

        private void btn_TestmodulesDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_TestmodulesDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_TestmodulesDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_TestmodulesDestinationPath.Text = myFBD.SelectedPath;
        }

        private void btn_UsersSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_UsersSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_UsersSourcePath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_UsersSourcePath.Text = myFBD.SelectedPath;
        }

        private void btn_UsersDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_UsersDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_UsersDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_UsersDestinationPath.Text = myFBD.SelectedPath;
        }

        private void btn_ConfigsSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_ConfigsSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_ConfigsSourcePath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_ConfigsSourcePath.Text = myFBD.SelectedPath;
        }

        private void btn_ConfigsDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_ConfigsDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_ConfigsDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_ConfigsDestinationPath.Text = myFBD.SelectedPath;
        }

        private void btn_ModelsSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_ModelsSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_ModelsSourcePath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_ModelsSourcePath.Text = myFBD.SelectedPath;
        }

        private void btn_ModelsDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_ModelsDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_ModelsDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_ModelsDestinationPath.Text = myFBD.SelectedPath;
        }

        private void btn_TestProgramsSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_TestProgramsSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_TestProgramsSourcePath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_TestProgramsSourcePath.Text = myFBD.SelectedPath;
        }

        private void btn_TestProgramsDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_TestProgramsDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_TestProgramsDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_TestProgramsDestinationPath.Text = myFBD.SelectedPath;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myAForm = new AboutForm();
            myAForm.ShowDialog();
        }
        
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            this.timer_Main.Stop();

            if (this.showNotificationsImport)
            {
                this.TrayIcon.BalloonTipText = "Import start.";
                this.TrayIcon.ShowBalloonTip(2000);
            }

            try
            {
                XmlNode bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/DLL");
                if (!Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText))
                {
                    Boolean b_IncludeSubdirs = false;
                    if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                        b_IncludeSubdirs = true;
                    this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".*", b_IncludeSubdirs);
                    //this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".UIR", b_IncludeSubdirs);
                }

                bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/UINI");
                if (!Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText))
                {
                    Boolean b_IncludeSubdirs = false;
                    if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                        b_IncludeSubdirs = true;
                    this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".*", b_IncludeSubdirs);
                }

                bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/CINI");
                if (!Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText))
                {
                    Boolean b_IncludeSubdirs = false;
                    if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                        b_IncludeSubdirs = true;
                    this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".*", b_IncludeSubdirs);
                    //this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".UDL", b_IncludeSubdirs);
                }

                bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/TINI");
                if (!Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText))
                {
                    Boolean b_IncludeSubdirs = false;
                    if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                        b_IncludeSubdirs = true;
                    this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".*", b_IncludeSubdirs);
                }

                bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/TPS");
                if (!Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText))
                {
                    Boolean b_IncludeSubdirs = false;
                    if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                        b_IncludeSubdirs = true;
                    this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".*", b_IncludeSubdirs);
                }

                bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/SEQ");
                if (!Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText))
                {
                    Boolean b_IncludeSubdirs = false;
                    if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                        b_IncludeSubdirs = true;
                    this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".*", b_IncludeSubdirs);
                }

                bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/BelMES");
                if (!Convert.ToBoolean(bufferNode.SelectSingleNode("./Disable").InnerText))
                {
                    Boolean b_IncludeSubdirs = false;
                    if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                        b_IncludeSubdirs = true;
                    this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".*", b_IncludeSubdirs);
                    //this.CopyDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".INI", b_IncludeSubdirs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (this.showNotificationsImport)
            {
                this.TrayIcon.BalloonTipText = "Import done.";
                this.TrayIcon.ShowBalloonTip(2000);
            }
        }

        private void btn_ImportAll_Click(object sender, EventArgs e)
        {
            this.MainTimer_Tick(new object(), new EventArgs());
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainTimer_Tick(new object(), new EventArgs());
        }

        private void timer_XML_Tick(object sender, EventArgs e)
        {
            XmlNode bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/XML");
            Boolean b_IncludeSubdirs = false;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                b_IncludeSubdirs = true;
            this.MoveDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".XML", b_IncludeSubdirs);
            if (this.showNotificationsExport)
            {
                this.TrayIcon.BalloonTipText = "Export of XML reports was succesfully done.";
                this.TrayIcon.ShowBalloonTip(2000);
            }            
        }

        private void timer_HTML_Tick(object sender, EventArgs e)
        {
            XmlNode bufferNode = this.myXMLConfig.SelectSingleNode("./Configuration/HTML");
            Boolean b_IncludeSubdirs = false;
            if (bufferNode.SelectSingleNode("./IncludeSubdirs").InnerText == "1")
                b_IncludeSubdirs = true;
            this.MoveDirectoryContent(bufferNode.SelectSingleNode("./SourcePath").InnerText, bufferNode.SelectSingleNode("./DestinationPath").InnerText, ".HTML", b_IncludeSubdirs);
            if (this.showNotificationsExport)
            {
                this.TrayIcon.BalloonTipText = "Export of HTML reports was succesfully done.";
                this.TrayIcon.ShowBalloonTip(2000);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.timer_HTML_Tick(new object(), new EventArgs());
            this.timer_XML_Tick(new object(), new EventArgs());
        }

        private void chB_XMLDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_XMLDisable.Checked) this.gb_XML.Enabled = false;
            else this.gb_XML.Enabled = true;
        }

        private void chB_HTMLDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_HTMLDisable.Checked) this.gb_HTML.Enabled = false;
            else this.gb_HTML.Enabled = true;
        }

        private void chB_TypesDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_TypesDisable.Checked) this.gb_Types.Enabled = false;
            else this.gb_Types.Enabled = true;
        }

        private void chB_TestmodulesDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_TestmodulesDisable.Checked) this.gb_Testmodules.Enabled = false;
            else this.gb_Testmodules.Enabled = true;
        }

        private void chB_UsersDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_UsersDisable.Checked) this.gb_Users.Enabled = false;
            else this.gb_Users.Enabled = true;
        }

        private void chB_ConfigsDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_ConfigsDisable.Checked) this.gb_Configs.Enabled = false;
            else this.gb_Configs.Enabled = true;
        }

        private void chB_ModelsDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_ModelsDisable.Checked) this.gb_Models.Enabled = false;
            else this.gb_Models.Enabled = true;
        }

        private void chB_TestProgramsDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_TestProgramsDisable.Checked) this.gb_TestPrograms.Enabled = false;
            else this.gb_TestPrograms.Enabled = true;
        }

        private void btn_BelMESSourcePathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_BelMESSourcePath.Text))
            {
                myFBD.SelectedPath = this.tb_BelMESSourcePath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_BelMESSourcePath.Text = myFBD.SelectedPath;
        }

        private void btn_BelMESDestinationPathSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFBD = new FolderBrowserDialog();
            if (Directory.Exists(this.tb_BelMESDestinationPath.Text))
            {
                myFBD.SelectedPath = this.tb_BelMESDestinationPath.Text;
            }
            else
            {
                myFBD.SelectedPath = @"C:\";
            }
            myFBD.ShowDialog();
            this.tb_BelMESDestinationPath.Text = myFBD.SelectedPath;
        }

        private void chB_BelMESDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chB_BelMESDisable.Checked) this.gb_BelMES.Enabled = false;
            else this.gb_BelMES.Enabled = true;
        }

        private void showHideNotificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.showNotificationsImport)
            {
                this.showNotificationsImport = false;
                XmlNode bufNode = this.myXMLConfig.SelectSingleNode("./Configuration/ShowNotificationsImport");
                bufNode.InnerText = "N";
                this.myXMLConfig.Save(this.myXMLConfig.BaseURI.Substring(this.myXMLConfig.BaseURI.IndexOf("C:/")));
                this.TrayIcon.BalloonTipText = "Import notifications disabled.";
                this.TrayIcon.ShowBalloonTip(2000);                
            }
            else
            {
                this.showNotificationsImport = true;
                XmlNode bufNode = this.myXMLConfig.SelectSingleNode("./Configuration/ShowNotificationsImport");
                bufNode.InnerText = "Y";
                this.myXMLConfig.Save(this.myXMLConfig.BaseURI.Substring(this.myXMLConfig.BaseURI.IndexOf("C:/")));
                this.TrayIcon.BalloonTipText = "Import notifications enabled.";
                this.TrayIcon.ShowBalloonTip(2000);
            }
        }

        private void showHideExportNotificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.showNotificationsExport)
            {
                this.showNotificationsExport = false;
                XmlNode bufNode = this.myXMLConfig.SelectSingleNode("./Configuration/ShowNotificationsExport");
                bufNode.InnerText = "N";
                this.myXMLConfig.Save(this.myXMLConfig.BaseURI.Substring(this.myXMLConfig.BaseURI.IndexOf("C:/")));
                this.TrayIcon.BalloonTipText = "Export notifications disabled.";
                this.TrayIcon.ShowBalloonTip(2000);
            }
            else
            {
                this.showNotificationsExport = true;
                XmlNode bufNode = this.myXMLConfig.SelectSingleNode("./Configuration/ShowNotificationsExport");
                bufNode.InnerText = "Y";
                this.myXMLConfig.Save(this.myXMLConfig.BaseURI.Substring(this.myXMLConfig.BaseURI.IndexOf("C:/")));
                this.TrayIcon.BalloonTipText = "Export notifications enabled.";
                this.TrayIcon.ShowBalloonTip(2000);
            }
        }
    }
}
