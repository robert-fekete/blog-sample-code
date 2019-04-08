namespace EmployeeSample
{
    internal class Manager : IEmployee
    {
        private readonly string name;

        public Manager(string name)
        {
            this.name = name;
        }
        public string DisplayName => "Sir. " + name;

        public void DoWork()
        {
            // Managing
        }

        public void Accept(IEmployeeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
