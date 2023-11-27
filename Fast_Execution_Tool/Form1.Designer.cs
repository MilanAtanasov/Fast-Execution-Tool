namespace Fast_Execution_Tool
{
    partial class ExecutionDockForm
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
            this.lvExecutables = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvExecutables
            // 
            this.lvExecutables.HideSelection = false;
            this.lvExecutables.Location = new System.Drawing.Point(12, 12);
            this.lvExecutables.Name = "lvExecutables";
            this.lvExecutables.Size = new System.Drawing.Size(679, 469);
            this.lvExecutables.TabIndex = 0;
            this.lvExecutables.UseCompatibleStateImageBehavior = false;
            this.lvExecutables.SelectedIndexChanged += new System.EventHandler(this.lvExecutables_SelectedIndexChanged);
            // 
            // ExecutionDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 493);
            this.Controls.Add(this.lvExecutables);
            this.Name = "ExecutionDockForm";
            this.Text = "Execution Dock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExecutionDockForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvExecutables;
    }
}