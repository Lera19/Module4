namespace Utils.Models
{
    public class Employee

    {
        public Employee() { }
        public Employee(string fN, string lN, string email, decimal salary, string mFN, string mLN )
        {
            First_Name = fN;
            Last_Name = lN;
            Email = email;
            Salary = salary;
            Manager_Name = mFN;
            Manager_Last_Name = mLN;
        }
        public string First_Name {get;set;}
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Manager_Name { get; set; }
        public string Manager_Last_Name { get; set; }
        public override string ToString()
        {
            return $"Employee: {First_Name}, {Last_Name}, email {Email},salary {Salary}, " +
                $"and his manager : {Manager_Name}, {Manager_Last_Name}";
        }

    }
}
