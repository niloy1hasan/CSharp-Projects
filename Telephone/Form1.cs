using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Telephone
{
    public partial class Phone : Form
    {
        private const string FilePath = "contacts.txt";

        public Phone()
        {
            InitializeComponent();
            this.buttonClear.Click += new EventHandler(this.ClearFields);
            InitializeGrid();
            LoadFromFile();
        }

        private void InitializeGrid()
        {
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn serialColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Serial",
                Name = "Serial",
                Width = 50,
                ReadOnly = true
            };
            dataGridView1.Columns.Add(serialColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Name = "Name",
                Width = 150
            };
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn mobileColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mobile",
                Name = "Mobile",
                Width = 100
            };
            dataGridView1.Columns.Add(mobileColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                Name = "Email",
                Width = 200
            };
            dataGridView1.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                Name = "Category",
                Width = 100
            };
            dataGridView1.Columns.Add(categoryColumn);
        }

        private void LoadFromFile()
        {
            if (!File.Exists(FilePath))
            {
                return;
            }

            try
            {
                dataGridView1.Rows.Clear();
                var lines = File.ReadAllLines(FilePath);
                int serial = 1;

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        dataGridView1.Rows.Add(serial++, parts[0], parts[1], parts[2], parts[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string data = $"{row.Cells["Name"].Value},{row.Cells["Mobile"].Value},{row.Cells["Email"].Value},{row.Cells["Category"].Value}";
                            writer.WriteLine(data);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        private string FormatName(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        private bool IsValidMobile(string mobile)
        {
            return Regex.IsMatch(mobile, @"^\d+$");
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim() + " " + textBox2.Text.Trim();
            string mobile = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string category = comboBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(mobile))
            {
                MessageBox.Show("Name and Mobile fields are required!");
                return;
            }

            if (!IsValidName(name))
            {
                MessageBox.Show("Name must only contain alphabetic characters.");
                return;
            }

            if (!IsValidMobile(mobile))
            {
                MessageBox.Show("Mobile must only contain digits.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            name = FormatName(name);
            int serial = dataGridView1.Rows.Count + 1;

            dataGridView1.Rows.Add(serial, name, mobile, email, category);
            SaveToFile();
            ClearFields();
            MessageBox.Show("Contact added successfully!");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string name = textBox1.Text.Trim() + " " + textBox2.Text.Trim();
                string mobile = textBox3.Text.Trim();
                string email = textBox4.Text.Trim();
                string category = comboBox1.Text.Trim();

                if (!IsValidName(name))
                {
                    MessageBox.Show("Name must only contain alphabetic characters.");
                    return;
                }

                if (!IsValidMobile(mobile))
                {
                    MessageBox.Show("Mobile must only contain digits.");
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email format.");
                    return;
                }

                name = FormatName(name);

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Name"].Value = name;
                selectedRow.Cells["Mobile"].Value = mobile;
                selectedRow.Cells["Email"].Value = email;
                selectedRow.Cells["Category"].Value = category;

                SaveToFile();
                ClearFields();
                MessageBox.Show("Contact updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a contact to update.");
            }

            ClearFields();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                SaveToFile();
                MessageBox.Show("Contact deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.");
            }

            ClearFields();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string[] namestring = row.Cells["Name"].Value.ToString().Split(' ');
                textBox1.Text = namestring[0];
                textBox2.Text = namestring[1];
                textBox3.Text = row.Cells["Mobile"].Value.ToString();
                textBox4.Text = row.Cells["Email"].Value.ToString();
                comboBox1.Text = row.Cells["Category"].Value.ToString();
            }
        }
    }
}
