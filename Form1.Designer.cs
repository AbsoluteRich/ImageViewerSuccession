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
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            filePicker = new System.Windows.Forms.OpenFileDialog();
            picture = new Microsoft.Web.WebView2.WinForms.WebView2();
            numZoom = new System.Windows.Forms.NumericUpDown();
            btnOpen = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZoom).BeginInit();
            SuspendLayout();
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
            picture.Location = new System.Drawing.Point(0, 35);
            picture.Name = "picture";
            picture.Size = new System.Drawing.Size(430, 198);
            picture.TabIndex = 4;
            picture.ZoomFactor = 1D;
            // 
            // numZoom
            // 
            numZoom.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numZoom.Location = new System.Drawing.Point(374, 6);
            numZoom.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numZoom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numZoom.Name = "numZoom";
            numZoom.Size = new System.Drawing.Size(44, 23);
            numZoom.TabIndex = 5;
            numZoom.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numZoom.ValueChanged += numZoom_ValueChanged;
            // 
            // btnOpen
            // 
            btnOpen.Location = new System.Drawing.Point(12, 6);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(75, 23);
            btnOpen.TabIndex = 6;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(93, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear File";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(292, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "Zoom factor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 258);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnOpen);
            Controls.Add(numZoom);
            Controls.Add(picture);
            Controls.Add(statusStrip);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Image Viewer Succession";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblFileStatus;
        private System.Windows.Forms.OpenFileDialog filePicker;
        private Microsoft.Web.WebView2.WinForms.WebView2 picture;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}