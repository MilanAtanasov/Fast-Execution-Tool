using System;
using System.Collections;
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
    public partial class EditDockForm : Form
    {
        public EditDockForm()
        {
            InitializeComponent();
        }

        private void EditDockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // change form to StartingForm
            StartingForm startingForm = new StartingForm();
            startingForm.Show();
            ConfigElements.Instance.UpdateConfig();
        }

        private void btnEditDockFormDown_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDockFormUp_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDockFormAdd_Click(object sender, EventArgs e)
        {
            // open AddShortcutForm
            AddShortcutForm addShortcutForm = new AddShortcutForm();
            addShortcutForm.Show();
        }
    }
}
