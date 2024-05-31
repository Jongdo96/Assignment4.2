namespace Assignment4._2
{
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

            double counter = 0;
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (studentlist[i] != null)
                {
                    if (studentlist[i].GPA > counter)
                    {
                        counter = studentlist[i].GPA;
                    }
                }
                else
                {
                    MessageBox.Show("No students in the list");
                }
            }




        }

        internal static List<Student> studentlist = new List<Student>();
    }
}