using Alpha3.Bussiness_Tier;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Presentation_Tier
{
    public partial class CityPanel : UserControl
    {
        public CityPanel()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.ShowDialog();

            string file = browseFile.FileName;
            if (file != null)
            {
                ImportFromCsv(file);
                this.CityPanel_Load(sender, e);
            }
        }

        private void ImportFromCsv(string file)
        {
            try
            {
                using (var parser = new TextFieldParser(file))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    int lineNumber = 0; // Track the line number for error reporting

                    while (!parser.EndOfData)
                    {
                        lineNumber++;

                        // Read fields from the current line
                        string[] fields = parser.ReadFields();
                        // Skip the first line (headers)
                        if (lineNumber == 1)
                        {
                            continue;
                        }
                        try
                        {
                            if (fields.Length >= Program.GetNumberOfColumns(file))
                            {
                                City city = new City();
                                city.Name = fields[0];
                                city.Abbreviation= fields[1];
                                city.AddToDB();
                            }
                            else
                            {
                                MessageBox.Show($"Error on line {lineNumber}: Insufficient fields in CSV.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error on line {lineNumber}: {ex.Message}");
                        }
                    }
                }

                MessageBox.Show("Imported City successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during import: " + ex.Message);
            }
        }

        public void CityPanel_Load(object sender, EventArgs e)
        {
            City city= new City();

            city.GetAllDB(this.dataGridView1);
        }
    }
}
