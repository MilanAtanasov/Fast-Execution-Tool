using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Execution_Tool
{
    public partial class AddShortcutForm : Form
    {
        public AddShortcutForm()
        {
            InitializeComponent();
        }

        private void btnAddSchortcutAdd_Click(object sender, EventArgs e)
        {
            
            // get the shortcut name and path
            String shortcutName = getShortcutName();
            String shortcutPath = getShortcutPath();
            String profile = getComboBoxProfile();
            // update the config file

            
            //dataXML.GetInstance().addShortcut(shortcutName, shortcutPath, profile);

            // close the form            
            this.Close();
        }

        

        private String getShortcutName()
        {
            // get the shortcut name from the tbAddShortcutName textbox
            return tbAddShortcutName.Text;
        }

        private String getShortcutPath()
        {
            // get the shortcut path from the tbAddShortcutPath textbox
            return tbAddShortcutPath.Text;
        }

        private String getComboBoxProfile()
        {
            // get the profile from the comboBoxProfiles
            return comboBoxProfiles.Text;
        }

        private void Path_Click(object sender, EventArgs e)
        {
            // open file dialog to select the path of the shortcut, and pass it to the tbAddShortcutPath textbox
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
            openFileDialog.Title = "Select the path of the shortcut";
            openFileDialog.ShowDialog();
            tbAddShortcutPath.Text = openFileDialog.FileName;
        }

        private void tableLayoutPanelAddShortcutForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
