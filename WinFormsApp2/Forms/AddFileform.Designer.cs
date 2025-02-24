namespace WinFormsApp2
{
    partial class AddFileform
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
            airButton3 = new ReaLTaiizor.Controls.AirButton();
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(266, 49);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 15;
            label1.Text = "Choose Page :";
            // 
            // airButton3
            // 
            airButton3.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            airButton3.Image = null;
            airButton3.Location = new Point(31, 75);
            airButton3.Name = "airButton3";
            airButton3.NoRounding = false;
            airButton3.Size = new Size(199, 35);
            airButton3.TabIndex = 17;
            airButton3.Text = "Apply Data to DataBase";
            airButton3.Transparent = false;
            airButton3.Click += airButton3_Click;
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            airButton1.Image = null;
            airButton1.Location = new Point(31, 35);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(199, 34);
            airButton1.TabIndex = 16;
            airButton1.Text = "Add";
            airButton1.Transparent = false;
            airButton1.Click += airButton1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 82);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(574, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 127);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(809, 364);
            dataGridView1.TabIndex = 13;
            // 
            // AddFileform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_02_23_0752451;
            ClientSize = new Size(867, 503);
            Controls.Add(label1);
            Controls.Add(airButton3);
            Controls.Add(airButton1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "AddFileform";
            Text = "AddFileform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ReaLTaiizor.Controls.AirButton airButton3;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}