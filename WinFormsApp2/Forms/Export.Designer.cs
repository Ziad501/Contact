namespace WinFormsApp2.Forms
{
    partial class Export
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
			button1 = new Button();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			button1.Location = new Point(309, 13);
			button1.Margin = new Padding(4);
			button1.Name = "button1";
			button1.Size = new Size(251, 47);
			button1.TabIndex = 0;
			button1.Text = "Export Excel sheet";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(13, 68);
			dataGridView1.Margin = new Padding(4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(842, 435);
			dataGridView1.TabIndex = 1;
			// 
			// Export
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.Screenshot_2025_02_23_0752453;
			ClientSize = new Size(867, 503);
			Controls.Add(dataGridView1);
			Controls.Add(button1);
			Margin = new Padding(4);
			Name = "Export";
			Text = "Export";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
        private DataGridView dataGridView1;
    }
}