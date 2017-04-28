using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Deployment.Application;

namespace ExportImportDotNetTray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Program.CheckForUpdateAndInstallIt() != -1)
            {
                Application.Restart();
            }
            else
            {
                MainForm myForm = new MainForm();
                Application.Run();
            }
        }

        public static int CheckForUpdateAndInstallIt()
        {
            int retVal = -1;

            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return -101;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return -102;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return -103;
                }

                if (info.UpdateAvailable)
                {
                    try
                    {
                        ad.Update();
                        //MessageBox.Show("The application has been upgraded, and will now restart.");                        
                        return 0;
                    }
                    catch (DeploymentDownloadException dde)
                    {
                        MessageBox.Show("Nemoze sa nainstalovat najnovsia verzia programu. \n\nProsim zavolajte testovacieho inziniera.\n\n" + dde);
                        return -200;
                    }

                }
                else
                {
                    return retVal;
                }

            }
            return retVal;
        }
    }
}
