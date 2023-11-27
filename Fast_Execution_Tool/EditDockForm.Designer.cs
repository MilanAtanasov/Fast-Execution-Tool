namespace Fast_Execution_Tool
{
    partial class EditDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDockForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnEditDockFormAdd = new System.Windows.Forms.Button();
            this.btnEditDockFormDelete = new System.Windows.Forms.Button();
            this.btnEditDockFormUp = new System.Windows.Forms.Button();
            this.btnEditDockFormDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 251);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnEditDockFormAdd
            // 
            this.btnEditDockFormAdd.Location = new System.Drawing.Point(12, 279);
            this.btnEditDockFormAdd.Name = "btnEditDockFormAdd";
            this.btnEditDockFormAdd.Size = new System.Drawing.Size(104, 93);
            this.btnEditDockFormAdd.TabIndex = 1;
            this.btnEditDockFormAdd.Text = "Add Shortcut";
            this.btnEditDockFormAdd.UseVisualStyleBackColor = true;
            // 
            // btnEditDockFormDelete
            // 
            this.btnEditDockFormDelete.Location = new System.Drawing.Point(122, 279);
            this.btnEditDockFormDelete.Name = "btnEditDockFormDelete";
            this.btnEditDockFormDelete.Size = new System.Drawing.Size(104, 93);
            this.btnEditDockFormDelete.TabIndex = 2;
            this.btnEditDockFormDelete.Text = "Delete Selected Shortcut";
            this.btnEditDockFormDelete.UseVisualStyleBackColor = true;
            // 
            // btnEditDockFormUp
            // 
            this.btnEditDockFormUp.Location = new System.Drawing.Point(232, 279);
            this.btnEditDockFormUp.Name = "btnEditDockFormUp";
            this.btnEditDockFormUp.Size = new System.Drawing.Size(104, 93);
            this.btnEditDockFormUp.TabIndex = 3;
            this.btnEditDockFormUp.Text = "Up";
            this.btnEditDockFormUp.UseVisualStyleBackColor = true;
            this.btnEditDockFormUp.Click += new System.EventHandler(this.btnEditDockFormUp_Click);
            // 
            // btnEditDockFormDown
            // 
            this.btnEditDockFormDown.Location = new System.Drawing.Point(342, 279);
            this.btnEditDockFormDown.Name = "btnEditDockFormDown";
            this.btnEditDockFormDown.Size = new System.Drawing.Size(104, 93);
            this.btnEditDockFormDown.TabIndex = 4;
            this.btnEditDockFormDown.Text = "Down";
            this.btnEditDockFormDown.UseVisualStyleBackColor = true;
            this.btnEditDockFormDown.Click += new System.EventHandler(this.btnEditDockFormDown_Click);
            // 
            // EditDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 384);
            this.Controls.Add(this.btnEditDockFormDown);
            this.Controls.Add(this.btnEditDockFormUp);
            this.Controls.Add(this.btnEditDockFormDelete);
            this.Controls.Add(this.btnEditDockFormAdd);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDockForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditDockForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnEditDockFormAdd;
        private System.Windows.Forms.Button btnEditDockFormDelete;
        private System.Windows.Forms.Button btnEditDockFormUp;
        private System.Windows.Forms.Button btnEditDockFormDown;
    }
}