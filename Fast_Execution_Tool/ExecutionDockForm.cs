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

public partial class ExecutionDockForm : Form
    {
        ListViewItem item1 = new ListViewItem("Item1", 0);

        public ExecutionDockForm()
        {
            InitializeComponent();
        }



        private void lvExecutables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExecutionDockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // change form to StartingForm, this Form is already hidden
            StartingForm startingForm = new StartingForm();
            startingForm.Show();
        }
    }
}
