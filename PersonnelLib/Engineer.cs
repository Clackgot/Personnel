namespace Personnel
{
    /// <summary>
    /// Инженер
    /// </summary>
    public class Engineer : Staff
    {
        public Engineer(string name, int workExperience, double salary,
            int projectsImplemented, int subordinateWorker, int projectsFailed) :
            base(name, workExperience, salary)
        {
            ProjectsImplemented = projectsImplemented;
            SubordinateWorker = subordinateWorker;
            ProjectsFailed = projectsFailed;
        }

        /// <summary>
        /// Реализовано проектов
        /// </summary>
        public int ProjectsImplemented { get; set; }

        /// <summary>
        /// Рабочих в подчинении
        /// </summary>
        public int SubordinateWorker { get; set; }

        /// <summary>
        /// Проваленных проектов
        /// </summary>
        public int ProjectsFailed { get; set; }

        /// <summary>
        /// Процент успешных проектов (0-100%)
        /// </summary>
        /// <returns></returns>
        public double ProjectSuccessRate() => (1 - ProjectsFailed / ProjectsImplemented) * 100;

        /// <summary>
        /// Проектов на одного рабочего в подчинении
        /// </summary>
        /// <returns></returns>
        public double ProjectsPerSubordinateWorker() => ProjectsImplemented / SubordinateWorker;

        /// <summary>
        /// Проваленных проектов на одного рабочего в подчинении
        /// </summary>
        /// <returns></returns>
        public double FailedProjectsPerSubordinateWorker() => ProjectsFailed / SubordinateWorker;

        public override string ToString() => base.ToString() +
    $"\nРеализовано проектов: {ProjectsImplemented} ед.\n" +
    $"Рабочих в подчинении: {SubordinateWorker} чел.\n" +
    $"Проваленных проектов: {ProjectsFailed} ед.";


        public override bool IsContains(string text)
        {
            text = text.ToUpper();
            if (Name.Contains(text)
                || WorkExperience.ToString().Contains(text)
                || Salary.ToString().Contains(text)
                || ProjectsImplemented.ToString().Contains(text)
                || SubordinateWorker.ToString().Contains(text)
                || ProjectsFailed.ToString().Contains(text)) return true;
            else return false;
        }

    }
}
