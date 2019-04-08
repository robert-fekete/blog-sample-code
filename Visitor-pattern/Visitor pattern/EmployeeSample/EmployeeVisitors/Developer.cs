namespace EmployeeSample.EmployeeVisitors
{
    internal class Developer : IEmployee
    {
        public Developer(string name)
        {
            Name = name;
        }

        public string Name { get; }

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
