using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private AddressExample.AddressBookEntities dbcontext = null;

        private void RefreshContacts()
        {
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }

            dbcontext = new AddressExample.AddressBookEntities();

            dbcontext.Addresses
                .OrderBy(entry => entry.LastName)
                .ThenBy(entry => entry.FirstName)
                .Load();

            addressBindingSource.DataSource = dbcontext.Addresses.Local;
            addressBindingSource.MoveFirst();
            findTextBox.Clear();

        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            RefreshContacts();
        }

        private void addressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            addressBindingSource.EndEdit();

            try
            {
                dbcontext.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("Columns cannot be empty", "Entity Validation Exception");
            }

            RefreshContacts();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var lastNameQuery =
                from address in dbcontext.Addresses
                where address.LastName.StartsWith(findTextBox.Text)
                orderby address.LastName, address.FirstName
                select address;

            addressBindingSource.DataSource = lastNameQuery.ToList();
            addressBindingSource.MoveFirst();

            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void browseAllButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            RefreshContacts();
        }
    }
}
