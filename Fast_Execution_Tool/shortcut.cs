using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Execution_Tool
{
    internal class shortcut
    {
        private String name;
        private String path;
        private String type;

        public shortcut() { }

        public shortcut(String name, String path, String type)
        {
            this.name = name;
            this.path = path;
            this.type = type;
        }

        public String getName()
        {
            return name;
        }

        public String getPath()
        {
               return path;
        }

        public String getType()
        {
               return type;
        }

        public void setName(String name)
        {
               this.name = name;
        }

        public void setPath(String path)
        {
               this.path = path;
        }

        public void setType(String type)
        {
               this.type = type;
        }

    }
}
