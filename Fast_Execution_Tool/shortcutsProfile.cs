using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Execution_Tool
{
    internal class shortcutsProfile
    {
        private String profileName;
        private List<shortcut> shortcuts;
        public shortcutsProfile() { }

        // create a profile from a string of XML
        public shortcutsProfile(String dataStream)
        {
            shortcuts = new List<shortcut>();
            String[] dataStreamSplit = dataStream.Split('\n');
            foreach (String data in dataStreamSplit)
            {
                if (data.Contains("<profilename>"))
                {
                    profileName = data.Replace("<profilename>", "");
                    profileName = profileName.Replace("</profilename>", "");
                    profileName = profileName.Trim();
                }
                else if (data.Contains("<shortcut>"))
                {
                    shortcut shortcut = new shortcut();
                    for (int i = 0; i < 3; i++)
                    {
                        dataStreamSplit = dataStream.Split('\n');
                        String dataShortcut = dataStreamSplit[i];
                        if (dataShortcut.Contains("<name>"))
                        {
                            shortcut.setName(dataShortcut.Replace("<name>", ""));
                            shortcut.setName(shortcut.getName().Replace("</name>", ""));
                            shortcut.setName(shortcut.getName().Trim());
                        }
                        else if (dataShortcut.Contains("<path>"))
                        {
                            shortcut.setPath(dataShortcut.Replace("<path>", ""));
                            shortcut.setPath(shortcut.getPath().Replace("</path>", ""));
                            shortcut.setPath(shortcut.getPath().Trim());
                        }
                        else if (dataShortcut.Contains("<type>"))
                        {
                            shortcut.setType(dataShortcut.Replace("<type>", ""));
                            shortcut.setType(shortcut.getType().Replace("</type>", ""));
                            shortcut.setType(shortcut.getType().Trim());
                        }
                    }
                    shortcuts.Add(shortcut);
                }
            }
        }

        public String getProfileName()
        {
            return profileName;
        }

        public List<shortcut> getShortcuts()
        {
               return shortcuts;
        }

        // add a shortcut to the list, if input is a shortcut
        public void addShortcut(shortcut shortcut)
        {
            shortcuts.Add(shortcut);
        }

        public void addShortcut(String name, String path, String type)
        {
            shortcuts.Add(new shortcut(name, path, type));
        }

        // parse the profile as a string of XML
        public String getProfileAsXMLString()
        {
            String profile = "<profilename>" + profileName + "</profilename>\n";
            foreach (shortcut shortcut in shortcuts)
            {
                profile += "<shortcut>\n";
                profile += "<name>" + shortcut.getName() + "</name>\n";
                profile += "<path>" + shortcut.getPath() + "</path>\n";
                profile += "<type>" + shortcut.getType() + "</type>\n";
                profile += "</shortcut>\n";
            }
            String profileWrapper = "<profile>\n" + profile + "</profile>\n";
            return profileWrapper;
        }   

    }
}
