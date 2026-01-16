using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms.PropertyGridInternal;
using TaskManager;
namespace TaskManagerUI
{
    public partial class Form1 : Form
    {
        Task_Manager manager;
        string filepath;
        public Form1()
        {
            manager = new Task_Manager();
            InitializeComponent();
            StatusComboBox1.DataSource = Enum.GetValues(typeof(Status));
            PriorityComboBox2.DataSource = Enum.GetValues(typeof(Priority));
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Welcome back do you want to load the old Tasks?","Load old tasks",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            var options = new JsonSerializerOptions {
                Converters = { new JsonStringEnumConverter() }, // Convert enums to strings
                WriteIndented = true,  // Makes the output formatted (pretty printed)
                 PropertyNameCaseInsensitive = true
            };
            if (result == DialogResult.Yes) {
                try {
                    string path = Properties.Settings.Default.LastFilePath;
                    string readFiles = File.ReadAllText(path);
                    var allTasks = JsonSerializer.Deserialize<Dictionary<Status, List<myTask>>>(readFiles, options);

                    manager.statusList[Status.todo] = allTasks[Status.todo];
                    manager.statusList[Status.inProgress] = allTasks[Status.inProgress];
                    manager.statusList[Status.completed] = allTasks[Status.completed];
                    RenewListbox(Status.todo);
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        private void Createbutton2_Click(object sender, EventArgs e)
        {
            manager.AddTask(new myTask(nameTextBox.Text, DescriptionTextBox.Text,
                dateTimePicker1.Value, (Status)StatusComboBox1.SelectedItem, (Priority)PriorityComboBox2.SelectedItem));
            RenewListbox((Status)StatusComboBox1.SelectedItem);
            nameTextBox.Clear();
            DescriptionTextBox.Clear();

        }

        private void UpDatebutton1_Click(object sender, EventArgs e)
        {

            manager.UpdateTask((myTask)listBox1.SelectedItem, nameTextBox.Text, DescriptionTextBox.Text, dateTimePicker1.Value, (Status)StatusComboBox1.SelectedItem, (Priority)PriorityComboBox2.SelectedItem);

        }
        //
        //
        // the listbox had to be reset to the datasource now that the data changed now just have to set the inprogress and completed
        // method to show up in the listbox and not the textbox   also add a delete button and    fileread and write
        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBox1.SelectedItem is myTask task) {
                nameTextBox.Text = task.Name;
                DescriptionTextBox.Text = task.Description;
                dateTimePicker1.Value = task.datetime;
                StatusComboBox1.SelectedItem = task.status;
                PriorityComboBox2.SelectedItem = task.priority;
            }
        }

        private void ToDobutton3_Click(object sender, EventArgs e)
        {
            //Print(Status.todo);
            RenewListbox(Status.todo);
        }


        private void InProgressbutton2_Click(object sender, EventArgs e)
        {
            //Print(Status.inProgress);
            RenewListbox(Status.inProgress);
        }

        private void Completedbutton1_Click(object sender, EventArgs e)
        {
            // Print(Status.completed);
            RenewListbox(Status.completed);
        }
        private void RenewListbox(Status status)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = manager.statusList[status];
            listBox1.Refresh();
        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"  Are you sure you want to delete this task: {(myTask)listBox1.SelectedItem}","Delete confirmatio",
             MessageBoxButtons.YesNoCancel   );
            if(result == DialogResult.Yes) {
                manager.RemoveTask((myTask)listBox1.SelectedItem);
                RenewListbox((Status)StatusComboBox1.SelectedItem);
            }
            
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save your task file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    filepath = saveFileDialog.FileName; // This gives you the selected file path
                    Properties.Settings.Default.LastFilePath = filepath;
                    Properties.Settings.Default.Save();
                    SaveMethod(filepath); // Your SaveTasks method
                }
            }
        }
       
        private void SaveMethod(string otherfilepath)
        {
            var options = new JsonSerializerOptions {
                Converters = { new JsonStringEnumConverter() }, // Convert enums to strings
                WriteIndented = true // Makes the output formatted (pretty printed)
            };
            try {
                var json = JsonSerializer.Serialize(manager.statusList,options);
                if(!string.IsNullOrEmpty(filepath) && File.Exists(filepath)){
                    File.WriteAllText(filepath, json);
                }
                else {
                    File.WriteAllText(otherfilepath, json);
                }
                MessageBox.Show($"Great its all saved!");
            }
            catch (Exception ex) {
                MessageBox.Show($" something's nor right   Error#:{ex.Message}" );
            }
}
        // old    [Deprecated]
        //[Obsolete]
        //private void Print(Status status)
        //{
        //    if (manager.statusList[status].Count != 0)
        //        TaskDisplayBox.AppendText($"       ----        -----   {status} List   -----    ---\n");

        //    foreach (var task in manager.statusList[status]) {
        //        TaskDisplayBox.AppendText($"  --  {task.ToString()}\n");
        //    }
        //}
    }
}
