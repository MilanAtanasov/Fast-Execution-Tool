using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Fast_Execution_Tool
{
    internal class ShortcutsBox
    {
        // Static variable that holds the single instance
        private static ShortcutsBox _instance;
        private static readonly object _lock = new object();

        // List to hold shortcuts
        private List<string> shortcuts = new List<string>();

        // Private constructor
        private ShortcutsBox()
        {
        }

        // Public static method to get the instance of the class
        public static ShortcutsBox Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ShortcutsBox();
                    }
                }
                return _instance;
            }
        }

        private void UpdateConfig()
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
    }
}
