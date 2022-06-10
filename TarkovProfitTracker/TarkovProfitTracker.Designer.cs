namespace TarkovProfitTracker
{
    partial class TarkovProfitTracker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarkovProfitTracker));
            this.DateText = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Tooltips = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.RoublesLabel = new System.Windows.Forms.Label();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.DollarsLabel = new System.Windows.Forms.Label();
            this.RoublesBox = new System.Windows.Forms.NumericUpDown();
            this.EurosBox = new System.Windows.Forms.NumericUpDown();
            this.DollarsBox = new System.Windows.Forms.NumericUpDown();
            this.UpdateStashButton = new System.Windows.Forms.Button();
            this.ShowGraphButton = new System.Windows.Forms.Button();
            this.ResetDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoublesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurosBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollarsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DateText
            // 
            this.DateText.AutoSize = true;
            this.DateText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DateText.Location = new System.Drawing.Point(39, 9);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(118, 13);
            this.DateText.TabIndex = 0;
            this.DateText.Text = "DATE PLACEHOLDER";
            this.DateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tooltips.SetToolTip(this.DateText, "Click to reset date");
            this.DateText.Click += new System.EventHandler(this.DateText_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(4, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "By Pasgotti";
            this.Tooltips.SetToolTip(this.label1, "cock and also dicke and balls");
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::TarkovProfitTracker.Properties.Resources.escape_from_tarkov;
            this.LogoBox.Location = new System.Drawing.Point(13, 9);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(343, 164);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 8;
            this.LogoBox.TabStop = false;
            this.Tooltips.SetToolTip(this.LogoBox, "Version 1.1");
            // 
            // RoublesLabel
            // 
            this.RoublesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RoublesLabel.AutoSize = true;
            this.RoublesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoublesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RoublesLabel.Location = new System.Drawing.Point(10, 204);
            this.RoublesLabel.Name = "RoublesLabel";
            this.RoublesLabel.Size = new System.Drawing.Size(72, 13);
            this.RoublesLabel.TabIndex = 5;
            this.RoublesLabel.Text = "Roubles (₽)";
            this.RoublesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EuroLabel
            // 
            this.EuroLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EuroLabel.Location = new System.Drawing.Point(24, 227);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(58, 13);
            this.EuroLabel.TabIndex = 6;
            this.EuroLabel.Text = "Euros (€)";
            this.EuroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollarsLabel
            // 
            this.DollarsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DollarsLabel.AutoSize = true;
            this.DollarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DollarsLabel.Location = new System.Drawing.Point(17, 253);
            this.DollarsLabel.Name = "DollarsLabel";
            this.DollarsLabel.Size = new System.Drawing.Size(65, 13);
            this.DollarsLabel.TabIndex = 7;
            this.DollarsLabel.Text = "Dollars ($)";
            this.DollarsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoublesBox
            // 
            this.RoublesBox.Location = new System.Drawing.Point(88, 202);
            this.RoublesBox.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.RoublesBox.Name = "RoublesBox";
            this.RoublesBox.Size = new System.Drawing.Size(134, 20);
            this.RoublesBox.TabIndex = 9;
            // 
            // EurosBox
            // 
            this.EurosBox.Location = new System.Drawing.Point(88, 225);
            this.EurosBox.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.EurosBox.Name = "EurosBox";
            this.EurosBox.Size = new System.Drawing.Size(134, 20);
            this.EurosBox.TabIndex = 10;
            // 
            // DollarsBox
            // 
            this.DollarsBox.Location = new System.Drawing.Point(88, 251);
            this.DollarsBox.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.DollarsBox.Name = "DollarsBox";
            this.DollarsBox.Size = new System.Drawing.Size(134, 20);
            this.DollarsBox.TabIndex = 11;
            // 
            // UpdateStashButton
            // 
            this.UpdateStashButton.Location = new System.Drawing.Point(249, 196);
            this.UpdateStashButton.Name = "UpdateStashButton";
            this.UpdateStashButton.Size = new System.Drawing.Size(127, 36);
            this.UpdateStashButton.TabIndex = 12;
            this.UpdateStashButton.Text = "Update Stash Tracker";
            this.UpdateStashButton.UseVisualStyleBackColor = true;
            this.UpdateStashButton.Click += new System.EventHandler(this.UpdateStashButton_Click);
            // 
            // ShowGraphButton
            // 
            this.ShowGraphButton.Location = new System.Drawing.Point(249, 233);
            this.ShowGraphButton.Name = "ShowGraphButton";
            this.ShowGraphButton.Size = new System.Drawing.Size(127, 36);
            this.ShowGraphButton.TabIndex = 13;
            this.ShowGraphButton.Text = "Show Graph";
            this.ShowGraphButton.UseVisualStyleBackColor = true;
            this.ShowGraphButton.Click += new System.EventHandler(this.ShowGraphButton_Click);
            // 
            // ResetDataButton
            // 
            this.ResetDataButton.Location = new System.Drawing.Point(263, 270);
            this.ResetDataButton.Name = "ResetDataButton";
            this.ResetDataButton.Size = new System.Drawing.Size(99, 27);
            this.ResetDataButton.TabIndex = 14;
            this.ResetDataButton.Text = "Reset All Data";
            this.ResetDataButton.UseVisualStyleBackColor = true;
            this.ResetDataButton.Click += new System.EventHandler(this.ResetDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Stash Values Here (Update at the end of each day you play)";
            // 
            // VersionLabel
            // 
            this.VersionLabel.Location = new System.Drawing.Point(274, 152);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VersionLabel.Size = new System.Drawing.Size(82, 13);
            this.VersionLabel.TabIndex = 17;
            this.VersionLabel.Text = "Version Number";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TarkovProfitTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 304);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetDataButton);
            this.Controls.Add(this.ShowGraphButton);
            this.Controls.Add(this.UpdateStashButton);
            this.Controls.Add(this.DollarsBox);
            this.Controls.Add(this.EurosBox);
            this.Controls.Add(this.RoublesBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.DollarsLabel);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.RoublesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TarkovProfitTracker";
            this.Text = "TarkovProfitTracker";
            this.Load += new System.EventHandler(this.TarkovProfitTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoublesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurosBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollarsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ToolTip Tooltips;
        private System.Windows.Forms.Label RoublesLabel;
        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.Label DollarsLabel;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.NumericUpDown RoublesBox;
        private System.Windows.Forms.NumericUpDown EurosBox;
        private System.Windows.Forms.NumericUpDown DollarsBox;
        private System.Windows.Forms.Button UpdateStashButton;
        private System.Windows.Forms.Button ShowGraphButton;
        private System.Windows.Forms.Button ResetDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VersionLabel;
    }
}

