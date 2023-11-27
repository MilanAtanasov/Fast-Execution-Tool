namespace Fast_Execution_Tool
{
    partial class StartingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
            this.btnExecutionDock = new System.Windows.Forms.Button();
            this.btnEditDock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecutionDock
            // 
            this.btnExecutionDock.Location = new System.Drawing.Point(12, 12);
            this.btnExecutionDock.Name = "btnExecutionDock";
            this.btnExecutionDock.Size = new System.Drawing.Size(403, 97);
            this.btnExecutionDock.TabIndex = 0;
            this.btnExecutionDock.Text = "Execution Dock";
            this.btnExecutionDock.UseVisualStyleBackColor = true;
            this.btnExecutionDock.Click += new System.EventHandler(this.btnExecutionDock_Click);
            // 
            // btnEditDock
            // 
            this.btnEditDock.Location = new System.Drawing.Point(12, 115);
            this.btnEditDock.Name = "btnEditDock";
            this.btnEditDock.Size = new System.Drawing.Size(403, 97);
            this.btnEditDock.TabIndex = 1;
            this.btnEditDock.Text = "Edit Dock";
            this.btnEditDock.UseVisualStyleBackColor = true;
            this.btnEditDock.Click += new System.EventHandler(this.btnEditDock_Click);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 226);
            this.Controls.Add(this.btnEditDock);
            this.Controls.Add(this.btnExecutionDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(443, 265);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(443, 265);
            this.Name = "StartingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starter Execution Dock Toolbox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartingForm_FormClosed);
            this.Load += new System.EventHandler(this.StartingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutionDock;
        private System.Windows.Forms.Button btnEditDock;
    }
}

