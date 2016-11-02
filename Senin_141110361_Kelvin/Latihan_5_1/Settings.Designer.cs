namespace Latihan_5_1
{
    partial class Settings
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Background Color");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.panelBgColor = new System.Windows.Forms.Panel();
            this.SettingColorComboBox = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.sApply = new System.Windows.Forms.Button();
            this.sOK = new System.Windows.Forms.Button();
            this.sCancel = new System.Windows.Forms.Button();
            this.BgText = new System.Windows.Forms.Label();
            this.panelBgColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBgColor
            // 
            this.panelBgColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBgColor.Controls.Add(this.BgText);
            this.panelBgColor.Controls.Add(this.sCancel);
            this.panelBgColor.Controls.Add(this.sOK);
            this.panelBgColor.Controls.Add(this.sApply);
            this.panelBgColor.Controls.Add(this.SettingColorComboBox);
            this.panelBgColor.Location = new System.Drawing.Point(166, 12);
            this.panelBgColor.Name = "panelBgColor";
            this.panelBgColor.Size = new System.Drawing.Size(206, 238);
            this.panelBgColor.TabIndex = 1;
            this.panelBgColor.Visible = false;
            // 
            // SettingColorComboBox
            // 
            this.SettingColorComboBox.DropDownWidth = 160;
            this.SettingColorComboBox.FormattingEnabled = true;
            this.SettingColorComboBox.Location = new System.Drawing.Point(24, 48);
            this.SettingColorComboBox.Name = "SettingColorComboBox";
            this.SettingColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.SettingColorComboBox.TabIndex = 0;
            this.SettingColorComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingColorComboBox_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode17.Name = "BgColor";
            treeNode17.Text = "Background Color";
            treeNode18.Name = "Theme";
            treeNode18.Text = "Theme";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(148, 238);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // sApply
            // 
            this.sApply.Location = new System.Drawing.Point(147, 212);
            this.sApply.Name = "sApply";
            this.sApply.Size = new System.Drawing.Size(56, 23);
            this.sApply.TabIndex = 1;
            this.sApply.Text = "Apply";
            this.sApply.UseVisualStyleBackColor = true;
            this.sApply.Click += new System.EventHandler(this.sApply_Click);
            // 
            // sOK
            // 
            this.sOK.Location = new System.Drawing.Point(3, 212);
            this.sOK.Name = "sOK";
            this.sOK.Size = new System.Drawing.Size(56, 23);
            this.sOK.TabIndex = 1;
            this.sOK.Text = "OK";
            this.sOK.UseVisualStyleBackColor = true;
            this.sOK.Click += new System.EventHandler(this.sOK_Click);
            // 
            // sCancel
            // 
            this.sCancel.Location = new System.Drawing.Point(76, 212);
            this.sCancel.Name = "sCancel";
            this.sCancel.Size = new System.Drawing.Size(56, 23);
            this.sCancel.TabIndex = 1;
            this.sCancel.Text = "Cancel";
            this.sCancel.UseVisualStyleBackColor = true;
            this.sCancel.Click += new System.EventHandler(this.sCancel_Click);
            // 
            // BgText
            // 
            this.BgText.AutoSize = true;
            this.BgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BgText.Location = new System.Drawing.Point(64, 22);
            this.BgText.Name = "BgText";
            this.BgText.Size = new System.Drawing.Size(137, 17);
            this.BgText.TabIndex = 2;
            this.BgText.Text = "Background Color";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panelBgColor);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panelBgColor.ResumeLayout(false);
            this.panelBgColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBgColor;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox SettingColorComboBox;
        private System.Windows.Forms.Button sCancel;
        private System.Windows.Forms.Button sOK;
        private System.Windows.Forms.Button sApply;
        private System.Windows.Forms.Label BgText;
    }
}