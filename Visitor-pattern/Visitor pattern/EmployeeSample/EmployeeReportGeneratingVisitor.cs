namespace EmployeeSample
{
    internal class EmployeeReportGeneratingVisitor : IEmployeeVisitor
    {
        private int developers = 0;
        private int managers = 0; 

        public float Ratio => ((float) managers) / developers;

        public void Visit(Developer developer)
        {
            developers++;
        }

        public void Visit(Manager manager)
        {
            managers++;
        }
    }
}
