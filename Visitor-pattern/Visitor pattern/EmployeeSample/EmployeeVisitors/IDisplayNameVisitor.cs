namespace EmployeeSample.EmployeeVisitors
{
    internal interface IDisplayNameVisitor
    {
        string Visit(Developer developer);
        string Visit(Manager manager);
    }
}
