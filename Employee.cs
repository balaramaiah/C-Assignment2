using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    public class Employee
    {
        protected int empno { get; set; }
        protected string empname { get; set; }
        protected double Salary { get; set; }
        protected double hra { get; set; }
        protected double ta { get; set; }
        protected double da { get; set; }
        protected double pf { get; set; }
        protected double tds { get; set; }
        protected double netsalary { get; set; }
        protected double grossalary { get; set; }




        public Employee(int empid, string empnm, double sal)
        {
            empno = empid;
            empname = empnm;
            Salary = sal;

            if (Salary < 5000)
            {
                hra = ((Salary / 100) * 10);
                ta = ((Salary / 100) * 5);
                da = ((Salary / 100) * 15);
                grossalary = Salary + hra + ta + da;
            }
            else if (Salary < 10000)
            {
                hra = ((Salary / 100) * 15);
                ta = ((Salary / 100) * 10);
                da = ((Salary / 100) * 20);
                grossalary = Salary + hra + ta + da;

            }

            else if (Salary < 15000)
            {
                hra = ((Salary / 100) * 20);
                ta = ((Salary / 100) * 15);
                da = ((Salary / 100) * 25);
                grossalary = Salary + hra + ta + da;

            }

            else if (Salary < 20000)
            {
                hra = ((Salary / 100) * 25);
                ta = ((Salary / 100) * 20);
                da = ((Salary / 100) * 30);
                grossalary = Salary + hra + ta + da;

            }
            else
            {
                hra = ((Salary / 100) * 30);
                ta = ((Salary / 100) * 25);
                da = ((Salary / 100) * 35);
                grossalary = Salary + hra + ta + da;

            }

        }




        public virtual void CalculateSalary()
        {
            Console.WriteLine("Employee GrosSalary : " + grossalary);

            pf = (grossalary / 100) * 10;
            tds = (grossalary / 100) * 18;

            netsalary = grossalary - (pf + tds);



            Console.WriteLine("Employee NetSalary : " + netsalary);
        }



    }


    public class Library
    {
        public static void Main()
        {
            Console.WriteLine("Employee Number :");
            int empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Name :");
            string empname = Console.ReadLine();
            Console.WriteLine("Employee Salary :");
            double sal = Convert.ToDouble(Console.ReadLine());
            Employee e = new Employee(empid, empname, sal);
            e.CalculateSalary();
            
            Console.ReadKey();
        }



    }
    }


