using System.Data;
using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entities;

namespace WinFormsApp2
{

    public partial class Editform : Form
    {
        public Editform()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            var dbContext = new ApplicationDbContext();
            dataGridView1.DataSource = dbContext.Employees.ToList();
        }

        //function to add data to DB

        private void SaveToDatabase()
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                var dbContext = new ApplicationDbContext();

                bool ignoreFirstColumn = dataTable.Columns.Count > 0 && dataTable.Columns[0].ColumnName == "Id";

                foreach (DataRow row in dataTable.Rows)
                {
                    var record = new Employee
                    {
                        Id = ignoreFirstColumn ? int.TryParse(row["Id"].ToString(), out int Id) ? Id : 0 : 0,
                        FirstName = row[1].ToString(),
                        LastName = row[2].ToString(),
                        Email = row[3].ToString(),
                        Gender = row[4].ToString(),

                    };

                    dbContext.Employees.Add(record);
                }

                dbContext.SaveChanges();
                MessageBox.Show("Data successfully exported to SQL!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //to catch the textbox and use it

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                first_name.Text = dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString();
                last_name.Text = dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString();
                email.Text = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
                gender.Text = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
            }
        }


        //add btn to add new record

        private void Add_Click(object sender, EventArgs e)
        {
            var dbContext = new ApplicationDbContext();
            var newEmployee = new Employee
            {
                FirstName = first_name.Text,
                LastName = last_name.Text,
                Email = email.Text,
                Gender = gender.Text
            };

            dbContext.Employees.Add(newEmployee);
            dbContext.SaveChanges();
            MessageBox.Show("New record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataFromDatabase();

            first_name.Text = "";
            last_name.Text = "";
            email.Text = "";
            gender.Text = "";
        }

        //Update btn to update the chosen record

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                var dbContext = new ApplicationDbContext();
                var employee = dbContext.Employees.Find(id);
                if (employee != null)
                {
                    employee.FirstName = first_name.Text;
                    employee.LastName = last_name.Text;
                    employee.Email = email.Text;
                    employee.Gender = gender.Text;

                    dbContext.SaveChanges();
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //deltet btn to delete the chosen record

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                var dbContext = new ApplicationDbContext();
                var employee = dbContext.Employees.Find(id);
                if (employee != null)
                {
                    dbContext.Employees.Remove(employee);
                    dbContext.SaveChanges();
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
