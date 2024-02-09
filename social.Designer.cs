namespace Winstaller
{
    partial class social
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
            this.CatergoriesLabel = new System.Windows.Forms.Label();
            this.telegram = new System.Windows.Forms.Button();
            this.discord = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CatergoriesLabel
            // 
            this.CatergoriesLabel.AutoSize = true;
            this.CatergoriesLabel.Font = new System.Drawing.Font("Cooper Lt BT", 51.75F, System.Drawing.FontStyle.Bold);
            this.CatergoriesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.CatergoriesLabel.Location = new System.Drawing.Point(299, 9);
            this.CatergoriesLabel.Name = "CatergoriesLabel";
            this.CatergoriesLabel.Size = new System.Drawing.Size(228, 84);
            this.CatergoriesLabel.TabIndex = 3;
            this.CatergoriesLabel.Text = "social";
            // 
            // telegram
            // 
            this.telegram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telegram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.telegram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.telegram.FlatAppearance.BorderSize = 0;
            this.telegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.telegram.Font = new System.Drawing.Font("Cooper Lt BT", 31.75F, System.Drawing.FontStyle.Bold);
            this.telegram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.telegram.Location = new System.Drawing.Point(304, 308);
            this.telegram.Name = "telegram";
            this.telegram.Size = new System.Drawing.Size(218, 74);
            this.telegram.TabIndex = 9;
            this.telegram.Text = "telegram";
            this.telegram.UseVisualStyleBackColor = false;
            this.telegram.Click += new System.EventHandler(this.telegram_Click);
            // 
            // discord
            // 
            this.discord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.discord.FlatAppearance.BorderSize = 0;
            this.discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discord.Font = new System.Drawing.Font("Cooper Lt BT", 31.75F, System.Drawing.FontStyle.Bold);
            this.discord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.discord.Location = new System.Drawing.Point(313, 226);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(197, 76);
            this.discord.TabIndex = 8;
            this.discord.Text = "discord";
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // backbtn
            // 
            this.backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Cooper Lt BT", 21.75F, System.Drawing.FontStyle.Bold);
            this.backbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.backbtn.Location = new System.Drawing.Point(12, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(104, 57);
            this.backbtn.TabIndex = 22;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Lt BT", 11.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(12, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "github.com/rpatty-dev/winstaller";
            // 
            // social
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(814, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.telegram);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.CatergoriesLabel);
            this.Name = "social";
            this.Text = "social";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CatergoriesLabel;
        private System.Windows.Forms.Button telegram;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
    }
}