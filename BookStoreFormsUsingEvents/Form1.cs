using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreCodeFirstFromDB;

namespace BookStoreFormsUsingEvents
{
    public partial class BookStoreFormsUsingEventsMainForm : Form
    {
        private BookStoreContext context;
        private bool newRow = false;
        public BookStoreFormsUsingEventsMainForm()
        {
            InitializeComponent();
            Text = "Book Store Forms App that uses eventhandlers for data grids";
            // set up the context and initialize the database
            context = new BookStoreContext();
            context.SeedDatabase();
            context.SaveChanges();

            Load += (s, e) => BookStoreFormLoad();
        }
        // Set up all of the datagrid controls
        private void BookStoreFormLoad()
        {
            DataGridInitialize<Customer>(dataGridViewCustomer, "Orders");
            DataGridInitialize<Book>(dataGridViewBook, "Orders");
            DataGridInitialize<Order>(dataGridViewOrder, "Customer", "Book");

        }
        private void CommitChanges()
        {

            foreach (Order order in context.Orders)
            {
                if (order.Customer == null || order.Book == null)
                    context.Orders.Remove(order);
            }

            // update the database
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot update the database: " + ex.Message);
                Environment.Exit(1);
            }

            // refresh the controls
            dataGridViewCustomer.Refresh();
            dataGridViewBook.Refresh();
            dataGridViewOrder.Refresh();

        }
        private void DataGridInitialize<T>(DataGridView dataGrid, params string[] props) where T : class
        {
            // User can add and delete rows
            dataGrid.AllowUserToAddRows = true;
            dataGrid.AllowUserToDeleteRows = true;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;

            // Set the state to row being added. Row will be added to the db
            // in the RowValidated event handler
            dataGrid.UserAddedRow += (s, e) => { newRow = true; };
            dataGrid.RowValidated += (s, e) => FinishedAddingRow<T>(s as DataGridView, e);

            // Commit changes, if user deleted a row
            dataGrid.UserDeletedRow += (s, e) => { CommitChanges(); };
            dataGrid.CellValueChanged += (s, e) => { CommitChanges(); };

            // data from database seed the control. Generic version is used in order to avoid copying
            // the logic for each control
            DbSet<T> dbSet = context.Set<T>();
            dbSet.Load();
            dataGrid.DataSource = dbSet.Local.ToBindingList<T>();

            // columns are autocreated, but skip the properties
            foreach (string column in props)
                dataGrid.Columns[column].Visible = false;
        }
        // If the row is validated, we can add it to the database
        private void FinishedAddingRow<T>(DataGridView dataGrid, DataGridViewCellEventArgs e) where T : class
        {
            DataGridViewRow row = dataGrid.Rows[e.RowIndex];

            if (newRow == false)
                return;

            CommitChanges();
            newRow = false;
        }
    }
}
