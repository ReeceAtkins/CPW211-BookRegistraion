namespace CPW211_BookRegistration
{
    partial class AddCustomer
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
            dtpDateOfBirth = new DateTimePicker();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddCustomer = new Button();
            lblErrorTitle = new Label();
            lblErrorLastName = new Label();
            lblFirstName = new Label();
            lblErrorDateOfBirth = new Label();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(122, 9);
            dtpDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(219, 23);
            dtpDateOfBirth.TabIndex = 0;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(122, 40);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(219, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(122, 76);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(219, 23);
            txtLastName.TabIndex = 2;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(122, 111);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(219, 23);
            txtTitle.TabIndex = 3;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 46);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 82);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 116);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Title";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(122, 176);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(219, 59);
            btnAddCustomer.TabIndex = 8;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lblErrorTitle
            // 
            lblErrorTitle.AutoSize = true;
            lblErrorTitle.ForeColor = Color.Red;
            lblErrorTitle.Location = new Point(359, 116);
            lblErrorTitle.Name = "lblErrorTitle";
            lblErrorTitle.Size = new Size(0, 15);
            lblErrorTitle.TabIndex = 12;
            // 
            // lblErrorLastName
            // 
            lblErrorLastName.AutoSize = true;
            lblErrorLastName.ForeColor = Color.Red;
            lblErrorLastName.Location = new Point(359, 82);
            lblErrorLastName.Name = "lblErrorLastName";
            lblErrorLastName.Size = new Size(0, 15);
            lblErrorLastName.TabIndex = 11;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.Red;
            lblFirstName.Location = new Point(359, 46);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(0, 15);
            lblFirstName.TabIndex = 10;
            // 
            // lblErrorDateOfBirth
            // 
            lblErrorDateOfBirth.AutoSize = true;
            lblErrorDateOfBirth.ForeColor = Color.Red;
            lblErrorDateOfBirth.Location = new Point(359, 14);
            lblErrorDateOfBirth.Name = "lblErrorDateOfBirth";
            lblErrorDateOfBirth.Size = new Size(0, 15);
            lblErrorDateOfBirth.TabIndex = 9;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(122, 148);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(0, 15);
            lblErrorMsg.TabIndex = 13;
            // 
            // AddCustomer
            // 
            AcceptButton = btnAddCustomer;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 246);
            Controls.Add(lblErrorMsg);
            Controls.Add(lblErrorTitle);
            Controls.Add(lblErrorLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblErrorDateOfBirth);
            Controls.Add(btnAddCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dtpDateOfBirth);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCustomer";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDateOfBirth;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddCustomer;
        private Label lblErrorTitle;
        private Label lblErrorLastName;
        private Label lblFirstName;
        private Label lblErrorDateOfBirth;
        private Label lblErrorMsg;
    }
}