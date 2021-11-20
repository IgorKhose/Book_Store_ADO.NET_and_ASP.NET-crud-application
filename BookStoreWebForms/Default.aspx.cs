using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreCodeFirstFromDB;
using System.Web.ModelBinding;

namespace BookStoreWebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // create a context to get database's data
            using(BookStoreContext context = new BookStoreContext())
            {
                context.SeedDatabase();
            }
        }
        public IEnumerable<Customer> CustomersGetData()
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                return context.Customers.ToList();
            }
            
        }
        // Add a customer to Customers. Update the filter list and rebind the data.
        protected void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                Customer customer = new Customer
                {
                    FirstName = textBoxCustomerFirstName.Text,
                    LastName = textBoxCustomerLastName.Text
                };

                context.Customers.Add(customer);
                context.SaveChanges();
            }

            gridViewCustomers.DataBind();

        }
        // Check customers and delete one that matches the customerId
        public void GridViewCustomer_DeleteItem(int customerId)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                Customer customer = context.Customers.Find(customerId);

                context.Customers.Remove(customer);

                context.SaveChanges();
            }
        }

        // The argument is provided by the model, and must match the id from DataKeyNames, but is case insensitive.
        public void GridViewCustomer_UpdateItem(int customerId)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                Customer customer = context.Customers.Find(customerId);

                if (customer == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", customerId));
                    return;
                }

                // updates the model (basically context.Inventories)

                TryUpdateModel(customer);
                if (ModelState.IsValid)
                {
                    // everthing is ok, so save the changes and update the filter list
                    context.SaveChanges();

                }
            }
        }
    }
}