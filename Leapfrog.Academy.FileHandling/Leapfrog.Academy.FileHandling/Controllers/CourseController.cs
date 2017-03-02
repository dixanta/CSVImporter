using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leapfrog.Academy.FileHandling.Models;
using Leapfrog.Academy.FileHandling.Repository;

namespace Leapfrog.Academy.FileHandling.Controllers
{
    public class CourseController
    {
        private ICourseRepository _CourseRepository;

        public CourseController(ICourseRepository _CourseRepository)
        {
            this._CourseRepository = _CourseRepository;
        }

        private void Menu()
        {
            Console.WriteLine("1. Add Course");
            Console.WriteLine("2. Show Courses");
            Console.WriteLine("3. Export");
            Console.WriteLine("4. Import");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter Your Choice:");

        }
        private void AddView()
        {
            Console.WriteLine("Add Course");
            Course _Course = new Course();
            Console.WriteLine("Enter Id:");
            _Course.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            _Course.Name = Console.ReadLine();
            Console.WriteLine("Enter Fees");
            _Course.Fees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Status:");
            _Course.Status = Convert.ToBoolean(Console.ReadLine());

            _CourseRepository.Insert(_Course);

        }

        private void ShowView()
        {
            Console.WriteLine("Printing All Courses");
            foreach(Course c in _CourseRepository.GetAll())
            {
                Console.WriteLine(c.ToCSV());
            }

        }

        public void ExportView()
        {
            Console.WriteLine("Enter The File Path:");
            string fileName = Console.ReadLine();
            _CourseRepository.Export(fileName);
            
        }

        public void ImportView()
        {
            Console.WriteLine("Enter The File Path:");
            string fileName = Console.ReadLine();
            _CourseRepository.Import(fileName);

        }

        public void Process()
        {
            while (true)
            {
                Menu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddView();
                        break;
                    case 2:
                        ShowView();
                        break;
                    case 3:
                        ExportView();
                        break;
                    case 4:
                        ImportView();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }

    }

}
