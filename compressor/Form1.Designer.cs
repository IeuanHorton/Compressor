namespace compressor
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
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtBrowseFile = new System.Windows.Forms.TextBox();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDestinationFolder = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnDeCompress = new System.Windows.Forms.Button();
            this.tbLevel = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(12, 29);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 0;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(13, 13);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(26, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "File:";
            // 
            // txtBrowseFile
            // 
            this.txtBrowseFile.Location = new System.Drawing.Point(93, 31);
            this.txtBrowseFile.Name = "txtBrowseFile";
            this.txtBrowseFile.Size = new System.Drawing.Size(174, 20);
            this.txtBrowseFile.TabIndex = 2;
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(93, 78);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(174, 20);
            this.txtDestinationFolder.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destination:";
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Location = new System.Drawing.Point(12, 76);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(75, 23);
            this.btnDestinationFolder.TabIndex = 3;
            this.btnDestinationFolder.Text = "Browse";
            this.btnDestinationFolder.UseVisualStyleBackColor = true;
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(12, 174);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(88, 40);
            this.btnCompress.TabIndex = 6;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnDeCompress
            // 
            this.btnDeCompress.Location = new System.Drawing.Point(179, 174);
            this.btnDeCompress.Name = "btnDeCompress";
            this.btnDeCompress.Size = new System.Drawing.Size(88, 40);
            this.btnDeCompress.TabIndex = 7;
            this.btnDeCompress.Text = "DeCompress";
            this.btnDeCompress.UseVisualStyleBackColor = true;
            this.btnDeCompress.Click += new System.EventHandler(this.btnDeCompress_Click);
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(12, 130);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(104, 45);
            this.tbLevel.TabIndex = 8;
            this.tbLevel.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Level of compression";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(126, 111);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 226);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.btnDeCompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDestinationFolder);
            this.Controls.Add(this.txtBrowseFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnBrowseFile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtBrowseFile;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDestinationFolder;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnDeCompress;
        private System.Windows.Forms.TrackBar tbLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLevel;
    }
}

