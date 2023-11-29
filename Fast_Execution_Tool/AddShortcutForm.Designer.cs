using System;
using System.Collections.Generic;

namespace Fast_Execution_Tool
{
    partial class AddShortcutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbAddShortcutPath = new System.Windows.Forms.TextBox();
            this.tbAddShortcutName = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.flowLayoutPanelAddShortcutForm = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelAddShortcutForm = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSchortcutAdd = new System.Windows.Forms.Button();
            this.labelShortcutName = new System.Windows.Forms.Label();
            this.labelShortcutPath = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.comboBoxProfiles = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelAddShortcutForm.SuspendLayout();
            this.tableLayoutPanelAddShortcutForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAddShortcutPath
            // 
            this.tbAddShortcutPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddShortcutPath.Location = new System.Drawing.Point(95, 63);
            this.tbAddShortcutPath.Name = "tbAddShortcutPath";
            this.tbAddShortcutPath.Size = new System.Drawing.Size(307, 30);
            this.tbAddShortcutPath.TabIndex = 2;
            this.tbAddShortcutPath.Click += new System.EventHandler(this.Path_Click);
            // 
            // tbAddShortcutName
            // 
            this.tbAddShortcutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddShortcutName.Location = new System.Drawing.Point(95, 3);
            this.tbAddShortcutName.Name = "tbAddShortcutName";
            this.tbAddShortcutName.Size = new System.Drawing.Size(307, 30);
            this.tbAddShortcutName.TabIndex = 1;
            // 
            // flowLayoutPanelAddShortcutForm
            // 
            this.flowLayoutPanelAddShortcutForm.Controls.Add(this.tableLayoutPanelAddShortcutForm);
            this.flowLayoutPanelAddShortcutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAddShortcutForm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAddShortcutForm.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAddShortcutForm.Name = "flowLayoutPanelAddShortcutForm";
            this.flowLayoutPanelAddShortcutForm.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanelAddShortcutForm.Size = new System.Drawing.Size(459, 272);
            this.flowLayoutPanelAddShortcutForm.TabIndex = 0;
            this.flowLayoutPanelAddShortcutForm.WrapContents = false;
            // 
            // tableLayoutPanelAddShortcutForm
            // 
            this.tableLayoutPanelAddShortcutForm.ColumnCount = 2;
            this.tableLayoutPanelAddShortcutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12881F));
            this.tableLayoutPanelAddShortcutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAddShortcutForm.Controls.Add(this.labelProfile, 0, 2);
            this.tableLayoutPanelAddShortcutForm.Controls.Add(this.labelShortcutName, 0, 0);
            this.tableLayoutPanelAddShortcutForm.Controls.Add(this.tbAddShortcutPath, 1, 1);
            this.tableLayoutPanelAddShortcutForm.Controls.Add(this.tbAddShortcutName, 1, 0);
            this.tableLayoutPanelAddShortcutForm.Controls.Add(this.labelShortcutPath, 0, 1);
            this.tableLayoutPanelAddShortcutForm.Controls.Add(this.btnAddSchortcutAdd, 1, 3);
            this.tableLayoutPanelAddShortcutForm.Controls.Add(this.comboBoxProfiles, 1, 2);
            this.tableLayoutPanelAddShortcutForm.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanelAddShortcutForm.Name = "tableLayoutPanelAddShortcutForm";
            this.tableLayoutPanelAddShortcutForm.RowCount = 4;
            this.tableLayoutPanelAddShortcutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddShortcutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddShortcutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelAddShortcutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelAddShortcutForm.Size = new System.Drawing.Size(405, 230);
            this.tableLayoutPanelAddShortcutForm.TabIndex = 5;
            this.tableLayoutPanelAddShortcutForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelAddShortcutForm_Paint);
            // 
            // btnAddSchortcutAdd
            // 
            this.btnAddSchortcutAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchortcutAdd.Location = new System.Drawing.Point(95, 178);
            this.btnAddSchortcutAdd.Name = "btnAddSchortcutAdd";
            this.btnAddSchortcutAdd.Size = new System.Drawing.Size(163, 42);
            this.btnAddSchortcutAdd.TabIndex = 4;
            this.btnAddSchortcutAdd.Text = "Add";
            this.btnAddSchortcutAdd.UseVisualStyleBackColor = true;
            this.btnAddSchortcutAdd.Click += new System.EventHandler(this.btnAddSchortcutAdd_Click);
            // 
            // labelShortcutName
            // 
            this.labelShortcutName.AutoSize = true;
            this.labelShortcutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShortcutName.Location = new System.Drawing.Point(3, 0);
            this.labelShortcutName.Name = "labelShortcutName";
            this.labelShortcutName.Size = new System.Drawing.Size(85, 50);
            this.labelShortcutName.TabIndex = 0;
            this.labelShortcutName.Text = "Shortcut Name";
            // 
            // labelShortcutPath
            // 
            this.labelShortcutPath.AutoSize = true;
            this.labelShortcutPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShortcutPath.Location = new System.Drawing.Point(3, 60);
            this.labelShortcutPath.Name = "labelShortcutPath";
            this.labelShortcutPath.Size = new System.Drawing.Size(52, 25);
            this.labelShortcutPath.TabIndex = 5;
            this.labelShortcutPath.Text = "Path";
            this.labelShortcutPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.Location = new System.Drawing.Point(3, 120);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(66, 25);
            this.labelProfile.TabIndex = 6;
            this.labelProfile.Text = "Profile";
            // 
            // comboBoxProfiles
            // 
            this.comboBoxProfiles.FormattingEnabled = true;
            this.comboBoxProfiles.Location = new System.Drawing.Point(95, 123);
            this.comboBoxProfiles.Name = "comboBoxProfiles";
            this.comboBoxProfiles.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProfiles.TabIndex = 7;
            // add the profile from the config file to the combobox as options
            viewElementsMethods.PopulateComboBoxProfiles(comboBoxProfiles);


            // 
            // AddShortcutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 272);
            this.Controls.Add(this.flowLayoutPanelAddShortcutForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddShortcutForm";
            this.Text = "AddShortcutForm";
            this.flowLayoutPanelAddShortcutForm.ResumeLayout(false);
            this.tableLayoutPanelAddShortcutForm.ResumeLayout(false);
            this.tableLayoutPanelAddShortcutForm.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox tbAddShortcutPath;
        private System.Windows.Forms.TextBox tbAddShortcutName;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddShortcutForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddShortcutForm;
        private System.Windows.Forms.Label labelShortcutName;
        private System.Windows.Forms.Button btnAddSchortcutAdd;
        private System.Windows.Forms.Label labelShortcutPath;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.ComboBox comboBoxProfiles;
    }
}
