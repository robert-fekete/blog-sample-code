namespace EmployeeSample.EmployeeVisitors
{
    internal interface IDoWorkVisitor
    {
        void Visit(Developer developer);
        void Visit(Manager manager);
    }
}