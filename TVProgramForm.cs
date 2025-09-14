using TVProgramApp.Helpers;
using TVProgramApp.Models;
using TVProgramApp.Services;
using System.Data;

namespace TVProgramApp
{
    public partial class TVProgramForm : Form
    {
        private readonly DataTable _table = new("table");
        private readonly ScheduleService _schedule = new();
        private string _dayOfWeek;
        public TVProgramForm()
        {
            InitializeComponent();
        }
        private void TVProgramForm_Load(object sender, EventArgs e)
        {
            dataGridTVShow.DataSource = _table;
            SetupColumns();
            dataGridTVShow.Columns["Program Time"].FillWeight = 30;
            dataGridTVShow.Columns["Program Name"].FillWeight = 70;
            _schedule.DeserializeFromJson("schedule.json");
            _dayOfWeek = DayOfWeekHelper.GetDefaultDayOfWeek();
            RefreshGrid();
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button b && b.Tag?.ToString() == "DayButton")
                {
                    b.BackColor = b.Text == _dayOfWeek
                            ? Color.Lavender
                            : SystemColors.Control;
                }
            }
        }
        private void SetupColumns()
        {
            _table.Columns.Add("Program Time", typeof(string));
            _table.Columns.Add("Program Name", typeof(string));
        }
        private bool IsValidTimeFormat(string text) =>
            TimeSpan.TryParseExact(text, "hh\\:mm", null, out _);
        private void RefreshGrid(List<TvProgram>? programs = null)
        {
            _table.Rows.Clear();
            var data = programs ?? _schedule.GetDaySchedule(_dayOfWeek);
            foreach (var program in data)
                _table.Rows.Add(program.Time, program.Name);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string time = programTimeTextBox.Text;
            string name = programNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(time) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsValidTimeFormat(time))
            {
                MessageBox.Show("Invalid time format (HH:mm)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_schedule.IsTimeUnique(_dayOfWeek, time))
            {
                MessageBox.Show("This time is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var program = new TvProgram { Time = time, Name = name };
            _schedule.AddProgram(_dayOfWeek, time, program);
            RefreshGrid();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridTVShow.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select a row to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newTime = programTimeTextBox.Text;
            string newName = programNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(newTime) || string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidTimeFormat(newTime))
            {
                MessageBox.Show("Invalid time format (HH:mm)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var row = dataGridTVShow.SelectedRows[0];
            string oldTime = row.Cells[0].Value.ToString();
            if (!_schedule.IsTimeUnique(_dayOfWeek, newTime) && newTime != oldTime)
            {
                MessageBox.Show("This time is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _schedule.RemoveProgram(_dayOfWeek, oldTime);
            _schedule.AddProgram(_dayOfWeek, newTime, new TvProgram { Time = newTime, Name = newName });
            RefreshGrid();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridTVShow.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select a row to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string time = dataGridTVShow.SelectedRows[0].Cells[0].Value.ToString();
            _schedule.RemoveProgram(_dayOfWeek, time);
            RefreshGrid();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            programTimeTextBox.Clear();
            programNameTextBox.Clear();
        }
        private void TimeSearchButton_Click(object sender, EventArgs e)
        {
            string timeSearch = programTimeTextBox.Text;

            if (!IsValidTimeFormat(timeSearch))
            {
                MessageBox.Show("Invalid time format (HH:mm)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var results = _schedule.FindByTime(_dayOfWeek, timeSearch);

            if (results.Count == 0)
            {
                RefreshGrid();
                MessageBox.Show("Program not found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RefreshGrid(results);
        }
        private void NameSearchButton_Click(object sender, EventArgs e)
        {
            string nameSearch = programNameTextBox.Text;
            var results = _schedule.FindByName(_dayOfWeek, nameSearch);

            if (results.Count == 0)
            {
                RefreshGrid();
                MessageBox.Show("Program not found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RefreshGrid(results);
        }
        private void ResetButton_Click(object sender, EventArgs e) => RefreshGrid();
        private void dataGridTVShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridTVShow.Rows[e.RowIndex];
            programTimeTextBox.Text = row.Cells[0].Value.ToString();
            programNameTextBox.Text = row.Cells[1].Value.ToString();
        }
        private void DayButton_Click(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                _dayOfWeek = button.Text;
                RefreshGrid();
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is Button b && b.Tag?.ToString() == "DayButton")
                    {
                        b.BackColor = b == button
                            ? Color.Lavender
                            : SystemColors.Control;
                    }
                }
            }
        }
        private void TVProgramForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _schedule.SerializeToJson("schedule.json");
        }
    }
}