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

                    while (!parser.EndOfData)
                    {
                        // Read fields from the current line
                        string[] fields = parser.ReadFields();

                        // Assuming the CSV structure is: Name,Street,Number1,Number2,Postcode,Quality
                        if (fields.Length >= 4)
                        {
                            Hotel hotel = new Hotel
                            {
                                Name = fields[0],
                                Street = fields[1],
                                Number1 = fields[2],
                                Number2 = fields[3],
                                Postcode = fields[4],
                                Quality = int.Parse(fields[5])
                            };

                            HotelDAO hotelDAO = new HotelDAO();
                            hotelDAO.Save(hotel);
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
            /*Hotel hotel = new Hotel();
            hotel.GetAllDB();*/
        }
    }
}
