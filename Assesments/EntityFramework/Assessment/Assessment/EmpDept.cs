using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class EmpDept
    {

        public void DisplayAllEmp()
        {
            EmpDeptEntities con = new EmpDeptEntities();
            var Departments = con.Departments;
            var Employees = con.Employees;

            foreach (Department dept in Departments)
            {
                Console.WriteLine($"{dept.Name}-{dept.Location}");
                Console.WriteLine("Id\tFirst Name\tLast Name\tGender\tSalary");

                foreach (var emp in Employees)
                {
                    if(emp.DepartmentId == dept.Id)
                    {
                        Console.WriteLine($"{emp.Id}\t{emp.FirstName}\t\t{emp.LastName}\t\t{emp.Gender}\t{emp.Salary}");
                    }
                }
            }
        }

        public void ViewDepts()
        {
            EmpDeptEntities con = new EmpDeptEntities();
            var Departments = con.Departments;

            foreach (var dept in Departments)
            {
                Console.WriteLine($"{dept.Id} - {dept.Name}");
            }
        }
        public void DisplayEmpByDept(int id)
        {
            EmpDeptEntities con = new EmpDeptEntities();
            var Departments = con.Departments;
            var Employees = con.Employees;

            foreach (var dept in Departments)
            {
                if(dept.Id == id)
                {
                    Console.WriteLine($"{dept.Name}-{dept.Location}");
                    Console.WriteLine("Id\tFirst Name\tLast Name\tGender\tSalary");

                    foreach (var emp in Employees)
                    {
                        if(emp.DepartmentId == dept.Id)
                        {
                            Console.WriteLine($"{emp.Id}\t{emp.FirstName}\t\t{emp.LastName}\t\t{emp.Gender}\t{emp.Salary}");
                        }
                    }
                }

            }
        }

    }
}
