﻿namespace DevOps_Migration_Helper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnForNot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtCollectionUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConformProjects = new System.Windows.Forms.Button();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnConformProject = new System.Windows.Forms.Button();
            this.btnConformErrorProjects = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFixTF402577 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Folder:";
            // 
            // lblFolder
            // 
            this.lblFolder.Location = new System.Drawing.Point(309, 56);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(389, 13);
            this.lblFolder.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(703, 51);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Change";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // txtFiles
            // 
            this.txtFiles.Location = new System.Drawing.Point(312, 120);
            this.txtFiles.Multiline = true;
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(434, 95);
            this.txtFiles.TabIndex = 4;
            this.txtFiles.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Files:";
            // 
            // btnForNot
            // 
            this.btnForNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForNot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnForNot.Location = new System.Drawing.Point(12, 56);
            this.btnForNot.Name = "btnForNot";
            this.btnForNot.Size = new System.Drawing.Size(175, 23);
            this.btnForNot.TabIndex = 6;
            this.btnForNot.Text = "2- FIX TF402584";
            this.toolTip1.SetToolTip(this.btnForNot, " Field rule attributes for or not aren\'t supported.");
            this.btnForNot.UseVisualStyleBackColor = true;
            this.btnForNot.Click += new System.EventHandler(this.BtnForNot_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(12, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "3- FIX TF402582";
            this.toolTip1.SetToolTip(this.button2, " Work item custom control is not supported.  ");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnFIXTF402582);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(13, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "4- FIX TF402539";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFIXTF402539);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button4.Location = new System.Drawing.Point(12, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "1- Clean Logs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnCleanLogs);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(13, 202);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "6- Clean Empty Groups";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnCLeanEmptyGroups);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(13, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "5- Fix BugsWorkItems";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnFixBugsWorkitems);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(198, 352);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // txtCollectionUrl
            // 
            this.txtCollectionUrl.Location = new System.Drawing.Point(312, 21);
            this.txtCollectionUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtCollectionUrl.Name = "txtCollectionUrl";
            this.txtCollectionUrl.Size = new System.Drawing.Size(434, 20);
            this.txtCollectionUrl.TabIndex = 14;
            this.txtCollectionUrl.Text = "http://localhost/DefaultCollection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Collection Url:";
            // 
            // btnConformProjects
            // 
            this.btnConformProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConformProjects.ForeColor = System.Drawing.Color.Maroon;
            this.btnConformProjects.Location = new System.Drawing.Point(12, 259);
            this.btnConformProjects.Name = "btnConformProjects";
            this.btnConformProjects.Size = new System.Drawing.Size(174, 23);
            this.btnConformProjects.TabIndex = 10;
            this.btnConformProjects.Text = "7- Conform ALL Projects";
            this.btnConformProjects.UseVisualStyleBackColor = true;
            this.btnConformProjects.Click += new System.EventHandler(this.btnConformProjects_Click);
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Location = new System.Drawing.Point(312, 229);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(126, 23);
            this.btnClearConsole.TabIndex = 15;
            this.btnClearConsole.Text = "Clear Console";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.BtnClearConsole_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "LogFile:";
            // 
            // lblLogFile
            // 
            this.lblLogFile.Location = new System.Drawing.Point(309, 85);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(389, 13);
            this.lblLogFile.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(705, 81);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(54, 23);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnConformProject
            // 
            this.btnConformProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConformProject.ForeColor = System.Drawing.Color.Maroon;
            this.btnConformProject.Location = new System.Drawing.Point(13, 286);
            this.btnConformProject.Name = "btnConformProject";
            this.btnConformProject.Size = new System.Drawing.Size(174, 23);
            this.btnConformProject.TabIndex = 10;
            this.btnConformProject.Text = "Conform Error Project";
            this.btnConformProject.UseVisualStyleBackColor = true;
            this.btnConformProject.Click += new System.EventHandler(this.BtnConformProject_Click);
            // 
            // btnConformErrorProjects
            // 
            this.btnConformErrorProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConformErrorProjects.ForeColor = System.Drawing.Color.Maroon;
            this.btnConformErrorProjects.Location = new System.Drawing.Point(12, 230);
            this.btnConformErrorProjects.Name = "btnConformErrorProjects";
            this.btnConformErrorProjects.Size = new System.Drawing.Size(174, 23);
            this.btnConformErrorProjects.TabIndex = 10;
            this.btnConformErrorProjects.Text = "7- Conform Error Projects";
            this.btnConformErrorProjects.UseVisualStyleBackColor = true;
            this.btnConformErrorProjects.Click += new System.EventHandler(this.BtnConformErrorProjects_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(13, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "GetErrorProjects";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnFixTF402577
            // 
            this.btnFixTF402577.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixTF402577.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFixTF402577.Location = new System.Drawing.Point(12, 145);
            this.btnFixTF402577.MaximumSize = new System.Drawing.Size(174, 23);
            this.btnFixTF402577.MinimumSize = new System.Drawing.Size(174, 23);
            this.btnFixTF402577.Name = "btnFixTF402577";
            this.btnFixTF402577.Size = new System.Drawing.Size(174, 23);
            this.btnFixTF402577.TabIndex = 9;
            this.btnFixTF402577.Text = "4- FIX TF402577";
            this.btnFixTF402577.UseVisualStyleBackColor = true;
            this.btnFixTF402577.Click += new System.EventHandler(this.BtnFixTF402577_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(791, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.txtCollectionUrl);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnConformProject);
            this.Controls.Add(this.btnConformErrorProjects);
            this.Controls.Add(this.btnConformProjects);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnFixTF402577);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnForNot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblLogFile);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Azure DevOps Migration Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnForNot;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtCollectionUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConformProjects;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnConformProject;
        private System.Windows.Forms.Button btnConformErrorProjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFixTF402577;
    }
}

