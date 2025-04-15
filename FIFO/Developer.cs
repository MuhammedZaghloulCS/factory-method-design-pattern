namespace FIFO1
{
    class Developer : Employee
    {
        public bool TaskCompleted { get; set; }
        public decimal commission = .03m;


        public override decimal calculate()
        {
            return calculateBouns() + base.calculate();
        }
        public decimal calculateBouns()
        {
            return TaskCompleted ? commission * base.calculate() : 0;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBouns : {calculateBouns()}" +
                $"\n total salary : {base.calculate() + calculateBouns()}";
        }
    }

}