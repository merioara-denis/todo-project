using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Filter
    {
        public List<Guid>? Ids { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public bool? IsActual { get; set; }
    }
}
