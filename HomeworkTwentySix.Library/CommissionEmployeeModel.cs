namespace HomeworkTwentySix.Library
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWork)
        {
            decimal initialAmount = base.GetPaycheckAmount(hoursWork);

            return initialAmount + CommissionAmount;
        }
    }
}
