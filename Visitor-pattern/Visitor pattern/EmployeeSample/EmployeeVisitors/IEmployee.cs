namespace EmployeeSample.EmployeeVisitors
{
    internal interface IEmployee
    {
        string Accept(IDisplayNameVisitor visitor);
        void Accept(IDoWorkVisitor visitor);
    }
}
