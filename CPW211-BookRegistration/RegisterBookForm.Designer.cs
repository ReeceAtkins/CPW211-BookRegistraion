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
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(12, 12);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(178, 84);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(12, 102);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(178, 84);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnRegisterBook
            // 
            btnRegisterBook.Location = new Point(293, 196);
            btnRegisterBook.Name = "btnRegisterBook";
            btnRegisterBook.Size = new Size(250, 84);
            btnRegisterBook.TabIndex = 2;
            btnRegisterBook.Text = "Register Book";
            btnRegisterBook.UseVisualStyleBackColor = true;
            // 
            // cboCustomers
            // 
            cboCustomers.FormattingEnabled = true;
            cboCustomers.Location = new Point(293, 12);
            cboCustomers.Name = "cboCustomers";
            cboCustomers.Size = new Size(250, 28);
            cboCustomers.TabIndex = 3;
            // 
            // cboBooks
            // 
            cboBooks.FormattingEnabled = true;
            cboBooks.Location = new Point(293, 80);
            cboBooks.Name = "cboBooks";
            cboBooks.Size = new Size(250, 28);
            cboBooks.TabIndex = 4;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(293, 141);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 20);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 6;
            label1.Text = "Customers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 88);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 7;
            label2.Text = "Books:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 148);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 8;
            label3.Text = "Date:";
            // 
            // lblCustomerError
            // 
            lblCustomerError.AutoSize = true;
            lblCustomerError.ForeColor = Color.Red;
            lblCustomerError.Location = new Point(549, 20);
            lblCustomerError.Name = "lblCustomerError";
            lblCustomerError.Size = new Size(0, 20);
            lblCustomerError.TabIndex = 9;
            // 
            // lblBookError
            // 
            lblBookError.AutoSize = true;
            lblBookError.ForeColor = Color.Red;
            lblBookError.Location = new Point(549, 88);
            lblBookError.Name = "lblBookError";
            lblBookError.Size = new Size(0, 20);
            lblBookError.TabIndex = 10;
            // 
            // lblDateError
            // 
            lblDateError.AutoSize = true;
            lblDateError.ForeColor = Color.Red;
            lblDateError.Location = new Point(549, 148);
            lblDateError.Name = "lblDateError";
            lblDateError.Size = new Size(0, 20);
            lblDateError.TabIndex = 11;
            // 
            // RegisterBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 362);
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
    }
}