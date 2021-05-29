namespace Personnel
{
    /// <summary>
    /// Абстрактный класс Кадры
    /// </summary>
    public abstract class Staff
    {
        
        /// <summary>
        /// Кадры
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="workExperience">Стаж</param>
        /// <param name="salary">ЗП</param>
        protected Staff(string name, int workExperience, double salary)
        {
            Name = name;
            WorkExperience = workExperience;
            Salary = salary;
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стаж работы
        /// </summary>
        public int WorkExperience { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public double Salary { get; set; }


        /// <summary>
        /// Зарплата в день
        /// </summary>
        /// <returns>Рубли</returns>
        public double GetSalaryInDay() => Salary / 30;

        /// <summary>
        /// Стаж в месяцах
        /// </summary>
        /// <returns>Месяцы</returns>
        public int GetWorkExperienceInMonths() => WorkExperience * 12;

        /// <summary>
        /// Суммарная ЗП за время работы
        /// </summary>
        /// <returns>Рубли</returns>
        public double GetTotalSalary() => GetWorkExperienceInMonths() * Salary;



        public override string ToString() => $"Имя: {Name}\nСтаж работы: {WorkExperience} лет.\nЗарплата: {Salary} р.";

        /// <summary>
        /// Содержат ли свойства объекта заданную строку
        /// </summary>
        /// <param name="text">Искомая строка</param>
        public abstract bool IsContains(string text);
    }
}
