using System.Xml.Linq;

namespace Advanced_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Swap
            //int A = 3, B = 4;

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine("********After Swap********");


            //Helper.SWAP(ref A, ref B);


            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //double A = 3, B = 4;

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");


            //Console.WriteLine("********After Swap********");


            //Helper.SWAP(ref A, ref B);


            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");


            //Point P01=new Point(1,1);

            //Point P02=new Point(2,2);


            //Console.WriteLine(P01.ToString());
            //Console.WriteLine(P02.ToString());


            //Console.WriteLine("********After Swap********");

            //Helper.SWAP(ref P01,ref P02);

            //Console.WriteLine(P01.ToString());
            //Console.WriteLine(P02.ToString()); 
            #endregion

            #region Generic Linear Search
            //int[] Arr = { 2, 34, 4, 5, 6, 12, 55, 66, 88, 99, 123, 059 };

            //int Index = Helper.LinearSearch(Arr, 55);

            //Console.WriteLine($"Index: {Index}");

            //Employee E01=new Employee() { Id = 1,Name="Ahmed", Age=25, Salary=12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Youssef", Age = 35, Salary = 19000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Mohammed", Age = 45, Salary = 19000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Ali", Age = 35, Salary = 15000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //int Index = Helper.LinearSearch(employees, E03);

            //Console.WriteLine($"Index: {Index}"); 
            #endregion

            #region Equals
            //Employee E01 = new Employee() { Id = 1 , Name="Ahmed", Age=25, Salary=12000};
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 25, Salary = 12000 };
            //Employee E03 = new Employee() { Id = 2, Name = "Hamed", Age = 25, Salary = 12000 };

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
            //Console.WriteLine(E03.GetHashCode());


            //if (E01.Equals(E03))
            //{
            //    Console.WriteLine("E01==E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01!=E02");
            //}

            //if (E01 == E02)
            //{
            //    Console.WriteLine("E01==E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01!=E02");
            //} 
            #endregion

            #region Bubble Sort
            //int[] Numbers = { 1, 2, 5, 7, 8, 9, 6, 12, 77, 88, 66, 99, 44, 33, 88 };

            //Helper.PrintArray(Numbers);

            //Console.WriteLine();
            //Helper.BubbleSort(Numbers);


            //Helper.PrintArray(Numbers);

            //Point[] points ={

            //    new Point(5,4),
            //    new Point(8,9),
            //    new Point(1,3),
            //    new Point(4,4),
            //    new Point(6,7),
            //    new Point(2,7),
            //};


            //Helper.PrintArray(points);

            //Console.WriteLine();

            //Helper.BubbleSort(points);

            //Helper.PrintArray(points); 

            //Employee E01=new Employee() { Id = 1, Name="Ahmed",Age=25,Salary=12000 };
            //Employee E02 = new Employee() { Id = 8, Name = "Murad", Age = 37, Salary = 25000 };
            //Employee E03 = new Employee() { Id = 7, Name = "Fared", Age = 35, Salary = 20000 };
            //Employee E04 = new Employee() { Id = 5, Name = "Mohamed", Age = 29, Salary = 15000 };

            //Employee[] employees={ E01, E02,E03, E04 };


            //Helper.PrintArray(employees);

            //Console.WriteLine();

            //Helper.BubbleSort(employees);

            //Helper.PrintArray(employees);
            #endregion

            #region Generic IComparable
            //Point[] points ={

            //    new Point(5,4),
            //    new Point(8,9),
            //    new Point(1,3),
            //    new Point(4,4),
            //    new Point(6,7),
            //    new Point(2,7),
            //};


            //Helper.PrintArray(points);

            //Console.WriteLine();

            //Helper.BubbleSort(points);
            //Helper.PrintArray(points);

            //Employee E01=new Employee() { Id = 1, Name="Ahmed",Age=25,Salary=12000 };
            //Employee E02 = new Employee() { Id = 8, Name = "Murad", Age = 37, Salary = 25000 };
            //Employee E03 = new Employee() { Id = 7, Name = "Fared", Age = 35, Salary = 20000 };
            //Employee E04 = new Employee() { Id = 5, Name = "Mohamed", Age = 29, Salary = 15000 };

            //Employee[] employees={ E01, E02,E03, E04 };


            //Helper.PrintArray(employees);

            //Console.WriteLine();

            //Helper.BubbleSort(employees);

            //Helper.PrintArray(employees); 
            #endregion

            #region IEqualable
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 25, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 25, Salary = 12000 };
            ////Employee E02 = new Employee() { Id = 8, Name = "Murad", Age = 37, Salary = 25000 };
            //Employee E03 = new Employee() { Id = 7, Name = "Fared", Age = 35, Salary = 20000 };
            //Employee E04 = new Employee() { Id = 5, Name = "Mohamed", Age = 29, Salary = 15000 };

            //if (E01.Equals(E02))
            //{
            //    Console.WriteLine("E01==E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01!=E02");
            //} 
            #endregion

            #region Icomparable With Linear Sort
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 25, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 8, Name = "Murad", Age = 37, Salary = 25000 };
            //Employee E03 = new Employee() { Id = 7, Name = "Fared", Age = 35, Salary = 20000 };
            //Employee E04 = new Employee() { Id = 5, Name = "Ali", Age = 29, Salary = 15000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //int Index = Helper.LinearSearch(employees, new Employee() { Name = " Ali" }, new EmployeeEqualityComparerName());

            //Console.WriteLine($"Index: {Index}"); 
            #endregion

            #region Icomparable With Bubble Sort

            // Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 25, Salary = 12000 };
            // Employee E02 = new Employee() { Id = 8, Name = "Murad", Age = 37, Salary = 25000 };
            // Employee E03 = new Employee() { Id = 7, Name = "Fared", Age = 35, Salary = 20000 };
            // Employee E04 = new Employee() { Id = 5, Name = "Ali", Age = 29, Salary = 15000 };

            // Employee[] employees = { E01, E02, E03, E04 };

            // Helper.PrintArray(employees);

            //Helper.BubbleSort(employees, new EmployeeComparerNameLength());

            // Console.WriteLine();

            // Helper.PrintArray(employees); 
            #endregion


        }
    }
}
