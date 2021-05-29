namespace Personnel
{
    /// <summary>
    /// Администрация
    /// </summary>
    public class Administration : Staff
    {
        public Administration(string name, int workExperience, double salary,
            int reprimandsMade, double bonusesPaid, double finesIssued) : 
            base(name, workExperience, salary)
        {
            ReprimandsMade = reprimandsMade;
            BonusesPaid = bonusesPaid;
            FinesIssued = finesIssued;
        }

        /// <summary>
        /// Сделано выговоров
        /// </summary>
        public int ReprimandsMade { get; set; }

        /// <summary>
        /// Выплачено премий на сумму
        /// </summary>
        public double BonusesPaid { get; set; }

        /// <summary>
        /// Выписано штрафов на сумму
        /// </summary>
        public double FinesIssued { get; set; }


        /// <summary>
        /// Разница между бонусами и штрафами
        /// </summary>
        /// <returns></returns>
        public double DifferenceBetweenBonusesAndFines() => BonusesPaid - FinesIssued;

        /// <summary>
        /// Средняя сумма штрафа за выговор
        /// </summary>
        /// <returns></returns>
        public double AveragePenaltyAmountForReprimand() => FinesIssued / ReprimandsMade;

        /// <summary>
        /// Отношение штрафов к премиям
        /// </summary>
        public double RatioOfFinesToBonuses() => FinesIssued / BonusesPaid;

        public override string ToString() => base.ToString() + 
            $"\nСделано выговоров: {ReprimandsMade}\n" +
            $"Выплачено премий на сумму: {BonusesPaid} р.\n" +
            $"Выписано штрафов на сумму: {FinesIssued} р.";


        public override bool IsContains(string text)
        {
            text = text.ToUpper();
            if (Name.Contains(text)
                || WorkExperience.ToString().Contains(text)
                || Salary.ToString().Contains(text)
                || ReprimandsMade.ToString().Contains(text)
                || BonusesPaid.ToString().Contains(text)
                || FinesIssued.ToString().Contains(text)) return true;
            else return false;
        }
    }
}
