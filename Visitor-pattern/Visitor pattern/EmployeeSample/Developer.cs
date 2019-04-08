namespace EmployeeSample
{
    internal class Developer : IEmployee
    {
        public Developer(string name)
        {
            this.DisplayName = name;
        }

        public string DisplayName { get; }

        public void DoWork()
        {
            // Coding
        }

        public void Accept(IEmployeeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
