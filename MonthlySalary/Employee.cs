class Employee
{
    public const int MinimumLoggedHours = 176;
    public const decimal OverTimeRate = 1.25m;
    public int Id { get; set; }
    public string? Name { get; set; }
    public int LoggedHours { get; set; }
    public int Wage { get; set; }

    public virtual decimal CalculateBaseSalary()
    {
        return LoggedHours * Wage + CalculateAdditionalHoursWage();
    }

    public decimal CalculateAdditionalHoursWage()
    {
        return (LoggedHours - MinimumLoggedHours) * Wage;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
