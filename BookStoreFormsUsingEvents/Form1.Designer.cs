
namespace BookStoreFormsUsingEvents
{
    partial class BookStoreFormsUsingEventsMainForm
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
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.labelBooks = new System.Windows.Forms.Label();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(34, 50);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 51;
            this.dataGridViewBook.RowTemplate.Height = 24;
            this.dataGridViewBook.Size = new System.Drawing.Size(715, 223);
            this.dataGridViewBook.TabIndex = 0;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(39, 335);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(321, 223);
            this.dataGridViewCustomer.TabIndex = 1;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(428, 335);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(321, 223);
            this.dataGridViewOrder.TabIndex = 2;
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBooks.Location = new System.Drawing.Point(34, 13);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(69, 28);
            this.labelBooks.TabIndex = 3;
            this.labelBooks.Text = "Books";
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomers.Location = new System.Drawing.Point(34, 294);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(111, 28);
            this.labelCustomers.TabIndex = 4;
            this.labelCustomers.Text = "Customers";
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrders.Location = new System.Drawing.Point(423, 294);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(75, 28);
            this.labelOrders.TabIndex = 5;
            this.labelOrders.Text = "Orders";
            // 
            // BookStoreFormsUsingEventsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 579);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.labelCustomers);
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.dataGridViewBook);
            this.Name = "BookStoreFormsUsingEventsMainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.Label labelOrders;
    }
}

