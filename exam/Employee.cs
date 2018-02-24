using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WorkerName { get; set; }
        public int Salary { get; set; }
        public int pas { set;  get; }
        public Employee(int ID, string firstName, string lastName, string workerName, int salary, int pas)
        {
            this.ID = ID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.WorkerName = workerName;
            this.pas = pas;
        }
        public Employee() { }

        public override string ToString()
        {
            return String.Format("ID: {0}. Fitst Name: {1}. Last Name: {2}. Worker Name: {3}. Salary: {4}", ID, FirstName, LastName, WorkerName, Salary);
        }
        public void ShowInfoEmployee(List<Employee> persons)
        {
            foreach (var p in persons)
            {
                Console.WriteLine("ID: {0}. Fitst Name: {1}. Last Name: {2}. Worker Name: {3}. Salary: {4}", p.ID, p.FirstName, p.LastName, p.WorkerName, p.Salary);
            }
            
        }
    }
}
