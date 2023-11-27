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
        public ExecutionDockForm()
        {
            InitializeComponent();
        }

        private void ExecutionDockForm_Load(object sender, EventArgs e)
        {

        }

        private void ExecutionDockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close this form and open the starting form
            StartingForm startingForm = new StartingForm();
            startingForm.Show();
        }
    }
}
