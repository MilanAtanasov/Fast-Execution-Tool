using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Fast_Execution_Tool
{
    internal class ConfigElements
    {
        // Static variable that holds the single instance
        private static ConfigElements _instance;
        private static readonly object _lock = new object();

        // List to hold shortcuts
        private List<string> shortcuts = new List<string>();

        // Private constructor
        private ConfigElements()
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "configExecutionTool.txt");
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    shortcuts.Add(line);
                }
            }
            else
            {
                CreateConfig();
            }
        }

        // Public static method to get the instance of the class
        public static ConfigElements Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigElements();
                    }
                }
                return _instance;
            }
        }

        public void UpdateConfig()
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "configExecutionTool.txt");
            File.WriteAllLines(filePath, shortcuts);
        }

        private void CreateConfig()
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "configExecutionTool.txt");
            using (var stream = File.Create(filePath))
            {
                // File is automatically closed when exiting the using block
            }
        }

        public void RemoveShortcut(string shortcut)
        {
            if (shortcuts.Contains(shortcut))
            {
                shortcuts.Remove(shortcut);
                UpdateConfig();
            }
        }

        public void AddShortcut(string shortcut)
        {
            shortcuts.Add(shortcut);
            UpdateConfig();
        }

        public void addShortcut(String shortcutName, String shortcutPath)
        {
            // add shortcut to config file as a new line with the format:
            // shortcutName;shortcutPath; (semicolon as separator) 
            // and close the form
            ConfigElements.Instance.AddShortcut(shortcutName + ";" + shortcutPath);
        }
        

        public ArrayList readConfig()
        {
            // read config file
            ArrayList config = new ArrayList();

            // check if config file exists
            if (configExists())
            {
                // read config file
                string[] lines = System.IO.File.ReadAllLines(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configExecutionTool.txt");

                // add each line to the config array
                foreach (string line in lines)
                {
                    config.Add(line);
                }
            }
            else
            {
                // create config file
                createConfig();
            }

            return config;
        }

        public Boolean configExists()
        {
            // check if config file exists in the same directory as the executable
            if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configExecutionTool.txt"))
            {
                return true;
            }

            return false;
        }

        public void createConfig()
        {
            // create config file
            System.IO.File.Create(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configExecutionTool.txt");
        }
    }
}
