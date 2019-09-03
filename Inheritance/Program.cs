using System;

namespace Inheritance {
    class Program {

        void Run() {
            var emp1 = new Employee("Jason White", "Maint", 50000);
            var emp2 = new Employee("Will Smith ", "Janitor", 60000);
            var emp3 = new Employee("Bob Brown", "President", 90000);

            var mgr1 = new Manager("Jason White", "Maint Mgr", 80000, 10);
            var mgr2 = new Manager("Will Smith", "Senior Mgr", 70000, 50);
            Console.WriteLine(mgr2.Print());

            var emps = new List<Employee>() { emp1, emp2, emp3, mgr1, mgr2 };
            foreach(var emp in emps) {
                Console.WriteLine(emp.Prnt());
            }


        }
        static void Main(string[] args) {
            (new Program()).Run();
            
        }
    }
}
