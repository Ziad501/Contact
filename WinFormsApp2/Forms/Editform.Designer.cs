namespace WinFormsApp2
{
    partial class Editform
    {

        private System.ComponentModel.IContainer components = null;

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
            button5 = new Button();
            button4 = new Button();
            email = new TextBox();
            last_name = new TextBox();
            first_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Add = new Button();
            dataGridView1 = new DataGridView();
            gender = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(74, 417);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(85, 39);
            button5.TabIndex = 25;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(141, 341);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(85, 39);
            button4.TabIndex = 24;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // email
            // 
            email.Location = new Point(99, 195);
            email.Margin = new Padding(5, 4, 5, 4);
            email.Name = "email";
            email.Size = new Size(142, 27);
            email.TabIndex = 22;
            // 
            // last_name
            // 
            last_name.Location = new Point(98, 121);
            last_name.Margin = new Padding(5, 4, 5, 4);
            last_name.Name = "last_name";
            last_name.Size = new Size(142, 27);
            last_name.TabIndex = 21;
            // 
            // first_name
            // 
            first_name.Location = new Point(99, 47);
            first_name.Margin = new Padding(5, 4, 5, 4);
            first_name.Name = "first_name";
            first_name.Size = new Size(142, 27);
            first_name.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(10, 280);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 19;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 205);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 18;
            label3.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 132);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 16;
            label1.Text = "First Name";
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Add.Location = new Point(17, 341);
            Add.Margin = new Padding(5, 4, 5, 4);
            Add.Name = "Add";
            Add.Size = new Size(85, 39);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(251, 13);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(605, 477);
            dataGridView1.TabIndex = 26;
            // 
            // gender
            // 
            gender.Location = new Point(99, 277);
            gender.Margin = new Padding(5, 4, 5, 4);
            gender.Name = "gender";
            gender.Size = new Size(142, 27);
            gender.TabIndex = 23;
            // 
            // Editform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_02_23_0752452;
            ClientSize = new Size(867, 503);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(gender);
            Controls.Add(email);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Add);
            Name = "Editform";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private TextBox email;
        private TextBox last_name;
        private TextBox first_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Add;
        private DataGridView dataGridView1;
        private TextBox gender;
    }
}
