using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Leapfrog.Academy.FileHandling.Helpers;
using Leapfrog.Academy.FileHandling.Controllers;
using Leapfrog.Academy.FileHandling.Repository;

namespace Leapfrog.Academy.FileHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CourseController _controller = new CourseController(new CourseRepository());
            _controller.Process();
        }
    }
}
