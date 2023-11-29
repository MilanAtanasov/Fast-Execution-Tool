using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Fast_Execution_Tool
{
    internal abstract class configFileMethods
    {
        public static void fileInitialization()
        {
            dataXML.Instance.initializeObject();

        }

        public static String readConfigFile()
        {
            String xmlData = "";
            if (fileExists())
            {
                xmlData = File.ReadAllText("config.xml");
            }
            else
            {
                createFile();
                xmlData = "<root>\n<profiles>\n<profile name=\"Default\">\n</profile>\n</profiles>\n</root>";
                writeToFile(xmlData);
            }
            return xmlData;
        }

        private static bool fileExists()
        {
            return File.Exists("config.xml");
        }

        private static void createFile()
        {
            // create the file
            File.Create("config.xml").Dispose();
        }

        private static void writeToFile(String xmlData)
        {
            File.WriteAllText("config.xml", xmlData);
        }

    }

}
