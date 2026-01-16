using System.ComponentModel;

namespace CustomMessageBox
{
    public partial class Form1 : Form
    {
        //[System.ComponentModel.DesignerSerializationVisibilityAttribute(DesignerSerializationVisibilityAttribute.Hidden)]
        //public string Result { get; private set; }
        public Form1(string message, string but1, string but2, string but3)
        {
            InitializeComponent();
            MessageLabel.Text = message;
            button1.Text = but1;
            button2.Text = but2;
            button3.Text = but3;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
