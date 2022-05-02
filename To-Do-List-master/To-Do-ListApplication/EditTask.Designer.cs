﻿
namespace To_Do_ListApplication
{
    partial class EditTask
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
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.isCompletedCheck = new System.Windows.Forms.CheckBox();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(115, 169);
            this.priorityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(265, 24);
            this.priorityBox.TabIndex = 25;
            // 
            // isCompletedCheck
            // 
            this.isCompletedCheck.AutoSize = true;
            this.isCompletedCheck.Location = new System.Drawing.Point(115, 222);
            this.isCompletedCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isCompletedCheck.Name = "isCompletedCheck";
            this.isCompletedCheck.Size = new System.Drawing.Size(119, 21);
            this.isCompletedCheck.TabIndex = 24;
            this.isCompletedCheck.Text = "Is Completed?";
            this.isCompletedCheck.UseVisualStyleBackColor = true;
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(115, 130);
            this.dueDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(265, 22);
            this.dueDatePicker.TabIndex = 23;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(7, 169);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(52, 17);
            this.priorityLabel.TabIndex = 22;
            this.priorityLabel.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Due Date";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(115, 86);
            this.descBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(265, 22);
            this.descBox.TabIndex = 20;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(7, 86);
            this.descLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(79, 17);
            this.descLabel.TabIndex = 19;
            this.descLabel.Text = "Description";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(115, 36);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(265, 22);
            this.nameBox.TabIndex = 18;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 36);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Name";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(115, 266);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 28);
            this.editBtn.TabIndex = 16;
            this.editBtn.Text = "Update";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 348);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.isCompletedCheck);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.editBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditTask";
            this.Text = "EditTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.CheckBox isCompletedCheck;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button editBtn;
    }
}