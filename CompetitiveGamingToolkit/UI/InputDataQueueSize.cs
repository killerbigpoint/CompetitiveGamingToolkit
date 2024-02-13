using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetitiveGamingToolkit.UI
{
    public partial class InputDataQueueSize : MetroForm
    {
        private const string mouseKeyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters";
        private const string mouseValueName = "MouseDataQueueSize";
        private const int mouseDefaultValue = 100;

        private const string keyboardKeyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\kbdclass\\Parameters";
        private const string keyboardValueName = "KeyboardDataQueueSize";
        private const int keyboardDefaultValue = 100;

        public InputDataQueueSize()
        {
            InitializeComponent();
        }

        public void RefreshRegistryValues()
        {
            int mouseQueueSize = (int)Registry.GetValue(mouseKeyName, mouseValueName, mouseDefaultValue);
            mouseDataSizeTextbox.Text = mouseQueueSize.ToString();

            int keyboardQueueSize = (int)Registry.GetValue(keyboardKeyName, keyboardValueName, keyboardDefaultValue);
            keyboardDataSizeTextbox.Text = keyboardQueueSize.ToString();
        }

        public void ShowUI()
        {
            RefreshRegistryValues();
            Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Long text explaining everything here");
        }

        private void mouseDataSizeApply_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mouseDataSizeTextbox.Text, out int mouseDataSize) == false)
            {
                MessageBox.Show("Data size contains invalid text");
                return;
            }

            if (mouseDataSize < 20 || mouseDataSize > 100)
            {
                MessageBox.Show("Data size must be between safe values of 20 and 100");
                return;
            }

            try
            {
                Registry.SetValue(mouseKeyName, mouseValueName, mouseDataSize);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Please run this program as administrator");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown error: {ex.Message}");
            }
        }

        private void keyboardDataSizeApply_Click(object sender, EventArgs e)
        {
            if (int.TryParse(keyboardDataSizeTextbox.Text, out int keyboardDataSize) == false)
            {
                MessageBox.Show("Data size contains invalid text");
                return;
            }

            if (keyboardDataSize < 20 || keyboardDataSize > 100)
            {
                MessageBox.Show("Data size must be between safe values of 20 and 100");
                return;
            }

            try
            {
                Registry.SetValue(keyboardKeyName, keyboardValueName, keyboardDataSize);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Please run this program as administrator");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown error: {ex.Message}");
            }
        }
    }
}
