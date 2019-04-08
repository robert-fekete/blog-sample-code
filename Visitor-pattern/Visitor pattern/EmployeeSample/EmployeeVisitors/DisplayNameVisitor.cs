namespace EmployeeSample.EmployeeVisitors
{
    internal class DisplayNameVisitor : IDisplayNameVisitor
    {
        public string Visit(Developer developer)
        {
            return developer.Name;
        }

        public string Visit(Manager manager)
        {
            return "Sir. " + manager.Name;
        }
    }
}
