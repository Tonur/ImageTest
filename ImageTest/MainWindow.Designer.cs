namespace ImageTest
{
    partial class MainWindow
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.rtbFileName = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.ShowPictureButton = new System.Windows.Forms.Button();
            this.GetIDRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CaseIDRtb = new System.Windows.Forms.RichTextBox();
            this.ExtentionRtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(362, 52);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // rtbFileName
            // 
            this.rtbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileName.Location = new System.Drawing.Point(12, 52);
            this.rtbFileName.Name = "rtbFileName";
            this.rtbFileName.Size = new System.Drawing.Size(344, 23);
            this.rtbFileName.TabIndex = 1;
            this.rtbFileName.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(362, 81);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(443, 36);
            this.TopBarPanel.TabIndex = 4;
            // 
            // ShowPictureButton
            // 
            this.ShowPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPictureButton.Location = new System.Drawing.Point(362, 139);
            this.ShowPictureButton.Name = "ShowPictureButton";
            this.ShowPictureButton.Size = new System.Drawing.Size(75, 23);
            this.ShowPictureButton.TabIndex = 5;
            this.ShowPictureButton.Text = "Show Pic";
            this.ShowPictureButton.UseVisualStyleBackColor = true;
            this.ShowPictureButton.Click += new System.EventHandler(this.ShowPictureButton_Click);
            // 
            // GetIDRichTextBox
            // 
            this.GetIDRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetIDRichTextBox.Location = new System.Drawing.Point(362, 110);
            this.GetIDRichTextBox.Name = "GetIDRichTextBox";
            this.GetIDRichTextBox.Size = new System.Drawing.Size(75, 23);
            this.GetIDRichTextBox.TabIndex = 6;
            this.GetIDRichTextBox.Text = "";
            // 
            // CaseIDRtb
            // 
            this.CaseIDRtb.Location = new System.Drawing.Point(63, 81);
            this.CaseIDRtb.Name = "CaseIDRtb";
            this.CaseIDRtb.Size = new System.Drawing.Size(55, 23);
            this.CaseIDRtb.TabIndex = 7;
            this.CaseIDRtb.Text = "";
            // 
            // ExtentionRtb
            // 
            this.ExtentionRtb.Location = new System.Drawing.Point(184, 81);
            this.ExtentionRtb.Name = "ExtentionRtb";
            this.ExtentionRtb.Size = new System.Drawing.Size(55, 23);
            this.ExtentionRtb.TabIndex = 8;
            this.ExtentionRtb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CaseID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Extention:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtentionRtb);
            this.Controls.Add(this.CaseIDRtb);
            this.Controls.Add(this.GetIDRichTextBox);
            this.Controls.Add(this.ShowPictureButton);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.rtbFileName);
            this.Controls.Add(this.btnSelect);
            this.Name = "MainWindow";
            this.Text = "Picture Test";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RichTextBox rtbFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button ShowPictureButton;
        private System.Windows.Forms.RichTextBox GetIDRichTextBox;
        private System.Windows.Forms.RichTextBox CaseIDRtb;
        private System.Windows.Forms.RichTextBox ExtentionRtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

