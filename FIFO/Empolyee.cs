namespace FIFO1
{
    abstract class Employee
    {
        protected const int minimumLoggedHours = 176;
        protected const decimal overTimeRate = 1.25m;
        public decimal ID { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }
        public decimal Wage { get; set; }

        public Employee() { }
        public Employee(decimal id, string name, decimal loggedHours, decimal wage) =>
            (ID, Name, LoggedHours, Wage) = (id, name, loggedHours, wage);

        public virtual decimal calculate()
        {
         
            return calculateBaseSalary()+calculateOverTime();
        }
        public decimal calculateBaseSalary()
        {
            return minimumLoggedHours * Wage;
        }
        public decimal calculateOverTime()
        {
            var additionalLoggedHour=LoggedHours>minimumLoggedHours?
                                        LoggedHours-minimumLoggedHours: 0;

            return additionalLoggedHour*Wage*overTimeRate;
        }
        public override string ToString()
        {
            return $"\nID: {ID}" +
                $"\nName: {Name}" +
                $"\nLogged Hours: {LoggedHours}" +
                $"\nWage : {Wage} per hour" +
                $"\nBase Salary : {calculateBaseSalary()}" +
                $"\nOver time salary : {calculateOverTime()}";
        }

    }

}