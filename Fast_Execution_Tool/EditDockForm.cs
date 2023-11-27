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
            readConfig();
        }


        
        private ArrayList readConfig()
        {
            // read config file
            ArrayList config = new ArrayList();

            // check if config file exists
            if (configExists())
            {
                // read config file
                string[] lines = System.IO.File.ReadAllLines(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configExecutionTool.txt");

                // add each line to the config array
                foreach (string line in lines)
                {
                    config.Add(line);
                }
            }
            else
            {
                // create config file
                createConfig();
            }

            return config;
        }   

        private Boolean configExists()
        {
            // check if config file exists in the same directory as the executable
            if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configExecutionTool.txt"))
            {
                return true;
            }

            return false;
        }

        private void createConfig()
        {
            // create config file
            System.IO.File.Create(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configExecutionTool.txt");
        }

        private void btnEditDockFormDown_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDockFormUp_Click(object sender, EventArgs e)
        {

        }
    }
}
