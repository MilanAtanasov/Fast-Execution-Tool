using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Execution_Tool
{
    internal sealed class dataXML
    {
        private static dataXML instance = new dataXML();
        private List<shortcutsProfile> shortcutsProfiles = new List<shortcutsProfile>();

        private dataXML() { }

        public static dataXML Instance
        {
            get
            {
                return instance;
            }
        }

        public static dataXML GetInstance()
        {
               return instance;
        }

        public List<shortcutsProfile> getShortcutsProfiles()
        {
               return shortcutsProfiles;
        }

        public void addShortcutsProfile(shortcutsProfile shortcutsProfile)
        {
               shortcutsProfiles.Add(shortcutsProfile);
        }

        public void removeShortcutsProfile(shortcutsProfile shortcutsProfile)
        {
               shortcutsProfiles.Remove(shortcutsProfile);
        }

        public void removeShortcutsProfile(int index)
        {
               shortcutsProfiles.RemoveAt(index);
        }

        public void setShortcutsProfiles(List<shortcutsProfile> shortcutsProfiles)
        {
               this.shortcutsProfiles = shortcutsProfiles;
        }

        public List<String> getProfileNames()
        {
            List<String> profileNames = new List<String>();
            foreach (shortcutsProfile shortcutsProfile in shortcutsProfiles)
            {
                profileNames.Add(shortcutsProfile.getProfileName());
            }            
            return profileNames;
        }

        public void initializeObject()
        {
            // read from XML file
            // create shortcutsProfile objects
            // add to shortcutsProfiles

            dataXML dataXML = new dataXML();
            String dataStream = configFileMethods.readConfigFile();

        }

        public void addShortcut(String shortcutName, String shortcutPath, String profile)
        {
            // add shortcut to the profile object with the name and path

        }
        

    }
}
