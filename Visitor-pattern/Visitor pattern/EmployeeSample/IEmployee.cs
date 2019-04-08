namespace EmployeeSample
{
    internal interface IEmployee
    {
        string DisplayName { get; }
        void DoWork();
        void Accept(IEmployeeVisitor visitor);
    }
}
