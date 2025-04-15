namespace FIFO1
{
    class Manager : Employee
    {
        private const decimal AllowanceRate = .05m;
       
            public Manager() { }
        public Manager(decimal id, string name, decimal loggedHours, decimal wage) : base(id,name,loggedHours,wage )
        { }

        public override decimal calculate()
        {
            return calculateAllowance() +base.calculate();
        }
        public decimal calculateAllowance()
        {
            return AllowanceRate*base.calculate();
        }
        public override string ToString()
        {
            return base.ToString()+$"\nAllowce : {calculateAllowance()}" +
                $"\n total salary : {base.calculate()+calculateAllowance()}";
        }
    }

}