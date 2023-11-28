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
            // add shortcut to config file as a new line with the format:
            // shortcutName;shortcutPath; (semicolon as separator) 
            // and close the form
            addShortcut();
            this.Close();
        }

        private void addShortcut()
        {
            // add shortcut to config file as a new line with the format:
            // shortcutName;shortcutPath; (semicolon as separator) 
            // and close the form
            System.IO.File.AppendAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configExecutionTool.txt", getShortcutName() + ";" + getShortcutPath() + ";"+"\n");
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

        private void Path_Click(object sender, EventArgs e)
        {
            // open file dialog to select the path of the shortcut, and pass it to the tbAddShortcutPath textbox
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
            openFileDialog.Title = "Select the path of the shortcut";
            openFileDialog.ShowDialog();
            tbAddShortcutPath.Text = openFileDialog.FileName;
        }
    }
}
