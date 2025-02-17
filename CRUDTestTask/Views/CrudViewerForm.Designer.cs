namespace CRUDTestTask
{
    partial class CrudViewerForm
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
            userListBox = new ListBox();
            loginTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            firstNameTextBox = new TextBox();
            label3 = new Label();
            lastNameTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // userListBox
            // 
            userListBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userListBox.FormattingEnabled = true;
            userListBox.ItemHeight = 21;
            userListBox.Location = new Point(3, 2);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(792, 319);
            userListBox.TabIndex = 0;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(78, 352);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(169, 23);
            loginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 350);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 2;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(262, 350);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 4;
            label2.Text = "Имя:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(321, 352);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(169, 23);
            firstNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(496, 350);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 6;
            label3.Text = "Фамилия:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(597, 352);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(198, 23);
            lastNameTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.Location = new Point(3, 395);
            addButton.Name = "addButton";
            addButton.Size = new Size(131, 62);
            addButton.TabIndex = 7;
            addButton.Text = "Добавить пользователя";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            updateButton.Location = new Point(287, 395);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(171, 62);
            updateButton.TabIndex = 8;
            updateButton.Text = "Обновить данные пользователя";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(617, 395);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(171, 62);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Удалить пользователя";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // CrudViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(firstNameTextBox);
            Controls.Add(label1);
            Controls.Add(loginTextBox);
            Controls.Add(userListBox);
            Name = "CrudViewerForm";
            Text = "CRUD Viewer";
            Load += CrudViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox userListBox;
        private TextBox loginTextBox;
        private Label label1;
        private Label label2;
        private TextBox firstNameTextBox;
        private Label label3;
        private TextBox lastNameTextBox;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
    }
}
