namespace localScanner
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startScan = new System.Windows.Forms.Button();
            this.startHostBox = new System.Windows.Forms.TextBox();
            this.endHostBox = new System.Windows.Forms.TextBox();
            this.hostListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 303);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(401, 23);
            this.progressBar.TabIndex = 0;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // startScan
            // 
            this.startScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startScan.Location = new System.Drawing.Point(338, 10);
            this.startScan.Name = "startScan";
            this.startScan.Size = new System.Drawing.Size(75, 23);
            this.startScan.TabIndex = 1;
            this.startScan.Text = "Start Scan";
            this.startScan.UseVisualStyleBackColor = true;
            this.startScan.Click += new System.EventHandler(this.startScan_Click);
            // 
            // startHostBox
            // 
            this.startHostBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startHostBox.Location = new System.Drawing.Point(12, 12);
            this.startHostBox.Name = "startHostBox";
            this.startHostBox.Size = new System.Drawing.Size(151, 20);
            this.startHostBox.TabIndex = 2;
            this.startHostBox.TextChanged += new System.EventHandler(this.startHostBox_TextChanged);
            // 
            // endHostBox
            // 
            this.endHostBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endHostBox.Location = new System.Drawing.Point(169, 12);
            this.endHostBox.Name = "endHostBox";
            this.endHostBox.Size = new System.Drawing.Size(151, 20);
            this.endHostBox.TabIndex = 3;
            this.endHostBox.TextChanged += new System.EventHandler(this.endHostBox_TextChanged);
            // 
            // hostListView
            // 
            this.hostListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostListView.HideSelection = false;
            this.hostListView.Location = new System.Drawing.Point(12, 39);
            this.hostListView.Name = "hostListView";
            this.hostListView.Size = new System.Drawing.Size(401, 258);
            this.hostListView.TabIndex = 4;
            this.hostListView.UseCompatibleStateImageBehavior = false;
            this.hostListView.SelectedIndexChanged += new System.EventHandler(this.hostListView_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 338);
            this.Controls.Add(this.hostListView);
            this.Controls.Add(this.endHostBox);
            this.Controls.Add(this.startHostBox);
            this.Controls.Add(this.startScan);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button startScan;
        private System.Windows.Forms.TextBox startHostBox;
        private System.Windows.Forms.TextBox endHostBox;
        private System.Windows.Forms.ListView hostListView;
    }
}

