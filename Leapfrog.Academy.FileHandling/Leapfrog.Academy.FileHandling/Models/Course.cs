using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leapfrog.Academy.FileHandling.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public bool Status { get; set; }

        public string ToCSV()
        {
            return Id + "," + Name + "," + Fees + "," + ((Status)?1:0) + "\r\n";
        }
    }
}
