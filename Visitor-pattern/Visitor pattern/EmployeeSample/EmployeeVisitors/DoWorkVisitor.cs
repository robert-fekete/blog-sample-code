namespace EmployeeSample.EmployeeVisitors
{
    internal class DoWorkVisitor : IDoWorkVisitor
    {
        public void Visit(Developer developer)
        {
            // Coding
        }

        public void Visit(Manager manager)
        {
            // Managing
        }
    }
}
