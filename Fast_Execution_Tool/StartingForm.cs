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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
            ConfigElements.Instance.UpdateConfig();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExecutionDock_Click(object sender, EventArgs e)
        {
            // change form to ExecutionDock
            ExecutionDockForm executionDock = new ExecutionDockForm();
            executionDock.Show();
            this.Hide();
        }

        private void btnEditDock_Click(object sender, EventArgs e)
        {
            // change form to EditDock
            EditDockForm editDock = new EditDockForm();
            editDock.Show();
            this.Hide();
        }

        private void StartingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close the application
            Application.Exit();
        }
    }
}
