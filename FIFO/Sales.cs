namespace FIFO1
{
    class Sales : Employee
    {


        public decimal SalesVolume {  get; set; }
        public decimal commission { get; set; }


        public override decimal calculate()
        {
            return calculateBouns() + base.calculate();
        }
        public decimal calculateBouns()
        {
            return commission * base.calculate();
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBouns : {calculateBouns()}" +
                $"\n total salary : {base.calculate() + calculateBouns()}";
        }
    }
}
