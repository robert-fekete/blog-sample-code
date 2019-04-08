namespace EmployeeSample
{
    internal interface IEmployeeVisitor
    {
        void Visit(Developer developer);
        void Visit(Manager manager);
    }
}