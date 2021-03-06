﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DisplayQueryResult
{
    public partial class TitleQueries : Form
    {
        public TitleQueries()
        {
            InitializeComponent();
        }

        private BooksExamples.BooksEntities dbcontext =
            new BooksExamples.BooksEntities();

        private void TitleQueries_Load(object sender, EventArgs e)
        {
            dbcontext.Titles.Load();
            queriesComboBox.SelectedIndex = 0;
        }

        private void queriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (queriesComboBox.SelectedIndex)
            {
                case 0:
                    titleBindingSource.DataSource =
                        dbcontext.Titles.Local.OrderBy(book => book.Title1);
                    break;
                case 1:
                    titleBindingSource.DataSource =
                        dbcontext.Titles.Local
                            .Where(book => book.Copyright == "2016")
                            .OrderBy(book => book.Title1);
                    break;
                case 2:
                    titleBindingSource.DataSource =
                        dbcontext.Titles.Local
                            .Where(
                                book => book.Title1.EndsWith("How to Program"))
                            .OrderBy(book => book.Title1);
                    break;
            }

            titleBindingSource.MoveFirst();
        }
    }
}
