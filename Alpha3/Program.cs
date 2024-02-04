using Alpha3.Data_Tier;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateDatabase.CreateDatabaseQuery("../../Data Tier/SQLQuery.sql");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IntroForm());

        }

        public static int GetNumberOfColumns(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string headerLine = reader.ReadLine();

                    if (headerLine != null)
                    {
                        string[] columns = headerLine.Split(',');

                        return columns.Length;
                    }

                    // Return 0 if the header line is not found or is empty
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return -1; // Return -1 to indicate an error
            }
        }
    }
}
