namespace count_machine
{
    class Count
    {
        private int value;

        public Count()
        {
            value = 0;
        }
        public void reset()
        {
            value = 0;
        }
        public void plus()
        {
            value++;
        }

        public void minus()
        {
            value--;
        }

        public int get()
        {
            return value;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}