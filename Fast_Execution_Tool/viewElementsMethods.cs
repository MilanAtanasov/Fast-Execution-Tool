using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Execution_Tool
{
    internal abstract class viewElementsMethods
    {
        public static void PopulateComboBoxProfiles(ComboBox comboBoxProfiles)
        {
            try
            {
                List<String> profiles = dataXML.GetInstance().getProfileNames();
                MessageBox.Show("Profiles: " + profiles.Count);
                foreach (String profile in profiles)
                {
                    String profileName = "";
                    // remove the sintax of XML
                    profileName = profile.Replace("<profilename>", "");
                    profileName = profileName.Replace("</profilename>", "");
                    profileName = profileName.Trim();
                    comboBoxProfiles.Items.Add(profileName);
                }

                if (comboBoxProfiles.Items.Count > 0)
                {
                    comboBoxProfiles.SelectedIndex = 0; // Optionally set the first item as selected
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine("Error while populating profiles: " + ex.Message);
            }
        }
    }
}
