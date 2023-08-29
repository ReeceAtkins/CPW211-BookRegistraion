namespace CPW211_BookRegistration
{
    partial class RegisterBookForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddCustomer = new Button();
            btnAddBook = new Button();
            btnRegisterBook = new Button();
            cboCustomers = new ComboBox();
            cboBooks = new ComboBox();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCustomerError = new Label();
            lblBookError = new Label();
            lblDateError = new Label();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(10, 9);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(156, 63);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(10, 76);
            btnAddBook.Margin = new Padding(3, 2, 3, 2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(156, 63);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnRegisterBook
            // 
            btnRegisterBook.Location = new Point(256, 180);
            btnRegisterBook.Margin = new Padding(3, 2, 3, 2);
            btnRegisterBook.Name = "btnRegisterBook";
            btnRegisterBook.Size = new Size(219, 63);
            btnRegisterBook.TabIndex = 3;
            btnRegisterBook.Text = "&Register Book";
            btnRegisterBook.UseVisualStyleBackColor = true;
            btnRegisterBook.Click += btnRegisterBook_Click;
            // 
            // cboCustomers
            // 
            cboCustomers.FormattingEnabled = true;
            cboCustomers.Location = new Point(256, 9);
            cboCustomers.Margin = new Padding(3, 2, 3, 2);
            cboCustomers.Name = "cboCustomers";
            cboCustomers.Size = new Size(219, 23);
            cboCustomers.TabIndex = 0;
            cboCustomers.SelectedIndexChanged += cboCustomers_SelectedIndexChanged;
            // 
            // cboBooks
            // 
            cboBooks.FormattingEnabled = true;
            cboBooks.Location = new Point(256, 60);
            cboBooks.Margin = new Padding(3, 2, 3, 2);
            cboBooks.Name = "cboBooks";
            cboBooks.Size = new Size(219, 23);
            cboBooks.TabIndex = 1;
            cboBooks.SelectedIndexChanged += cboBooks_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(256, 106);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(219, 23);
            dtpDate.TabIndex = 2;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Customers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 66);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Books:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 111);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 8;
            label3.Text = "Date:";
            // 
            // lblCustomerError
            // 
            lblCustomerError.AutoSize = true;
            lblCustomerError.ForeColor = Color.Red;
            lblCustomerError.Location = new Point(480, 15);
            lblCustomerError.Name = "lblCustomerError";
            lblCustomerError.Size = new Size(0, 15);
            lblCustomerError.TabIndex = 9;
            // 
            // lblBookError
            // 
            lblBookError.AutoSize = true;
            lblBookError.ForeColor = Color.Red;
            lblBookError.Location = new Point(480, 66);
            lblBookError.Name = "lblBookError";
            lblBookError.Size = new Size(0, 15);
            lblBookError.TabIndex = 10;
            // 
            // lblDateError
            // 
            lblDateError.AutoSize = true;
            lblDateError.ForeColor = Color.Red;
            lblDateError.Location = new Point(480, 111);
            lblDateError.Name = "lblDateError";
            lblDateError.Size = new Size(0, 15);
            lblDateError.TabIndex = 11;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(256, 147);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(0, 15);
            lblErrorMsg.TabIndex = 12;
            // 
            // RegisterBookForm
            // 
            AcceptButton = btnRegisterBook;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 272);
            Controls.Add(lblErrorMsg);
            Controls.Add(lblDateError);
            Controls.Add(lblBookError);
            Controls.Add(lblCustomerError);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(cboBooks);
            Controls.Add(cboCustomers);
            Controls.Add(btnRegisterBook);
            Controls.Add(btnAddBook);
            Controls.Add(btnAddCustomer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterBookForm";
            Text = "Register Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private Button btnAddBook;
        private Button btnRegisterBook;
        private ComboBox cboCustomers;
        private ComboBox cboBooks;
        private DateTimePicker dtpDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCustomerError;
        private Label lblBookError;
        private Label lblDateError;
        private Label lblErrorMsg;
    }
}