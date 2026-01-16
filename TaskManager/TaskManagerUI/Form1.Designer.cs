namespace TaskManagerUI
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
            if (disposing && (components != null)) {
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
            components = new System.ComponentModel.Container();
            UpDatebutton1 = new Button();
            Createbutton2 = new Button();
            nameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            notifyIcon1 = new NotifyIcon(components);
            TaskNameLabel1 = new Label();
            Descritionlabel2 = new Label();
            StatusComboBox1 = new ComboBox();
            PriorityComboBox2 = new ComboBox();
            Statuslabel3 = new Label();
            DateTimelabel4 = new Label();
            Prioritylabel5 = new Label();
            Completedbutton1 = new Button();
            InProgressbutton2 = new Button();
            ToDobutton3 = new Button();
            listBox1 = new ListBox();
            Deletebutton1 = new Button();
            Savebutton1 = new Button();
            SuspendLayout();
            // 
            // UpDatebutton1
            // 
            UpDatebutton1.Location = new Point(623, 259);
            UpDatebutton1.Name = "UpDatebutton1";
            UpDatebutton1.Size = new Size(75, 23);
            UpDatebutton1.TabIndex = 1;
            UpDatebutton1.Text = "Update";
            UpDatebutton1.UseVisualStyleBackColor = true;
            UpDatebutton1.Click += UpDatebutton1_Click;
            // 
            // Createbutton2
            // 
            Createbutton2.Location = new Point(542, 259);
            Createbutton2.Name = "Createbutton2";
            Createbutton2.Size = new Size(75, 23);
            Createbutton2.TabIndex = 2;
            Createbutton2.Text = "Create";
            Createbutton2.UseVisualStyleBackColor = true;
            Createbutton2.Click += Createbutton2_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(618, 74);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(148, 23);
            nameTextBox.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(618, 103);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(148, 23);
            DescriptionTextBox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(587, 141);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // TaskNameLabel1
            // 
            TaskNameLabel1.AutoSize = true;
            TaskNameLabel1.Location = new Point(542, 77);
            TaskNameLabel1.Name = "TaskNameLabel1";
            TaskNameLabel1.Size = new Size(39, 15);
            TaskNameLabel1.TabIndex = 6;
            TaskNameLabel1.Text = "Name";
            // 
            // Descritionlabel2
            // 
            Descritionlabel2.AutoSize = true;
            Descritionlabel2.Location = new Point(526, 111);
            Descritionlabel2.Name = "Descritionlabel2";
            Descritionlabel2.Size = new Size(67, 15);
            Descritionlabel2.TabIndex = 7;
            Descritionlabel2.Text = "Description";
            // 
            // StatusComboBox1
            // 
            StatusComboBox1.FormattingEnabled = true;
            StatusComboBox1.Location = new Point(618, 182);
            StatusComboBox1.Name = "StatusComboBox1";
            StatusComboBox1.Size = new Size(121, 23);
            StatusComboBox1.TabIndex = 9;
            // 
            // PriorityComboBox2
            // 
            PriorityComboBox2.FormattingEnabled = true;
            PriorityComboBox2.Location = new Point(618, 216);
            PriorityComboBox2.Name = "PriorityComboBox2";
            PriorityComboBox2.Size = new Size(121, 23);
            PriorityComboBox2.TabIndex = 10;
            // 
            // Statuslabel3
            // 
            Statuslabel3.AutoSize = true;
            Statuslabel3.Location = new Point(542, 190);
            Statuslabel3.Name = "Statuslabel3";
            Statuslabel3.Size = new Size(39, 15);
            Statuslabel3.TabIndex = 11;
            Statuslabel3.Text = "Status";
            // 
            // DateTimelabel4
            // 
            DateTimelabel4.AutoSize = true;
            DateTimelabel4.Location = new Point(526, 147);
            DateTimelabel4.Name = "DateTimelabel4";
            DateTimelabel4.Size = new Size(55, 15);
            DateTimelabel4.TabIndex = 12;
            DateTimelabel4.Text = "Date Due";
            // 
            // Prioritylabel5
            // 
            Prioritylabel5.AutoSize = true;
            Prioritylabel5.Location = new Point(542, 224);
            Prioritylabel5.Name = "Prioritylabel5";
            Prioritylabel5.Size = new Size(45, 15);
            Prioritylabel5.TabIndex = 13;
            Prioritylabel5.Text = "Priority";
            // 
            // Completedbutton1
            // 
            Completedbutton1.Location = new Point(316, 23);
            Completedbutton1.Name = "Completedbutton1";
            Completedbutton1.Size = new Size(75, 23);
            Completedbutton1.TabIndex = 14;
            Completedbutton1.Text = "Completed";
            Completedbutton1.UseVisualStyleBackColor = true;
            Completedbutton1.Click += Completedbutton1_Click;
            // 
            // InProgressbutton2
            // 
            InProgressbutton2.Location = new Point(198, 23);
            InProgressbutton2.Name = "InProgressbutton2";
            InProgressbutton2.Size = new Size(75, 23);
            InProgressbutton2.TabIndex = 15;
            InProgressbutton2.Text = "InProgress";
            InProgressbutton2.UseVisualStyleBackColor = true;
            InProgressbutton2.Click += InProgressbutton2_Click;
            // 
            // ToDobutton3
            // 
            ToDobutton3.Location = new Point(59, 23);
            ToDobutton3.Name = "ToDobutton3";
            ToDobutton3.Size = new Size(75, 23);
            ToDobutton3.TabIndex = 16;
            ToDobutton3.Text = "ToDo";
            ToDobutton3.UseVisualStyleBackColor = true;
            ToDobutton3.Click += ToDobutton3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(50, 77);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(370, 304);
            listBox1.TabIndex = 17;
            // 
            // Deletebutton1
            // 
            Deletebutton1.Location = new Point(704, 259);
            Deletebutton1.Name = "Deletebutton1";
            Deletebutton1.Size = new Size(75, 23);
            Deletebutton1.TabIndex = 18;
            Deletebutton1.Text = "Delete";
            Deletebutton1.UseVisualStyleBackColor = true;
            Deletebutton1.Click += Deletebutton1_Click;
            // 
            // Savebutton1
            // 
            Savebutton1.Location = new Point(599, 339);
            Savebutton1.Name = "Savebutton1";
            Savebutton1.Size = new Size(114, 42);
            Savebutton1.TabIndex = 19;
            Savebutton1.Text = "Save";
            Savebutton1.UseVisualStyleBackColor = true;
            Savebutton1.Click += Savebutton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Savebutton1);
            Controls.Add(Deletebutton1);
            Controls.Add(listBox1);
            Controls.Add(ToDobutton3);
            Controls.Add(InProgressbutton2);
            Controls.Add(Completedbutton1);
            Controls.Add(Prioritylabel5);
            Controls.Add(DateTimelabel4);
            Controls.Add(Statuslabel3);
            Controls.Add(PriorityComboBox2);
            Controls.Add(StatusComboBox1);
            Controls.Add(Descritionlabel2);
            Controls.Add(TaskNameLabel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(DescriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(Createbutton2);
            Controls.Add(UpDatebutton1);
            Name = "Form1";
            Text = "Task Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button UpDatebutton1;
        private Button Createbutton2;
        private TextBox nameTextBox;
        private TextBox DescriptionTextBox;
        private DateTimePicker dateTimePicker1;
        private NotifyIcon notifyIcon1;
        private Label TaskNameLabel1;
        private Label Descritionlabel2;
        private ComboBox StatusComboBox1;
        private ComboBox PriorityComboBox2;
        private Label Statuslabel3;
        private Label DateTimelabel4;
        private Label Prioritylabel5;
        private Button Completedbutton1;
        private Button InProgressbutton2;
        private Button ToDobutton3;
        private ListBox listBox1;
        private Button Deletebutton1;
        private Button Savebutton1;
    }
}
