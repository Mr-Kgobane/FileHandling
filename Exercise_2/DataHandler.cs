using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class DataHandler
    {
        List<Employee> employees = new List<Employee>();
        public List<String> Format(List<string> lst) 
        {
            List<Employee> ee = new List<Employee>();
            foreach (string line in lst)
            {
                string[] parts = line.Split(',');
                Employee e = new Employee(parts[0],parts[1],parts[2]);
                ee.Add(e);
            }
            List<String> result = new List<String>();
            foreach (Employee e in ee) result.Add(e.ToString());
            return result;
        }

    
    }
}
