internal class Employee
{
    
        
            private int EmpID { get; set; }
            private string Name { get; set; }
            private string Dept { get; set; }
            private string Desig { get; set; }
            private int Salary { get; set; }
       
        public void GetEmpInformation(int EmpID, string Name, string Dept, string Desig, int Salary)
        {
            this.EmpID = EmpID;
            this.Name = Name;
            this.Dept = Dept;
            this.Desig = Desig;
            this.Salary = Salary;
        }
        public void DisplayEmpInformation()
        {
        Console.WriteLine($"{this.EmpID}\t {this.Name}\t {this.Dept}\t {this.Desig}\t {this.Salary}");


    }
    




    static void Main()
    {
        Employee[] emp = new Employee[10];
        Console.Write("Enter How Many Employees ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            emp[i] = new Employee();
            Console.WriteLine($"\nEnter Employee Details {i+1} \n");
            Console.Write("Enter Empid         : ");
            int EmpID= int.Parse(Console.ReadLine());
            Console.Write("\nEnter Name        : ");
            string Name= Console.ReadLine();
            Console.Write("\nEnter Department  : ");
            string Dept = Console.ReadLine();
            Console.Write("\nEnter Designation : ");
            string Desig = Console.ReadLine();
            Console.Write("\nEnter Salary      : ");
            int Salary = int.Parse(Console.ReadLine());
            emp[i].GetEmpInformation(EmpID,Name,Dept,Desig,Salary);
            
        }
        Console.WriteLine("************************************************************");
        Console.WriteLine("ID   \t Name \t Department  \t Designation \t Salary ");
        Console.WriteLine("************************************************************");
        for (int j = 0; j < N; j++)
        {

            emp[j].DisplayEmpInformation();
        }

    }
}
