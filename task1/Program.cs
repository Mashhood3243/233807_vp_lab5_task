namespace vp_lab7
{
    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
