namespace Domains
{    

    public class Inctance {
        public Inctance(string title)
        {
            Title = title;
            IsActual = true;
        }

        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public bool IsActual { get; set; }
    }


    public class Todo
    {
        public Todo(string title)
        {
            Id = Guid.NewGuid();
            Inctance = new Inctance(title);
        }

        private Inctance Inctance { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Title {
            get {
                return Inctance.Title;
            }

            set {
                Inctance.Title = value;
            }
        }

        /// <summary>
        /// Статус
        /// </summary>
        public bool IsActual
        {
            get
            {
                return Inctance.IsActual;
            }

            set
            {
                Inctance.IsActual = value;
            }
        }
    }
}