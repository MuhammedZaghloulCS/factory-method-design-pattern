namespace FIFO1
{
    class Maintenance :Employee
    {
        private const decimal HardShip = 10;
        public override decimal calculate()=> base.calculate()+HardShip;
        public override string ToString()
        {
            return base.ToString()+$"\nHardShip : {HardShip}";
        }
    }
}