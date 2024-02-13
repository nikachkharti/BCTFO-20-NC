namespace BankApplication
{
    partial class Form1
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
            headerLabel = new Label();
            dataList = new ListBox();
            nameValue = new TextBox();
            nameLabel = new Label();
            pinValue = new TextBox();
            pinLabel = new Label();
            phoneValue = new TextBox();
            phoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            accountTypeValue = new TextBox();
            accountTypeLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(824, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(308, 45);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "მომხმარებლები";
            // 
            // dataList
            // 
            dataList.Cursor = Cursors.Hand;
            dataList.Dock = DockStyle.Bottom;
            dataList.FormattingEnabled = true;
            dataList.ItemHeight = 25;
            dataList.Location = new Point(0, 465);
            dataList.Name = "dataList";
            dataList.Size = new Size(1144, 279);
            dataList.TabIndex = 1;
            dataList.SelectedIndexChanged += dataList_SelectedIndexChanged;
            // 
            // nameValue
            // 
            nameValue.Location = new Point(12, 244);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(249, 31);
            nameValue.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 216);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(82, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "სახელი";
            // 
            // pinValue
            // 
            pinValue.Location = new Point(267, 244);
            pinValue.Name = "pinValue";
            pinValue.Size = new Size(249, 31);
            pinValue.TabIndex = 2;
            // 
            // pinLabel
            // 
            pinLabel.AutoSize = true;
            pinLabel.Location = new Point(267, 216);
            pinLabel.Name = "pinLabel";
            pinLabel.Size = new Size(157, 25);
            pinLabel.TabIndex = 3;
            pinLabel.Text = "პირადი ნომერი";
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(267, 330);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(249, 31);
            phoneValue.TabIndex = 2;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(267, 302);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(200, 25);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "ტელეფონის ნომერი";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(12, 330);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(249, 31);
            emailValue.TabIndex = 2;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 302);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(111, 25);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "ელ-ფოსტა";
            // 
            // accountTypeValue
            // 
            accountTypeValue.Location = new Point(522, 244);
            accountTypeValue.Name = "accountTypeValue";
            accountTypeValue.Size = new Size(249, 31);
            accountTypeValue.TabIndex = 2;
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Location = new Point(522, 216);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new Size(160, 25);
            accountTypeLabel.TabIndex = 3;
            accountTypeLabel.Text = "ანგარიშის ტიპი";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 744);
            Controls.Add(accountTypeLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            Controls.Add(accountTypeValue);
            Controls.Add(pinLabel);
            Controls.Add(emailValue);
            Controls.Add(nameLabel);
            Controls.Add(phoneValue);
            Controls.Add(pinValue);
            Controls.Add(nameValue);
            Controls.Add(dataList);
            Controls.Add(headerLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ListBox dataList;
        private TextBox nameValue;
        private Label nameLabel;
        private TextBox pinValue;
        private Label pinLabel;
        private TextBox phoneValue;
        private Label phoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox accountTypeValue;
        private Label accountTypeLabel;
    }
}
