namespace ImageDateNamer
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbxFolder = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImagesCnt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImageTotalCnt = new System.Windows.Forms.Label();
            this.lblImagesNoDateCnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblImageNoDateTotalCnt = new System.Windows.Forms.Label();
            this.tbxDestFolder = new System.Windows.Forms.TextBox();
            this.btnDestBrowse = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLoadsCnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(260, 29);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbxFolder
            // 
            this.tbxFolder.Location = new System.Drawing.Point(27, 29);
            this.tbxFolder.Name = "tbxFolder";
            this.tbxFolder.Size = new System.Drawing.Size(213, 20);
            this.tbxFolder.TabIndex = 1;
            this.tbxFolder.Text = "D:\\lk\\Pictures";
            // 
            // btnRename
            // 
            this.btnRename.Enabled = false;
            this.btnRename.Location = new System.Drawing.Point(261, 185);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Go";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Images:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ImagesNoDate:";
            // 
            // lblImagesCnt
            // 
            this.lblImagesCnt.AutoSize = true;
            this.lblImagesCnt.Location = new System.Drawing.Point(140, 155);
            this.lblImagesCnt.Name = "lblImagesCnt";
            this.lblImagesCnt.Size = new System.Drawing.Size(13, 13);
            this.lblImagesCnt.TabIndex = 5;
            this.lblImagesCnt.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "/";
            // 
            // lblImageTotalCnt
            // 
            this.lblImageTotalCnt.AutoSize = true;
            this.lblImageTotalCnt.Location = new System.Drawing.Point(217, 155);
            this.lblImageTotalCnt.Name = "lblImageTotalCnt";
            this.lblImageTotalCnt.Size = new System.Drawing.Size(13, 13);
            this.lblImageTotalCnt.TabIndex = 7;
            this.lblImageTotalCnt.Text = "0";
            // 
            // lblImagesNoDateCnt
            // 
            this.lblImagesNoDateCnt.AutoSize = true;
            this.lblImagesNoDateCnt.Location = new System.Drawing.Point(140, 190);
            this.lblImagesNoDateCnt.Name = "lblImagesNoDateCnt";
            this.lblImagesNoDateCnt.Size = new System.Drawing.Size(13, 13);
            this.lblImagesNoDateCnt.TabIndex = 8;
            this.lblImagesNoDateCnt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "/";
            // 
            // lblImageNoDateTotalCnt
            // 
            this.lblImageNoDateTotalCnt.AutoSize = true;
            this.lblImageNoDateTotalCnt.Location = new System.Drawing.Point(217, 190);
            this.lblImageNoDateTotalCnt.Name = "lblImageNoDateTotalCnt";
            this.lblImageNoDateTotalCnt.Size = new System.Drawing.Size(13, 13);
            this.lblImageNoDateTotalCnt.TabIndex = 10;
            this.lblImageNoDateTotalCnt.Text = "0";
            // 
            // tbxDestFolder
            // 
            this.tbxDestFolder.Location = new System.Drawing.Point(27, 76);
            this.tbxDestFolder.Name = "tbxDestFolder";
            this.tbxDestFolder.Size = new System.Drawing.Size(213, 20);
            this.tbxDestFolder.TabIndex = 11;
            this.tbxDestFolder.Text = "D:\\lk\\MyPictures";
            // 
            // btnDestBrowse
            // 
            this.btnDestBrowse.Location = new System.Drawing.Point(261, 74);
            this.btnDestBrowse.Name = "btnDestBrowse";
            this.btnDestBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDestBrowse.TabIndex = 12;
            this.btnDestBrowse.Text = "Browse";
            this.btnDestBrowse.UseVisualStyleBackColor = true;
            this.btnDestBrowse.Click += new System.EventHandler(this.btnDestBrowse_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(260, 115);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Loaded";
            // 
            // lblLoadsCnt
            // 
            this.lblLoadsCnt.AutoSize = true;
            this.lblLoadsCnt.Location = new System.Drawing.Point(140, 120);
            this.lblLoadsCnt.Name = "lblLoadsCnt";
            this.lblLoadsCnt.Size = new System.Drawing.Size(13, 13);
            this.lblLoadsCnt.TabIndex = 15;
            this.lblLoadsCnt.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 220);
            this.Controls.Add(this.lblLoadsCnt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDestBrowse);
            this.Controls.Add(this.tbxDestFolder);
            this.Controls.Add(this.lblImageNoDateTotalCnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblImagesNoDateCnt);
            this.Controls.Add(this.lblImageTotalCnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblImagesCnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.tbxFolder);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "ImageDateNamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbxFolder;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImagesCnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImageTotalCnt;
        private System.Windows.Forms.Label lblImagesNoDateCnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblImageNoDateTotalCnt;
        private System.Windows.Forms.TextBox tbxDestFolder;
        private System.Windows.Forms.Button btnDestBrowse;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLoadsCnt;
    }
}

