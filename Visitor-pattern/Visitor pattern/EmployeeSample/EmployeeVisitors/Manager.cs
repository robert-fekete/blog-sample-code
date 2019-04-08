namespace EmployeeSample.EmployeeVisitors
{
    internal class Manager : IEmployee
    {
        public Manager(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Accept(IDisplayNameVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public void Accept(IDoWorkVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
