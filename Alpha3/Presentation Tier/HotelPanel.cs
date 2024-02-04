using Alpha3.Bussiness_Tier;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Presentation_Tier
{
    public partial class HotelPanel : UserControl
    {
        public HotelPanel()
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
                this.HotelPanel_Load(sender, e);
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
                            if (fields.Length >= 6)
                            {
                                Hotel hotel = new Hotel();
                                hotel.Name = fields[0];
                                hotel.Street = fields[1];
                                hotel.Number1 = int.Parse(fields[2]);
                                hotel.Postcode = fields[4];
                                hotel.Quality = int.Parse(fields[5]);
                                int number2; // Declare a variable to store the parsed integer
                                if (int.TryParse(fields[3], out number2))
                                {
                                    hotel.Number2 = number2;
                                }
                                else
                                {
                                    hotel.Number2 = 0;
                                }
                                hotel.AddToDB();
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

                MessageBox.Show("Imported successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during import: " + ex.Message);
            }
        }

        private void HotelPanel_Load(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.GetAllDB(this.dataGridView1);
        }
    }
}
