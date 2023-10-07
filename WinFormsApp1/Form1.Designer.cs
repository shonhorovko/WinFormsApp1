namespace WinFormsApp1
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
            label1 = new Label();
            FirstName = new TextBox();
            LastName = new TextBox();
            label2 = new Label();
            Phone = new TextBox();
            label3 = new Label();
            Email = new TextBox();
            label4 = new Label();
            Save = new Button();
            ErrorMessage = new Label();
            label0 = new Label();
            Place_of_residence = new TextBox();
            label6 = new Label();
            label = new Label();
            Gender = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 39);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(34, 67);
            FirstName.Margin = new Padding(1);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(260, 27);
            FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            LastName.Location = new Point(34, 144);
            LastName.Margin = new Padding(1);
            LastName.Name = "LastName";
            LastName.Size = new Size(260, 27);
            LastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 115);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // Phone
            // 
            Phone.Location = new Point(329, 63);
            Phone.Margin = new Padding(1);
            Phone.Name = "Phone";
            Phone.Size = new Size(260, 27);
            Phone.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 33);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // Email
            // 
            Email.Location = new Point(34, 223);
            Email.Margin = new Padding(1);
            Email.Name = "Email";
            Email.Size = new Size(260, 27);
            Email.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 193);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // Save
            // 
            Save.Location = new Point(500, 379);
            Save.Margin = new Padding(1);
            Save.Name = "Save";
            Save.Size = new Size(88, 28);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(34, 269);
            ErrorMessage.Margin = new Padding(1, 0, 1, 0);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 20);
            ErrorMessage.TabIndex = 9;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Location = new Point(329, 200);
            label0.Margin = new Padding(1, 0, 1, 0);
            label0.Name = "label0";
            label0.Size = new Size(57, 20);
            label0.TabIndex = 12;
            label0.Text = "Gender";
            // 
            // Place_of_residence
            // 
            Place_of_residence.Location = new Point(329, 144);
            Place_of_residence.Margin = new Padding(1);
            Place_of_residence.Name = "Place_of_residence";
            Place_of_residence.Size = new Size(260, 27);
            Place_of_residence.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 114);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(333, 114);
            label.Name = "label";
            label.Size = new Size(129, 20);
            label.TabIndex = 14;
            label.Text = "Place of residence";
            // 
            // Gender
            // 
            Gender.BackColor = Color.White;
            Gender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Gender.FormattingEnabled = true;
            Gender.ItemHeight = 23;
            Gender.Items.AddRange(new object[] { "Male", "Female" });
            Gender.Location = new Point(329, 223);
            Gender.Name = "Gender";
            Gender.Size = new Size(260, 27);
            Gender.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 417);
            Controls.Add(Gender);
            Controls.Add(label);
            Controls.Add(label0);
            Controls.Add(Place_of_residence);
            Controls.Add(label6);
            Controls.Add(ErrorMessage);
            Controls.Add(Save);
            Controls.Add(Phone);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(LastName);
            Controls.Add(label2);
            Controls.Add(FirstName);
            Controls.Add(label1);
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FirstName;
        private TextBox LastName;
        private Label label2;
        private TextBox Phone;
        private Label label3;
        private TextBox Email;
        private Label label4;
        private Button Save;
        private Label ErrorMessage;
        private Label label0;
        private TextBox Place_of_residence;
        private Label label6;
        private Label label;
        private ListBox Gender;
    }
}