namespace Personnel
{
    /// <summary>
    /// Рабочий
    /// </summary>
    public class Worker : Staff
    {
        public Worker(string name, int workExperience, double salary,
            double producesPartsPerHour, double drinksCoffeePerHour, int tardinessPerMonth):
            base(name, workExperience, salary)
        {
            ProducesPartsPerHour = producesPartsPerHour;
            DrinksCoffeePerHour = drinksCoffeePerHour;
            TardinessPerMonth = tardinessPerMonth;
        }

        /// <summary>
        /// Производит детелей в час
        /// </summary>
        public double ProducesPartsPerHour { get; set; }

        /// <summary>
        /// Выпивает кофе в час
        /// </summary>
        public double DrinksCoffeePerHour { get; set; }

        /// <summary>
        /// Опозданий в среднем за месяц
        /// </summary>
        public int TardinessPerMonth { get; set; }

        /// <summary>
        /// Производит деталей за N рабочих день
        /// </summary>
        /// <returns></returns>
        public double ProducesPartsPerWorkingDay(int workingDays) => ProducesPartsPerHour * 8 * workingDays;

        /// <summary>
        /// Производит деталей за одну кружку кофе
        /// </summary>
        /// <returns></returns>
        public double ProducesPartsForOneCupOfCoffee() => ProducesPartsPerHour / DrinksCoffeePerHour;

        /// <summary>
        /// Опозданий в среднем за год
        /// </summary>
        /// <returns></returns>
        public double TardinessPerYear() => TardinessPerMonth * 12;



        public override string ToString() => base.ToString() +
    $"\nПроизводит детелей в час: {ProducesPartsPerHour} ед.\n" +
    $"Выпивает кофе в час: {DrinksCoffeePerHour} чашек\n" +
    $"Опозданий в среднем за месяц: {TardinessPerMonth}";


        public override bool IsContains(string text)
        {
            text = text.ToUpper();
            if (Name.Contains(text)
                || WorkExperience.ToString().Contains(text)
                || Salary.ToString().Contains(text)
                || ProducesPartsPerHour.ToString().Contains(text)
                || DrinksCoffeePerHour.ToString().Contains(text)
                || TardinessPerMonth.ToString().Contains(text)) return true;
            else return false;
        }

    }
}
