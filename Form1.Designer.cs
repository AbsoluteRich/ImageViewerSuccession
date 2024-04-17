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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            menuStrip = new System.Windows.Forms.MenuStrip();
            btnFile = new System.Windows.Forms.ToolStripMenuItem();
            btnFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            btnFileClear = new System.Windows.Forms.ToolStripMenuItem();
            txtZoom = new System.Windows.Forms.ToolStripTextBox();
            btnResize = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            filePicker = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.Location = new System.Drawing.Point(0, 31);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(430, 224);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnFile, txtZoom, btnResize });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(430, 27);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // btnFile
            // 
            btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnFileOpen, btnFileClear });
            btnFile.Name = "btnFile";
            btnFile.Size = new System.Drawing.Size(37, 23);
            btnFile.Text = "File";
            // 
            // btnFileOpen
            // 
            btnFileOpen.Name = "btnFileOpen";
            btnFileOpen.Size = new System.Drawing.Size(180, 22);
            btnFileOpen.Text = "Open";
            btnFileOpen.Click += openToolStripMenuItem_Click;
            // 
            // btnFileClear
            // 
            btnFileClear.Name = "btnFileClear";
            btnFileClear.Size = new System.Drawing.Size(180, 22);
            btnFileClear.Text = "Clear";
            btnFileClear.Click += clearToolStripMenuItem_Click;
            // 
            // txtZoom
            // 
            txtZoom.Name = "txtZoom";
            txtZoom.Size = new System.Drawing.Size(100, 23);
            // 
            // btnResize
            // 
            btnResize.Name = "btnResize";
            btnResize.Size = new System.Drawing.Size(51, 23);
            btnResize.Text = "Resize";
            btnResize.Click += toolStripMenuItem1_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 258);
            Controls.Add(statusStrip);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Image Viewer: Succession";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem btnFile;

        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblFileStatus;
        private System.Windows.Forms.OpenFileDialog filePicker;
        private System.Windows.Forms.ToolStripMenuItem btnFileOpen;
        private System.Windows.Forms.ToolStripMenuItem btnFileClear;
        private System.Windows.Forms.ToolStripTextBox txtZoom;
        private System.Windows.Forms.ToolStripMenuItem btnResize;
    }
}