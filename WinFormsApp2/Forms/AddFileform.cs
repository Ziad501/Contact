using ClosedXML.Excel;
using System.Data;
using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entities;

namespace WinFormsApp2
{
    public partial class AddFileform : Form
    {
        private string selectedFilePath;

        public AddFileform()
        {
            InitializeComponent();
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Excel Sheet (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                LoadSheetsIntoComboBox(selectedFilePath);
            }
        }

        private void LoadSheetsIntoComboBox(string filePath)
        {
            try
            {
                using var workbook = new XLWorkbook(filePath);
                comboBox1.Items.Clear();

                foreach (var sheet in workbook.Worksheets)
                {
                    comboBox1.Items.Add(sheet.Name);
                }

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(selectedFilePath))
                return;

            string selectedSheet = comboBox1.SelectedItem.ToString();

            try
            {
                using var workbook = new XLWorkbook(selectedFilePath);
                var worksheet = workbook.Worksheet(selectedSheet);
                var dataTable = new DataTable();

                var headers = worksheet.Row(1).CellsUsed()
                    .Select(cell => cell.Value.ToString().Trim())
                    .Where(header => header.ToLower() != "id") 
                    .ToList();

                foreach (var header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    var newRow = dataTable.NewRow();
                    int columnIndex = 0;

                    foreach (var cell in row.CellsUsed())
                    {
                        string columnName = worksheet.Row(1).Cell(cell.Address.ColumnNumber).Value.ToString().Trim();

                        if (columnName.ToLower() != "id") 
                        {
                            newRow[columnIndex] = cell.Value.ToString();
                            columnIndex++;
                        }
                    }

                    dataTable.Rows.Add(newRow);
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load sheet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SaveToDatabase()
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                using var dbContext = new ApplicationDbContext();
                var entityType = typeof(Employee);
                var properties = entityType.GetProperties()
                    .Where(p => p.Name.ToLower() != "id") 
                    .ToDictionary(p => p.Name.ToLower(), p => p);
                var excelColumns = dataTable.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName.ToLower()).ToList();
                var entityColumns = properties.Keys.ToList();
                var missingColumns = entityColumns.Except(excelColumns).ToList();
                var extraColumns = excelColumns.Except(entityColumns).ToList();

                if (missingColumns.Any())
                {
                    MessageBox.Show($"Missing columns in Excel: {string.Join(", ", missingColumns)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (extraColumns.Any())
                {
                    MessageBox.Show($"Unexpected columns in Excel: {string.Join(", ", extraColumns)}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                List<Employee> employees = new List<Employee>();

                foreach (DataRow row in dataTable.Rows)
                {
                    var entity = new Employee();
                    foreach (var columnName in excelColumns)
                    {
                        if (properties.TryGetValue(columnName, out var property))
                        {
                            try
                            {
                                object value = Convert.ChangeType(row[columnName], property.PropertyType);
                                property.SetValue(entity, value);
                            }
                            catch
                            {
                                MessageBox.Show($"Data type mismatch in column '{columnName}'. Please check the file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    employees.Add(entity);
                }

                dbContext.Employees.AddRange(employees);
                dbContext.SaveChanges();
                MessageBox.Show("Employee data successfully exported to SQL!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void airButton3_Click(object sender, EventArgs e)
        {
            SaveToDatabase();
        }
    }
}
