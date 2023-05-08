using Microsoft.Win32;

namespace Ark
{
    public partial class Form1 : Form
    {
        private const string MenuName = "*\\shell\\NewMenuOption";
        private const string Command = "*\\shell\\NewMenuOption\\command";
        public string FoundationPath = "";

        public Form1()
        {
            if(Properties.Settings.Default.FirstRun == true)
            {
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("This appears to be your first time using this. Please set your HEK locations before continuing.");
                settings();
            }
            InitializeComponent();
            FoundationPath = Environment.CurrentDirectory + "\\Ark.exe %1";
        }

        private void settings()
        {
            SettingsForm settingsform = new SettingsForm();
            settingsform.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            RegistryKey regmenu = null;
            RegistryKey regcmd = null;

            try
            {
                regmenu = Registry.ClassesRoot.CreateSubKey(MenuName);
                if (regmenu != null)
                    regmenu.SetValue("", "Open With HEK");
                regcmd = Registry.ClassesRoot.CreateSubKey(Command);
                if (regcmd != null)
                    regcmd.SetValue("", FoundationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to update context menu, try running as an Administrator!");
            }
            finally
            {
                if (regmenu != null)
                    regmenu.Close();
                if (regcmd != null)
                    regcmd.Close();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey reg = Registry.ClassesRoot.OpenSubKey(Command);
                if (reg != null)
                {
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(Command);
                }
                reg = Registry.ClassesRoot.OpenSubKey(MenuName);
                if (reg != null)
                {
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(MenuName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to update context menu, try running as an Administrator!");
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            settings();
        }
    }
}