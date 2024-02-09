namespace Winstaller
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.WinstallerLabel = new System.Windows.Forms.Label();
            this.enterbtn = new System.Windows.Forms.Button();
            this.installchoco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WinstallerLabel
            // 
            this.WinstallerLabel.AutoSize = true;
            this.WinstallerLabel.Font = new System.Drawing.Font("Cooper Lt BT", 51.75F, System.Drawing.FontStyle.Bold);
            this.WinstallerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.WinstallerLabel.Location = new System.Drawing.Point(204, 18);
            this.WinstallerLabel.Name = "WinstallerLabel";
            this.WinstallerLabel.Size = new System.Drawing.Size(413, 84);
            this.WinstallerLabel.TabIndex = 0;
            this.WinstallerLabel.Text = "Winstaller.";
            // 
            // enterbtn
            // 
            this.enterbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.enterbtn.FlatAppearance.BorderSize = 0;
            this.enterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterbtn.Font = new System.Drawing.Font("Cooper Lt BT", 31.75F, System.Drawing.FontStyle.Bold);
            this.enterbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.enterbtn.Location = new System.Drawing.Point(293, 346);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(249, 122);
            this.enterbtn.TabIndex = 1;
            this.enterbtn.Text = "2. enter";
            this.enterbtn.UseVisualStyleBackColor = false;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // installchoco
            // 
            this.installchoco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.installchoco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.installchoco.FlatAppearance.BorderSize = 0;
            this.installchoco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installchoco.Font = new System.Drawing.Font("Cooper Lt BT", 31.75F, System.Drawing.FontStyle.Bold);
            this.installchoco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.installchoco.Location = new System.Drawing.Point(293, 185);
            this.installchoco.Name = "installchoco";
            this.installchoco.Size = new System.Drawing.Size(249, 122);
            this.installchoco.TabIndex = 2;
            this.installchoco.Text = "1. install";
            this.installchoco.UseVisualStyleBackColor = false;
            this.installchoco.Click += new System.EventHandler(this.installchoco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Lt BT", 11.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(12, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "github.com/rpatty-dev/winstaller";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(810, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.installchoco);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.WinstallerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WinstallerLabel;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.Button installchoco;
        private System.Windows.Forms.Label label1;
    }
}