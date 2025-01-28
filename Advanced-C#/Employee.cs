using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_
{
    class EmployeeEqualityComparerName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
           return HashCode.Combine(obj.Name);
        }
    }

    class EmployeeComparerSalary : IComparer<Employee>
    {
        public int Compare(Employee? X, Employee? Y)
        {
            return X.Salary.CompareTo(Y.Salary);
        }
    }

    class EmployeeComparerNameLength : IComparer<Employee>
    {
        public int Compare(Employee? X, Employee? Y)
        {
            return X.Name.Length.CompareTo(Y.Name.Length);
        }
    }
    internal class Employee: IComparable<Employee>, IEquatable<Employee>
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }

        public static bool operator ==(Employee Left,Employee Right)
        {

            return Left.Id == Right.Id && Left.Name == Right.Name && Left.Age == Right.Age && Left.Salary == Right.Salary;
        }

        public static bool operator !=(Employee Left, Employee Right)
        {

            return Left.Id == Right.Id && Left.Name == Right.Name && Left.Age == Right.Age && Left.Salary == Right.Salary;
        }

        //public override bool Equals(object? obj)
        //{
        //    Employee E=(Employee)obj;

        //    return this==obj;
        //}

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age:{Age}, Salary:{Salary}";
        }

        public int CompareTo(Employee? other)
        {
            if(other is not null)
            {
                return Age.CompareTo(other.Age);
            }
            return 1;
        }

        public bool Equals(Employee? other)
        {
            if (other is not null)
            {

                return this == other;
            }
            return false;
        }
    }
}
