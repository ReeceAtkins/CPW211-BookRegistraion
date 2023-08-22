namespace CPW211_BookRegistration
{
    partial class AddBook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtISBN = new TextBox();
            btnAddBook = new Button();
            lblErrorTitle = new Label();
            lblErrorPrice = new Label();
            lblErrorISBN = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 79);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 130);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(75, 33);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(201, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(75, 79);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(201, 27);
            txtPrice.TabIndex = 1;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(75, 127);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(201, 27);
            txtISBN.TabIndex = 2;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(75, 172);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(201, 72);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // lblErrorTitle
            // 
            lblErrorTitle.AutoSize = true;
            lblErrorTitle.ForeColor = Color.Red;
            lblErrorTitle.Location = new Point(302, 40);
            lblErrorTitle.Name = "lblErrorTitle";
            lblErrorTitle.Size = new Size(0, 20);
            lblErrorTitle.TabIndex = 7;
            // 
            // lblErrorPrice
            // 
            lblErrorPrice.AutoSize = true;
            lblErrorPrice.ForeColor = Color.Red;
            lblErrorPrice.Location = new Point(302, 86);
            lblErrorPrice.Name = "lblErrorPrice";
            lblErrorPrice.Size = new Size(0, 20);
            lblErrorPrice.TabIndex = 8;
            // 
            // lblErrorISBN
            // 
            lblErrorISBN.AutoSize = true;
            lblErrorISBN.ForeColor = Color.Red;
            lblErrorISBN.Location = new Point(302, 134);
            lblErrorISBN.Name = "lblErrorISBN";
            lblErrorISBN.Size = new Size(0, 20);
            lblErrorISBN.TabIndex = 9;
            // 
            // AddBook
            // 
            AcceptButton = btnAddBook;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 296);
            Controls.Add(lblErrorISBN);
            Controls.Add(lblErrorPrice);
            Controls.Add(lblErrorTitle);
            Controls.Add(btnAddBook);
            Controls.Add(txtISBN);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBook";
            Text = "AddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private TextBox txtISBN;
        private Button btnAddBook;
        private Label lblErrorTitle;
        private Label lblErrorPrice;
        private Label lblErrorISBN;
    }
}