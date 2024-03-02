using System;
namespace Week5
{
    class Program
    {
        interface IEmployee
        {
            //Properties
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            //Methods
            public string Fullname();
            public double Pay();
        }
        class Employee : IEmployee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Employee()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Employee(int id, string firstName, string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public virtual double Pay()
            {
                double salary;
                Console.WriteLine($"What is {this.Fullname()}'s weekly salary as an employee?");
                salary = double.Parse(Console.ReadLine());
                return salary;
            }

        }
        sealed class Executive : Employee
        {
            public string Title { get; set; }
            public double Salary { get; set; }
            public Executive() 
                :base()
            { 
                Title = string.Empty;
                Salary = 0;
            }
            public Executive(int id, string firstName, string lastName, string title, double salary) 
                :base(id, firstName, lastName)
                {
                    Title = title;
                    Salary = salary;
                }
            public override double Pay()
            {
                Console.WriteLine($"What is {this.Fullname()}'s weekly salary as an executive?");
                double salary = double.Parse(Console.ReadLine());
                return salary;
            }
        }        
        static void Main(string[] args)
        {
            Employee employee = new Employee(1,"Chris","Morrison");
            Executive exec = new Executive(1, "Tom", "Morrison", "CEO", 2600);

            double pay = employee.Pay();
            double salary = exec.Pay();
            Console.WriteLine(employee.Fullname() + "\nWeekly pay: " + pay);
            Console.WriteLine(exec.Fullname() + "\nWeekly Salary: " + salary);
        }
    }
}

