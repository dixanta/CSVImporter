using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leapfrog.Academy.FileHandling.Helpers
{
    public class FileHelper
    {
        public static void Write(string fileName,string content)
        {
            using(StreamWriter writer=new StreamWriter(fileName))
            {
                writer.Write(content);
            }
        }
    }
}
