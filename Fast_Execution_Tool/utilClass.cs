using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Execution_Tool
{
    internal abstract class utilClass
    {
        public static Boolean configExists()
        {
            return System.IO.File.Exists("config.xml");
        }

        public static void createConfig()
        {
            System.IO.File.Create("config.xml");
        }

        public static void updateConfig(String profile, String shortcutName, String path)
        {
            if(configExists())
            {
                // Read the config file
                List<String> configData = System.IO.File.ReadAllLines("config.xml").ToList();
                // Loop through the config file
                for (int i = 0; i < configData.Count; i++)
                {
                    // Check if the line is a profile
                    if (configData[i].Contains("<profile>"))
                    {
                        // Check if the profile is the one we are looking for
                        if (configData[i + 1].Equals(profile))
                        {
                            // Loop through the config file
                            for (int j = i + 2; j < configData.Count; j++)
                            {
                                // Check if the line is a profile
                                if (configData[j].Contains("<profile>"))
                                {
                                    // Add the shortcut to the configData
                                    configData.Insert(j, "<shortcut>");
                                    configData.Insert(j + 1, "<name>" + shortcutName + "<\\name>");
                                    configData.Insert(j + 2, "<path>" + path + "<\\path>");
                                    configData.Insert(j + 3, "<\\shortcut>");
                                    // Break the loop
                                    break;
                                }
                            }
                        }
                    }
                }   
        }

        // Structure of the config file
        // <profile>
        //      <shortcut>
        //          <name> Name <\name>
        //          <path> Path <\path>
        //      <\shortcut>
        //      <shortcut>
        //          <name> Name <\name>
        //          <path> Path <\path>
        //      <\shortcut>
        // <\profile>


    }

        private static List<List<string>> readConfigFile()
        {
            List<List<String>> configData = new List<List<String>>();
            if (configExists())
            {
                // Read the config file
                String[] configDataString = System.IO.File.ReadAllLines("config.xml");
                // Loop through the config file
                for (int i = 0; i < configDataString.Length; i++)
                {
                    // Check if the line is a profile
                    if (configDataString[i].Contains("<profile>"))
                    {
                        // Create a new list for the profile
                        List<String> profile = new List<String>();
                        // Add the profile name to the list
                        profile.Add(configDataString[i + 1]);
                        // Loop through the config file
                        for (int j = i + 2; j < configDataString.Length; j++)
                        {
                            // Check if the line is a profile
                            if (configDataString[j].Contains("<profile>"))
                            {
                                // Add the profile to the configData
                                configData.Add(profile);
                                // Break the loop
                                break;
                            }
                            else
                            {
                                // Add the shortcutName to the list
                                profile.Add(configDataString[j]);
                                // Add the path to the list
                                profile.Add(configDataString[j + 1]);
                                // Increment the loop
                                j++;
                            }
                        }
                    }
                }
            }
            return configData;
        }
    }

    // Structure of the config file
    // <profile>
    //      <shortcut>
    //          <name> Name <\name>
    //          <path> Path <\path>
    //      <\shortcut>
    //      <shortcut>
    //          <name> Name <\name>
    //          <path> Path <\path>
    //      <\shortcut>
    // <\profile>


}
