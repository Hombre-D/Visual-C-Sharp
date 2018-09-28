using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        private BooksExamples.BooksEntities dbContext =
            new BooksExamples.BooksEntities();

        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            dbContext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            authorBindingSource.DataSource = dbContext.Authors.Local;
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            authorBindingSource.EndEdit();
            try
            {
                dbContext.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values",
                    "Entity Validation Exception");
            }
        }
    }
}
