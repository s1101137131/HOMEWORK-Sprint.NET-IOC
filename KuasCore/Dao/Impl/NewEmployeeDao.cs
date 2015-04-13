using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao

    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> emps = new List<Employee>();
            
            Employee emp1 = new Employee();

            emp1.Id = "Yuan";
            emp1.Name = "ㄩㄢ";
            emp1.Age = 21;
            emps.Add(emp1);

            Employee emp2 = new Employee();

            emp2.Id = "Chen";
            emp2.Name = "陳陳陳";
            emp2.Age = 100;
            emps.Add(emp2);
            return emps;
        }

        public Employee GetEmployeeById(String id)
        {
            Employee emps = new Employee();
            emps.Id = "Yuan";
            emps.Name = "ㄩㄢ";
            emps.Age = 21;

            return emps;
        }
    }
}
