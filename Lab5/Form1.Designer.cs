namespace Lab5
{
    partial class Form1
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonSaveFiles = new System.Windows.Forms.Button();
            this.listBoxDownloadedURL = new System.Windows.Forms.ListBox();
            this.labelImgCounter = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxURL.Location = new System.Drawing.Point(83, 8);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(624, 22);
            this.textBoxURL.TabIndex = 0;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExtract.Location = new System.Drawing.Point(713, 7);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(75, 23);
            this.buttonExtract.TabIndex = 3;
            this.buttonExtract.Text = "&Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // buttonSaveFiles
            // 
            this.buttonSaveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFiles.Enabled = false;
            this.buttonSaveFiles.Location = new System.Drawing.Point(695, 419);
            this.buttonSaveFiles.Name = "buttonSaveFiles";
            this.buttonSaveFiles.Size = new System.Drawing.Size(93, 23);
            this.buttonSaveFiles.TabIndex = 4;
            this.buttonSaveFiles.Text = "&Save files";
            this.buttonSaveFiles.UseVisualStyleBackColor = true;
            this.buttonSaveFiles.Click += new System.EventHandler(this.buttonSaveFiles_Click);
            // 
            // listBoxDownloadedURL
            // 
            this.listBoxDownloadedURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDownloadedURL.FormattingEnabled = true;
            this.listBoxDownloadedURL.ItemHeight = 16;
            this.listBoxDownloadedURL.Location = new System.Drawing.Point(12, 41);
            this.listBoxDownloadedURL.Name = "listBoxDownloadedURL";
            this.listBoxDownloadedURL.Size = new System.Drawing.Size(776, 372);
            this.listBoxDownloadedURL.TabIndex = 5;
            // 
            // labelImgCounter
            // 
            this.labelImgCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelImgCounter.AutoSize = true;
            this.labelImgCounter.Location = new System.Drawing.Point(12, 422);
            this.labelImgCounter.Name = "labelImgCounter";
            this.labelImgCounter.Size = new System.Drawing.Size(127, 17);
            this.labelImgCounter.TabIndex = 6;
            this.labelImgCounter.Text = "Number of images:";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarDownload.Location = new System.Drawing.Point(175, 419);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(514, 23);
            this.progressBarDownload.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.MinimumSize = new System.Drawing.Size(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "http:\\\\";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonExtract;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.labelImgCounter);
            this.Controls.Add(this.listBoxDownloadedURL);
            this.Controls.Add(this.buttonSaveFiles);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.textBoxURL);
            this.MinimumSize = new System.Drawing.Size(818, 501);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Button buttonSaveFiles;
        private System.Windows.Forms.ListBox listBoxDownloadedURL;
        private System.Windows.Forms.Label labelImgCounter;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Label label1;
    }
}

