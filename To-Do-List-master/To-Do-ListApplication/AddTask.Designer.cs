
namespace To_Do_ListApplication
{
    partial class AddTask
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
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(115, 164);
            this.priorityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(265, 24);
            this.priorityBox.TabIndex = 24;
            // 
            // isCompletedCheck
            // 
            this.isCompletedCheck.AutoSize = true;
            this.isCompletedCheck.Location = new System.Drawing.Point(115, 217);
            this.isCompletedCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isCompletedCheck.Name = "isCompletedCheck";
            this.isCompletedCheck.Size = new System.Drawing.Size(119, 21);
            this.isCompletedCheck.TabIndex = 23;
            this.isCompletedCheck.Text = "Is Completed?";
            this.isCompletedCheck.UseVisualStyleBackColor = true;
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(115, 126);
            this.dueDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(265, 22);
            this.dueDatePicker.TabIndex = 22;
            this.dueDatePicker.Value = new System.DateTime(2022, 4, 30, 16, 46, 11, 0);
            this.dueDatePicker.ValueChanged += new System.EventHandler(this.dueDatePicker_ValueChanged);
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(7, 164);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(52, 17);
            this.priorityLabel.TabIndex = 21;
            this.priorityLabel.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Due Date";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(115, 81);
            this.descBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(265, 22);
            this.descBox.TabIndex = 19;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(7, 81);
            this.descLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(79, 17);
            this.descLabel.TabIndex = 18;
            this.descLabel.Text = "Description";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(115, 36);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(265, 22);
            this.nameBox.TabIndex = 17;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 36);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 17);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Title";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // addBtn
            // 
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(115, 268);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(267, 28);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "Add Task";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 348);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.isCompletedCheck);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTask";
            this.Text = "AddTask";
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
        private System.Windows.Forms.Button addBtn;
    }
}