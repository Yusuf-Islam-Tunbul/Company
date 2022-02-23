using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220209_Digiturk
{
    class Employee
    {
        public enum Department
        {
            HR,Sales,Accounting
        }

        private string _first_name;
        private string _last_name;
        private long _id_number;
        private DateTime _birth_date;
        private DateTime _hired_date;
        private DateTime _fired_date;
        private float _fixed_salary;
        private int _annual_permit;
        private bool _still_working;
        private Department _department;
        private int _people_employed;
        private int _sales_made;

        public string FirstName
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        public string LastName
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        public long IDNumber
        {
            get { return _id_number; }
            set { _id_number = value; }
        }

        public DateTime BirthDate
        {
            get { return _birth_date; }
            set { _birth_date = value; }
        }

        public DateTime HiredDate
        {
            get { return _hired_date; }
            set { _hired_date = value; }
        }

        public DateTime FiredDate
        {
            get { return _fired_date; }
            set 
            { 
                _fired_date = value;
                _still_working = false;
                _fixed_salary = 0;
            }
        }

        public float FixedSalary
        {
            get { return _fixed_salary; }
        }

        public int AnnualPermit
        {
            get { return _annual_permit; }
        }

        public bool StillWorking
        {
            get { return _still_working; }
        }

        public Department Department_
        {
            get { return _department; }
            set { _department = value; }
        }

        public int PeopleEmployed
        {
            get { return _people_employed; }
            set
            {
                if (this.Department_ == Department.HR)
                {
                    _people_employed = value;
                }
            }
        }

        public int SalesMade
        {
            get { return _sales_made; }
            set
            {
                if (this.Department_ == Department.Sales)
                {
                    _sales_made = value;
                }
            }
        }

        public TimeSpan GetAge()
        {
            TimeSpan age = DateTime.Now - this.BirthDate;
            return age;
        }

        public int GetSeniority()
        {
            int seniority = (DateTime.Now - this.HiredDate).Days/365;
            return seniority;
        }

        public float GetTotalSalary()
        {
            float total_salary = this.FixedSalary;

            switch (this.Department_)
            {
                case Department.HR:
                    total_salary *= (1 + (0.1f*(this.PeopleEmployed/3)));
                    break;

                case Department.Sales:
                    total_salary *= (1 + (0.25f * (this.SalesMade / 10)));
                    break;

                case Department.Accounting:

                    if (((DateTime.Now.Month - this.HiredDate.Month) % 2) == 0)
                    {
                        total_salary *= 1.5f;
                    }

                    break;
            }

            return total_salary;
        }

        public Employee(string first_name,string last_name, long id_number, DateTime birth_date,DateTime hired_date, Department department)
        {
            this.FirstName = first_name;
            this.LastName = last_name;
            this.IDNumber = id_number;
            this.BirthDate = birth_date;
            this.HiredDate = hired_date;
            this.Department_ = department;
            this._still_working = true;

            switch (department)
            {
                case Department.HR:
                    this._fixed_salary = 10000;
                    this._annual_permit = 14;
                    break;
                case Department.Accounting:
                    this._fixed_salary = 9000;
                    this._annual_permit = 5;
                    break;
                case Department.Sales:
                    this._fixed_salary = 8000;
                    this._annual_permit = 10;
                    break;
            }          
        }
    }
}
