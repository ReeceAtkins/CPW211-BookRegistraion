namespace CPW211_BookRegistration
{
    partial class Delete
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
            tabControl = new TabControl();
            Customers = new TabPage();
            lblCustomerError = new Label();
            label1 = new Label();
            cboCustomer = new ComboBox();
            Books = new TabPage();
            lblBookError = new Label();
            label2 = new Label();
            cboBook = new ComboBox();
            tabPage1 = new TabPage();
            lblRegistrationError = new Label();
            label3 = new Label();
            cboRegistration = new ComboBox();
            btnDelete = new Button();
            tabControl.SuspendLayout();
            Customers.SuspendLayout();
            Books.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(Customers);
            tabControl.Controls.Add(Books);
            tabControl.Controls.Add(tabPage1);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(288, 250);
            tabControl.TabIndex = 7;
            // 
            // Customers
            // 
            Customers.Controls.Add(lblCustomerError);
            Customers.Controls.Add(label1);
            Customers.Controls.Add(cboCustomer);
            Customers.Location = new Point(4, 29);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(3);
            Customers.Size = new Size(280, 217);
            Customers.TabIndex = 0;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // lblCustomerError
            // 
            lblCustomerError.AutoSize = true;
            lblCustomerError.ForeColor = Color.Red;
            lblCustomerError.Location = new Point(35, 106);
            lblCustomerError.Name = "lblCustomerError";
            lblCustomerError.Size = new Size(0, 20);
            lblCustomerError.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 19);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "Select a Customer to Delete";
            // 
            // cboCustomer
            // 
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(35, 62);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(194, 28);
            cboCustomer.TabIndex = 0;
            // 
            // Books
            // 
            Books.Controls.Add(lblBookError);
            Books.Controls.Add(label2);
            Books.Controls.Add(cboBook);
            Books.Location = new Point(4, 29);
            Books.Name = "Books";
            Books.Padding = new Padding(3);
            Books.Size = new Size(280, 217);
            Books.TabIndex = 1;
            Books.Text = "Books";
            Books.UseVisualStyleBackColor = true;
            // 
            // lblBookError
            // 
            lblBookError.AutoSize = true;
            lblBookError.ForeColor = Color.Red;
            lblBookError.Location = new Point(61, 112);
            lblBookError.Name = "lblBookError";
            lblBookError.Size = new Size(0, 20);
            lblBookError.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 23);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 7;
            label2.Text = "Select a Book to Delete";
            // 
            // cboBook
            // 
            cboBook.FormattingEnabled = true;
            cboBook.Location = new Point(32, 66);
            cboBook.Name = "cboBook";
            cboBook.Size = new Size(206, 28);
            cboBook.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblRegistrationError);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cboRegistration);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(280, 217);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Registration";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRegistrationError
            // 
            lblRegistrationError.AutoSize = true;
            lblRegistrationError.ForeColor = Color.Red;
            lblRegistrationError.Location = new Point(52, 94);
            lblRegistrationError.Name = "lblRegistrationError";
            lblRegistrationError.Size = new Size(0, 20);
            lblRegistrationError.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 19);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 1;
            label3.Text = "Select a registration to delete";
            // 
            // cboRegistration
            // 
            cboRegistration.FormattingEnabled = true;
            cboRegistration.Location = new Point(6, 52);
            cboRegistration.Name = "cboRegistration";
            cboRegistration.Size = new Size(268, 28);
            cboRegistration.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(16, 268);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(284, 123);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 467);
            Controls.Add(tabControl);
            Controls.Add(btnDelete);
            Name = "Delete";
            Text = "Delete";
            Load += Delete_Load;
            tabControl.ResumeLayout(false);
            Customers.ResumeLayout(false);
            Customers.PerformLayout();
            Books.ResumeLayout(false);
            Books.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage Customers;
        private Label label1;
        private ComboBox cboCustomer;
        private TabPage Books;
        private Label label2;
        private ComboBox cboBook;
        private TabPage tabPage1;
        private Label label3;
        private ComboBox cboRegistration;
        private Button btnDelete;
        private Label lblCustomerError;
        private Label lblBookError;
        private Label lblRegistrationError;
    }
}