using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Fast_Execution_Tool
{
    internal abstract class configFileMethods
    {
        public static void fileInitialization()
        {
            if (!configExists())
            {
                createConfig();
                addDefaultProfile();
            }
            else
            {
                if (!profileExists("Default"))
                {
                    addDefaultProfile();
                }
                else
                {
                    // Check if the default profile has any shortcuts
                    List<List<string>> configData = readConfigFile();
                    bool defaultProfileHasShortcuts = false;
                    foreach (var profile in configData)
                    {
                        if (profile[0].Equals("<profilename>Default</profilename>"))
                        {
                            if (profile.Count > 1)
                            {
                                defaultProfileHasShortcuts = true;
                                break;
                            }
                        }
                    }

                    if (!defaultProfileHasShortcuts)
                    {
                        // Add the default shortcuts
                        updateConfig("Default", "Notepad", "notepad.exe");
                        updateConfig("Default", "Calculator", "calc.exe");
                    }
                }   
            }
        }
        public static bool configExists()
        {
            return File.Exists("config.xml");
        }

        public static void createConfig()
        {
            // Creating an empty file with the root element
            File.WriteAllText("config.xml", "<root>\n</root>");
        }

        public static void addDefaultProfile()
        {
            // Read the existing XML data
            string xmlData = File.ReadAllText("config.xml");

            // Adding the default profile
            string defaultProfile = "<profile>\n\t<profilename>Default</profilename>\n</profile>";

            // Inserting the default profile before the closing root tag
            xmlData = xmlData.Replace("</root>", defaultProfile + "\n</root>");

            // Write all lines to the file
            File.WriteAllText("config.xml", xmlData);
        }

        public static void updateConfig(string profile, string shortcutName, string path)
        {
            if (configExists())
            {
                List<string> configData = File.ReadAllLines("config.xml").ToList();

                bool profileFound = false;
                int insertIndex = -1;

                for (int i = 0; i < configData.Count; i++)
                {
                    if (configData[i].Trim().Equals("<profile>"))
                    {
                        if (configData[i + 1].Trim().Equals("<profilename>" + profile + "</profilename>"))
                        {
                            profileFound = true;
                            insertIndex = i + 2;
                            break;
                        }
                    }
                }

                if (profileFound)
                {
                    for (int j = insertIndex; j < configData.Count; j++)
                    {
                        if (configData[j].Trim().Equals("<profile>"))
                        {
                            insertIndex = j;
                            break;
                        }
                    }

                    if (insertIndex == -1)
                    {
                        insertIndex = configData.Count - 1;
                    }
                }
                else
                {
                    insertIndex = configData.Count - 1;
                }

                // Insert the new shortcut
                string shortcutXML = "\n\t\t<shortcut>\n\t\t\t<name>" + shortcutName + "</name>\n\t\t\t<path>" + path + "</path>\n\t\t</shortcut>";
                configData.Insert(insertIndex, shortcutXML);

                // Write changes to file
                File.WriteAllLines("config.xml", configData.ToArray());
            }
            else
            {
                createConfig();
                addDefaultProfile();
                updateConfig(profile, shortcutName, path);
            }
        }

        public static List<string> getProfiles()
        {
            if (!configExists())
            {
                createConfig();
                addDefaultProfile();
            }

            List<string> profiles = new List<string>();
            List<List<string>> configData = readConfigFile();
            foreach (var profile in configData)
            {
                profiles.Add(profile[0]);
            }

            return profiles;
        }

        private static List<List<string>> readConfigFile()
        {
            List<List<string>> configData = new List<List<string>>();
            if (configExists())
            {
                string[] fileLines = File.ReadAllLines("config.xml");
                for (int i = 0; i < fileLines.Length; i++)
                {
                    if (fileLines[i].Trim().Equals("<profile>"))
                    {
                        List<string> profile = new List<string>();
                        i++;
                        profile.Add(fileLines[i].Trim());

                        i += 2; // Skipping the <profilename> and profile name line
                        while (!fileLines[i].Trim().Equals("</profile>"))
                        {
                            profile.Add(fileLines[i].Trim());
                            i++;
                        }
                        configData.Add(profile);
                    }
                }
            }
            return configData;
        }

        private static bool profileExists(string profile)
        {
            return getProfiles().Contains(profile);
        }

        private static void createProfile(string profile)
        {
            // This method seems to be unused and redundant given the current implementation
            // Consider removing it or implementing it properly if needed
        }
    }

    // This class is used to store the config data in memory

}
