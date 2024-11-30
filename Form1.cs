namespace Bt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddname_Click(object sender, EventArgs e)
        {
            string lastName = txtLastname.Text.Trim();
            string firstName = txtFirstname.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(phone))
            {
                // Add the new name to the ListView
                ListViewItem item = new ListViewItem(lastName);
                item.SubItems.Add(firstName);
                item.SubItems.Add(phone);
                listView1.Items.Add(item);

                // Clear the text boxes
                txtLastname.Clear();
                txtFirstname.Clear();
                txtPhone.Clear();
            }
            else
            {
                // Display an error message or warning
                MessageBox.Show("Please enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
