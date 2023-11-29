using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            InitializeButtons();
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

        private void InitializeButtons()
        {
            string filePath = "configExecutionTool.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                int yPos = 10;
                foreach (string line in lines)
                {
                    Button button = new Button
                    {
                        Text = line,
                        Location = new System.Drawing.Point(10, yPos),
                        Size = new System.Drawing.Size(100, 30)
                    };

                    button.Click += Button_Click; // Attach event handler
                    this.Controls.Add(button);
                    yPos += 35; // Adjust position for next button
                }
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
