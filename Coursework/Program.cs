namespace Coursework
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var mainForm = new MainForm();
            mainForm.Show();
            Application.Run();
        }
    }
}