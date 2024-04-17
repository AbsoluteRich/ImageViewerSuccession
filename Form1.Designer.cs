namespace ImageViewerSuccession
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
            menuStrip = new System.Windows.Forms.MenuStrip();
            btnFile = new System.Windows.Forms.ToolStripMenuItem();
            btnFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            btnFileClear = new System.Windows.Forms.ToolStripMenuItem();
            btnView = new System.Windows.Forms.ToolStripMenuItem();
            txtZoom = new System.Windows.Forms.ToolStripTextBox();
            btnResize = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            filePicker = new System.Windows.Forms.OpenFileDialog();
            picture = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnFile, btnView });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(430, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // btnFile
            // 
            btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnFileOpen, btnFileClear });
            btnFile.Name = "btnFile";
            btnFile.Size = new System.Drawing.Size(37, 20);
            btnFile.Text = "File";
            // 
            // btnFileOpen
            // 
            btnFileOpen.Name = "btnFileOpen";
            btnFileOpen.Size = new System.Drawing.Size(103, 22);
            btnFileOpen.Text = "Open";
            btnFileOpen.Click += openToolStripMenuItem_Click;
            // 
            // btnFileClear
            // 
            btnFileClear.Name = "btnFileClear";
            btnFileClear.Size = new System.Drawing.Size(103, 22);
            btnFileClear.Text = "Clear";
            btnFileClear.Click += clearToolStripMenuItem_Click;
            // 
            // btnView
            // 
            btnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { txtZoom, btnResize });
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(44, 20);
            btnView.Text = "View";
            // 
            // txtZoom
            // 
            txtZoom.Name = "txtZoom";
            txtZoom.Size = new System.Drawing.Size(100, 23);
            txtZoom.Text = "1";
            txtZoom.TextChanged += txtZoom_TextChanged;
            // 
            // btnResize
            // 
            btnResize.Name = "btnResize";
            btnResize.Size = new System.Drawing.Size(180, 22);
            btnResize.Text = "Resize";
            btnResize.Click += btnResize_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblFileStatus });
            statusStrip.Location = new System.Drawing.Point(0, 236);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(430, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // lblFileStatus
            // 
            lblFileStatus.Name = "lblFileStatus";
            lblFileStatus.Size = new System.Drawing.Size(415, 17);
            lblFileStatus.Spring = true;
            lblFileStatus.ToolTipText = "test";
            // 
            // picture
            // 
            picture.AllowExternalDrop = true;
            picture.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            picture.CreationProperties = null;
            picture.DefaultBackgroundColor = System.Drawing.Color.White;
            picture.Enabled = false;
            picture.Location = new System.Drawing.Point(0, 30);
            picture.Name = "picture";
            picture.Size = new System.Drawing.Size(430, 203);
            picture.TabIndex = 4;
            picture.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 258);
            Controls.Add(picture);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Image Viewer: Succession";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem btnFile;

        private System.Windows.Forms.MenuStrip menuStrip;

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblFileStatus;
        private System.Windows.Forms.OpenFileDialog filePicker;
        private System.Windows.Forms.ToolStripMenuItem btnFileOpen;
        private System.Windows.Forms.ToolStripMenuItem btnFileClear;
        private System.Windows.Forms.ToolStripMenuItem btnResize;
        private Microsoft.Web.WebView2.WinForms.WebView2 picture;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripTextBox txtZoom;
    }
}