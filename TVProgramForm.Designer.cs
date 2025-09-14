namespace TVProgramApp
{
    partial class TVProgramForm
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridTVShow = new DataGridView();
            AddButton = new Button();
            ClearButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            programNameTextBox = new TextBox();
            programTimeTextBox = new TextBox();
            TVProgramLabel = new Label();
            TimeSearchButton = new Button();
            NameSearchButton = new Button();
            ResetButton = new Button();
            MondayButton = new Button();
            TuesdayButton = new Button();
            WednesdayButton = new Button();
            ThursdayButton = new Button();
            FridayButton = new Button();
            SaturdayButton = new Button();
            SundayButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTVShow).BeginInit();
            SuspendLayout();
            // 
            // dataGridTVShow
            // 
            dataGridTVShow.AllowUserToAddRows = false;
            dataGridTVShow.AllowUserToDeleteRows = false;
            dataGridTVShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTVShow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTVShow.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridTVShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTVShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(16, 44, 87);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridTVShow.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridTVShow.Location = new Point(121, 165);
            dataGridTVShow.MultiSelect = false;
            dataGridTVShow.Name = "dataGridTVShow";
            dataGridTVShow.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridTVShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridTVShow.RowHeadersWidth = 82;
            dataGridTVShow.Size = new Size(1156, 500);
            dataGridTVShow.TabIndex = 0;
            dataGridTVShow.CellClick += dataGridTVShow_CellClick;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.White;
            AddButton.FlatAppearance.BorderColor = Color.Black;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 18F);
            AddButton.Location = new Point(306, 684);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(240, 41);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.White;
            ClearButton.FlatAppearance.BorderColor = Color.Black;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI", 18F);
            ClearButton.Location = new Point(551, 739);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(240, 41);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear Fields";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.White;
            EditButton.FlatAppearance.BorderColor = Color.Black;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI", 18F);
            EditButton.Location = new Point(551, 684);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(240, 41);
            EditButton.TabIndex = 3;
            EditButton.Text = "Update";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.FlatAppearance.BorderColor = Color.Black;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 18F);
            DeleteButton.Location = new Point(796, 684);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(240, 41);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // programNameTextBox
            // 
            programNameTextBox.BackColor = Color.White;
            programNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            programNameTextBox.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programNameTextBox.Location = new Point(125, 740);
            programNameTextBox.Margin = new Padding(5);
            programNameTextBox.Name = "programNameTextBox";
            programNameTextBox.PlaceholderText = "Program Name";
            programNameTextBox.Size = new Size(421, 47);
            programNameTextBox.TabIndex = 7;
            // 
            // programTimeTextBox
            // 
            programTimeTextBox.BackColor = Color.White;
            programTimeTextBox.BorderStyle = BorderStyle.FixedSingle;
            programTimeTextBox.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programTimeTextBox.Location = new Point(125, 684);
            programTimeTextBox.Name = "programTimeTextBox";
            programTimeTextBox.PlaceholderText = "12:00";
            programTimeTextBox.Size = new Size(175, 47);
            programTimeTextBox.TabIndex = 8;
            // 
            // TVProgramLabel
            // 
            TVProgramLabel.AutoSize = true;
            TVProgramLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TVProgramLabel.Location = new Point(583, 36);
            TVProgramLabel.Name = "TVProgramLabel";
            TVProgramLabel.Size = new Size(172, 37);
            TVProgramLabel.TabIndex = 11;
            TVProgramLabel.Text = "TV Program";
            // 
            // TimeSearchButton
            // 
            TimeSearchButton.BackColor = Color.White;
            TimeSearchButton.FlatAppearance.BorderColor = Color.Black;
            TimeSearchButton.FlatStyle = FlatStyle.Flat;
            TimeSearchButton.Font = new Font("Segoe UI", 18F);
            TimeSearchButton.Location = new Point(1041, 684);
            TimeSearchButton.Name = "TimeSearchButton";
            TimeSearchButton.Size = new Size(240, 41);
            TimeSearchButton.TabIndex = 14;
            TimeSearchButton.Text = "Find by Time";
            TimeSearchButton.UseVisualStyleBackColor = false;
            TimeSearchButton.Click += TimeSearchButton_Click;
            // 
            // NameSearchButton
            // 
            NameSearchButton.BackColor = Color.White;
            NameSearchButton.FlatAppearance.BorderColor = Color.Black;
            NameSearchButton.FlatStyle = FlatStyle.Flat;
            NameSearchButton.Font = new Font("Segoe UI", 18F);
            NameSearchButton.Location = new Point(1041, 739);
            NameSearchButton.Name = "NameSearchButton";
            NameSearchButton.Size = new Size(240, 41);
            NameSearchButton.TabIndex = 15;
            NameSearchButton.Text = "Find by Name";
            NameSearchButton.UseVisualStyleBackColor = false;
            NameSearchButton.Click += NameSearchButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.White;
            ResetButton.FlatAppearance.BorderColor = Color.Black;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Font = new Font("Segoe UI", 18F);
            ResetButton.Location = new Point(796, 739);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(240, 41);
            ResetButton.TabIndex = 17;
            ResetButton.Text = "Reset search";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // MondayButton
            // 
            MondayButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            MondayButton.Location = new Point(121, 88);
            MondayButton.Name = "MondayButton";
            MondayButton.Size = new Size(160, 60);
            MondayButton.TabIndex = 18;
            MondayButton.Tag = "DayButton";
            MondayButton.Text = "Monday";
            MondayButton.UseVisualStyleBackColor = true;
            MondayButton.Click += DayButton_Click;
            // 
            // TuesdayButton
            // 
            TuesdayButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TuesdayButton.Location = new Point(287, 88);
            TuesdayButton.Name = "TuesdayButton";
            TuesdayButton.Size = new Size(160, 60);
            TuesdayButton.TabIndex = 19;
            TuesdayButton.Tag = "DayButton";
            TuesdayButton.Text = "Tuesday";
            TuesdayButton.UseVisualStyleBackColor = true;
            TuesdayButton.Click += DayButton_Click;
            // 
            // WednesdayButton
            // 
            WednesdayButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            WednesdayButton.Location = new Point(453, 88);
            WednesdayButton.Name = "WednesdayButton";
            WednesdayButton.Size = new Size(160, 60);
            WednesdayButton.TabIndex = 20;
            WednesdayButton.Tag = "DayButton";
            WednesdayButton.Text = "Wednesday";
            WednesdayButton.UseVisualStyleBackColor = true;
            WednesdayButton.Click += DayButton_Click;
            // 
            // ThursdayButton
            // 
            ThursdayButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ThursdayButton.Location = new Point(619, 88);
            ThursdayButton.Name = "ThursdayButton";
            ThursdayButton.Size = new Size(160, 60);
            ThursdayButton.TabIndex = 21;
            ThursdayButton.Tag = "DayButton";
            ThursdayButton.Text = "Thursday";
            ThursdayButton.UseVisualStyleBackColor = true;
            ThursdayButton.Click += DayButton_Click;
            // 
            // FridayButton
            // 
            FridayButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FridayButton.Location = new Point(785, 88);
            FridayButton.Name = "FridayButton";
            FridayButton.Size = new Size(160, 60);
            FridayButton.TabIndex = 22;
            FridayButton.Tag = "DayButton";
            FridayButton.Text = "Friday";
            FridayButton.UseVisualStyleBackColor = true;
            FridayButton.Click += DayButton_Click;
            // 
            // SaturdayButton
            // 
            SaturdayButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            SaturdayButton.Location = new Point(951, 88);
            SaturdayButton.Name = "SaturdayButton";
            SaturdayButton.Size = new Size(160, 60);
            SaturdayButton.TabIndex = 23;
            SaturdayButton.Tag = "DayButton";
            SaturdayButton.Text = "Saturday";
            SaturdayButton.UseVisualStyleBackColor = true;
            SaturdayButton.Click += DayButton_Click;
            // 
            // SundayButton
            // 
            SundayButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            SundayButton.Location = new Point(1117, 88);
            SundayButton.Name = "SundayButton";
            SundayButton.Size = new Size(160, 60);
            SundayButton.TabIndex = 24;
            SundayButton.Tag = "DayButton";
            SundayButton.Text = "Sunday";
            SundayButton.UseVisualStyleBackColor = true;
            SundayButton.Click += DayButton_Click;
            // 
            // TVProgramForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1424, 861);
            Controls.Add(SundayButton);
            Controls.Add(SaturdayButton);
            Controls.Add(FridayButton);
            Controls.Add(ThursdayButton);
            Controls.Add(WednesdayButton);
            Controls.Add(TuesdayButton);
            Controls.Add(MondayButton);
            Controls.Add(ResetButton);
            Controls.Add(NameSearchButton);
            Controls.Add(TimeSearchButton);
            Controls.Add(TVProgramLabel);
            Controls.Add(programTimeTextBox);
            Controls.Add(programNameTextBox);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(ClearButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridTVShow);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(16, 44, 87);
            Name = "TVProgramForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TV Program";
            FormClosing += TVProgramForm_FormClosing;
            Load += TVProgramForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTVShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridTVShow;
        private Button AddButton;
        private Button ClearButton;
        private Button EditButton;
        private Button DeleteButton;
        private TextBox programNameTextBox;
        private TextBox programTimeTextBox;
        private Label TVProgramLabel;
        private ToolStrip dayStrip;
        // Replace ToolStripButton declarations with Button for day buttons
        private Button MondayButton;
        private Button TuesdayButton;
        private Button WednesdayButton;
        private Button ThursdayButton;
        private Button FridayButton;
        private Button SaturdayButton;
        private Button SundayButton;
        private Button TimeSearchButton;
        private Button NameSearchButton;
        private Button ResetButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
