using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_ListApplication
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();      
            priorityBox.Items.Add("LOW");
            priorityBox.Items.Add("MEDIUM");
            priorityBox.Items.Add("HIGH");
            dueDatePicker.MinDate = DateTime.Now;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (nameBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill the Title ");
                nameBox.Focus();
                return;
            }
            else 
            { 
            db.InsertData(nameBox.Text, descBox.Text, dueDatePicker.Value.Date, priorityBox.SelectedItem.ToString(), isCompletedCheck.Checked);
            MessageBox.Show("Task Added!!" +
                 "Press Load Task to View changes");
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void dueDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
