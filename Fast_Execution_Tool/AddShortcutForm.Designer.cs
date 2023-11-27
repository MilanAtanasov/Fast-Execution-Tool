namespace Fast_Execution_Tool
{
    partial class AddShortcutForm
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
            this.tbAddShortcutPath = new System.Windows.Forms.TextBox();
            this.labelShortcutName = new System.Windows.Forms.Label();
            this.tbAddShortcutName = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.Button();
            this.btnAddSchortcutAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAddShortcutPath
            // 
            this.tbAddShortcutPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddShortcutPath.Location = new System.Drawing.Point(12, 62);
            this.tbAddShortcutPath.Name = "tbAddShortcutPath";
            this.tbAddShortcutPath.Size = new System.Drawing.Size(377, 30);
            this.tbAddShortcutPath.TabIndex = 0;
            // 
            // labelShortcutName
            // 
            this.labelShortcutName.AutoSize = true;
            this.labelShortcutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShortcutName.Location = new System.Drawing.Point(7, 19);
            this.labelShortcutName.Name = "labelShortcutName";
            this.labelShortcutName.Size = new System.Drawing.Size(142, 25);
            this.labelShortcutName.TabIndex = 1;
            this.labelShortcutName.Text = "Shortcut Name";
            // 
            // tbAddShortcutName
            // 
            this.tbAddShortcutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddShortcutName.Location = new System.Drawing.Point(155, 14);
            this.tbAddShortcutName.Name = "tbAddShortcutName";
            this.tbAddShortcutName.Size = new System.Drawing.Size(317, 30);
            this.tbAddShortcutName.TabIndex = 2;
            // 
            // Path
            // 
            this.Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path.Location = new System.Drawing.Point(404, 50);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(68, 42);
            this.Path.TabIndex = 3;
            this.Path.Text = "Path";
            this.Path.UseVisualStyleBackColor = true;
            this.Path.Click += new System.EventHandler(this.Path_Click);
            // 
            // btnAddSchortcutAdd
            // 
            this.btnAddSchortcutAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchortcutAdd.Location = new System.Drawing.Point(12, 98);
            this.btnAddSchortcutAdd.Name = "btnAddSchortcutAdd";
            this.btnAddSchortcutAdd.Size = new System.Drawing.Size(482, 42);
            this.btnAddSchortcutAdd.TabIndex = 4;
            this.btnAddSchortcutAdd.Text = "Add";
            this.btnAddSchortcutAdd.UseVisualStyleBackColor = true;
            this.btnAddSchortcutAdd.Click += new System.EventHandler(this.btnAddSchortcutAdd_Click);
            // 
            // AddShortcutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 144);
            this.Controls.Add(this.btnAddSchortcutAdd);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.tbAddShortcutName);
            this.Controls.Add(this.labelShortcutName);
            this.Controls.Add(this.tbAddShortcutPath);
            this.Name = "AddShortcutForm";
            this.Text = "AddShortcutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddShortcutPath;
        private System.Windows.Forms.Label labelShortcutName;
        private System.Windows.Forms.TextBox tbAddShortcutName;
        private System.Windows.Forms.Button Path;
        private System.Windows.Forms.Button btnAddSchortcutAdd;
    }
}