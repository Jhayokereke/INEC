
namespace VotingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enter_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Firstname_txtbox = new System.Windows.Forms.TextBox();
            this.Middlename_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lastname_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DOB_picker = new System.Windows.Forms.DateTimePicker();
            this.PollingUnit_cmbox = new System.Windows.Forms.ComboBox();
            this.Passport_picbox = new System.Windows.Forms.PictureBox();
            this.Gender_cmbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Passport_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter_btn
            // 
            this.Enter_btn.Location = new System.Drawing.Point(460, 455);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.Size = new System.Drawing.Size(94, 29);
            this.Enter_btn.TabIndex = 0;
            this.Enter_btn.Text = "Enter";
            this.Enter_btn.UseVisualStyleBackColor = true;
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firstname";
            // 
            // Firstname_txtbox
            // 
            this.Firstname_txtbox.Location = new System.Drawing.Point(12, 100);
            this.Firstname_txtbox.Name = "Firstname_txtbox";
            this.Firstname_txtbox.Size = new System.Drawing.Size(323, 27);
            this.Firstname_txtbox.TabIndex = 2;
            // 
            // Middlename_txtbox
            // 
            this.Middlename_txtbox.Location = new System.Drawing.Point(12, 168);
            this.Middlename_txtbox.Name = "Middlename_txtbox";
            this.Middlename_txtbox.Size = new System.Drawing.Size(323, 27);
            this.Middlename_txtbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Middlename";
            // 
            // Lastname_txtbox
            // 
            this.Lastname_txtbox.Location = new System.Drawing.Point(12, 235);
            this.Lastname_txtbox.Name = "Lastname_txtbox";
            this.Lastname_txtbox.Size = new System.Drawing.Size(323, 27);
            this.Lastname_txtbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Polling Unit";
            // 
            // DOB_picker
            // 
            this.DOB_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB_picker.Location = new System.Drawing.Point(12, 384);
            this.DOB_picker.Name = "DOB_picker";
            this.DOB_picker.Size = new System.Drawing.Size(323, 27);
            this.DOB_picker.TabIndex = 11;
            this.DOB_picker.Value = new System.DateTime(1954, 6, 12, 0, 0, 0, 0);
            // 
            // PollingUnit_cmbox
            // 
            this.PollingUnit_cmbox.AllowDrop = true;
            this.PollingUnit_cmbox.FormattingEnabled = true;
            this.PollingUnit_cmbox.Location = new System.Drawing.Point(12, 456);
            this.PollingUnit_cmbox.Name = "PollingUnit_cmbox";
            this.PollingUnit_cmbox.Size = new System.Drawing.Size(323, 28);
            this.PollingUnit_cmbox.TabIndex = 12;
            this.PollingUnit_cmbox.Text = "Unit";
            // 
            // Passport_picbox
            // 
            this.Passport_picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passport_picbox.InitialImage = null;
            this.Passport_picbox.Location = new System.Drawing.Point(405, 100);
            this.Passport_picbox.Name = "Passport_picbox";
            this.Passport_picbox.Size = new System.Drawing.Size(137, 132);
            this.Passport_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Passport_picbox.TabIndex = 13;
            this.Passport_picbox.TabStop = false;
            this.Passport_picbox.UseWaitCursor = true;
            this.Passport_picbox.WaitOnLoad = true;
            // 
            // Gender_cmbox
            // 
            this.Gender_cmbox.AllowDrop = true;
            this.Gender_cmbox.FormattingEnabled = true;
            this.Gender_cmbox.Location = new System.Drawing.Point(12, 308);
            this.Gender_cmbox.Name = "Gender_cmbox";
            this.Gender_cmbox.Size = new System.Drawing.Size(323, 28);
            this.Gender_cmbox.TabIndex = 15;
            this.Gender_cmbox.Text = "Select gender";
            this.Gender_cmbox.SelectedIndexChanged += new System.EventHandler(this.Gender_cmbox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 514);
            this.Controls.Add(this.Gender_cmbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Passport_picbox);
            this.Controls.Add(this.PollingUnit_cmbox);
            this.Controls.Add(this.DOB_picker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lastname_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Middlename_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Firstname_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Passport_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Firstname_txtbox;
        private System.Windows.Forms.TextBox Middlename_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Lastname_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DOB_picker;
        private System.Windows.Forms.ComboBox PollingUnit_cmbox;
        private System.Windows.Forms.PictureBox Passport_picbox;
        private System.Windows.Forms.ComboBox Gender_cmbox;
        private System.Windows.Forms.Label label6;
    }
}

