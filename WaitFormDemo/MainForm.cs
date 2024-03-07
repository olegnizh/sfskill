namespace WaitFormDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnLongTask_Click(object sender, EventArgs e)
        {
            WaitForm waitForm = new();
            waitForm.Shown += async (s, e) =>
            {
                //you need to declare LblMessage as public to access it here
                //View WaitForm.cs for code
                waitForm.LblMessages.Text = "Building Database";
                //Your long waiting task 1
                await Task.Delay(5000);
                waitForm.LblMessages.Text = "Clearing Old Data...";
                //Your long waiting task 2
                await Task.Delay(5000);
                waitForm.LblMessages.Text = "Process Completed . . . . Closing";
                await Task.Delay(2000);
                waitForm.Close();
            };
            waitForm.ShowDialog();
        }
    }
}