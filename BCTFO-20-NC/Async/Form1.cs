namespace Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            long result = Sum(1000000000);
            MessageBox.Show($"Result = {result}");
        }

        private async void asycButton_Click(object sender, EventArgs e)
        {
            #region await Best Pattern
            long result = await Task.Run(() => Sum(1000000000));
            MessageBox.Show($"Result = {result}");
            #endregion


            #region Wait Anti Pattern

            //var task = Task.Run(() => Sum(10000000000));
            //task.Wait();

            //long result = task.Result;
            //MessageBox.Show($"Result = {result}");


            //var task = Task.Run(() => Sum(10000000000));
            //long result = task.GetAwaiter().GetResult();

            //MessageBox.Show($"Result = {result}");

            #endregion





            //Thread
            //Task
            //async await

        }

        private long Sum(long number)
        {
            long result = 0;

            for (int i = 0; i < number; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
