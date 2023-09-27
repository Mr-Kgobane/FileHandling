namespace Exercise_2
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnAdd2List = new System.Windows.Forms.Button();
            this.btnSave2File = new System.Windows.Forms.Button();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(70, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(53, 115);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname;";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(158, 109);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(249, 22);
            this.txtSurname.TabIndex = 4;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(84, 177);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(33, 16);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Job:";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(158, 171);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(249, 22);
            this.txtJob.TabIndex = 6;
            // 
            // btnAdd2List
            // 
            this.btnAdd2List.Location = new System.Drawing.Point(317, 231);
            this.btnAdd2List.Name = "btnAdd2List";
            this.btnAdd2List.Size = new System.Drawing.Size(89, 23);
            this.btnAdd2List.TabIndex = 7;
            this.btnAdd2List.Text = "Add To List";
            this.btnAdd2List.UseVisualStyleBackColor = true;
            this.btnAdd2List.Click += new System.EventHandler(this.btnAdd2List_Click);
            // 
            // btnSave2File
            // 
            this.btnSave2File.Location = new System.Drawing.Point(198, 322);
            this.btnSave2File.Name = "btnSave2File";
            this.btnSave2File.Size = new System.Drawing.Size(94, 23);
            this.btnSave2File.TabIndex = 8;
            this.btnSave2File.Text = "Save To File";
            this.btnSave2File.UseVisualStyleBackColor = true;
            this.btnSave2File.Click += new System.EventHandler(this.btnSave2File_Click);
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.Location = new System.Drawing.Point(181, 372);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(132, 23);
            this.btnReadFromFile.TabIndex = 9;
            this.btnReadFromFile.Text = "Read From File";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(500, 22);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(461, 404);
            this.lstDisplay.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.btnSave2File);
            this.Controls.Add(this.btnAdd2List);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnAdd2List;
        private System.Windows.Forms.Button btnSave2File;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.ListBox lstDisplay;
    }
}

