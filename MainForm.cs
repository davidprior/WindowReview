using System;
using System.Windows.Forms;

namespace WindowReview
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      // step 7
      private void btnClear_Click(object sender, EventArgs e)
      {
         ClearData();
      }

      // step 8
      private void btnSend_Click(object sender, EventArgs e)
      {
         // step 10
         if (string.IsNullOrWhiteSpace(tbAddressee.Text))
         {
            MessageBox.Show("You cannot send an email without an addressee", "No Addressee", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         // step 11
         else if (string.IsNullOrWhiteSpace(tbTitle.Text))
         {
            DialogResult messageBoxResult = MessageBox.Show("You did not specify a title. Do you want to send the message without a title?", "No Title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (messageBoxResult == DialogResult.Yes)
            {
               MessageBox.Show($"The message has been sent to {tbAddressee.Text}.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
               ClearData();
            }
         }
         else
         {
            MessageBox.Show($"The message has been sent to {tbAddressee.Text}.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
         }
      }

      // step 9
      private void ClearData()
      {
         tbTitle.Text = string.Empty;
         tbAddressee.Text = string.Empty;
         tbContent.Text = string.Empty;
      }
    }
}
