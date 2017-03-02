using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leapfrog.Academy.FileHandling.Helpers;
using Leapfrog.Academy.FileHandling.Models;

namespace Leapfrog.Academy.FileHandling.Repository
{
    public interface ICourseRepository
    {
        void Import(string fileName);
        void Insert(Course _course);
        void Export(string fileName);
        IList<Course> GetAll();
    }
    public class CourseRepository : ICourseRepository
    {
        private IList<Course> _CourseList = new List<Course>();

        public void Export(string fileName)
        {
            StringBuilder content = new StringBuilder();
            foreach(Course c in _CourseList)
            {
                content.Append(c.ToCSV());
            }

            FileHelper.Write(fileName, content.ToString());
        }

        public IList<Course> GetAll()
        {
            return _CourseList;
        }

        public void Import(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tokens = line.Split(",".ToCharArray());
                    if (tokens.Length > 3)
                    {
                        Course course = new Course();
                        course.Id = Convert.ToInt32(tokens[0]);
                        course.Name = tokens[1];
                        course.Fees = Convert.ToDouble(tokens[2]);
                        course.Status = (tokens.Equals("1")) ? true : false;
                        _CourseList.Add(course);
                    }
                }
            }
        }

        public void Insert(Course _course)
        {
            _CourseList.Add(_course);

        }
    }
}
