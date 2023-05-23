namespace HomeworkTwentySix.Library
{
    public class EmployeeModel
    {
        public decimal HourlyRate { get; set; }

        public virtual decimal GetPaycheckAmount(int hoursWork)
        {
            return HourlyRate * hoursWork;
        }
    }
}
