using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains;

namespace Services
{
    public interface ITodo
    {
        /// <summary>
        /// Создание
        /// </summary>        
        public Domains.Todo Create(Domains.Inctance todo);

        /// <summary>
        /// Чтение одной записи
        /// </summary>        
        public Domains.Todo Read(Guid id);

        /// <summary>
        /// Чтение всех записей
        /// </summary>        
        public IEnumerable<Domains.Todo> Read();

        /// <summary>
        /// Обновление
        /// </summary>        
        public Domains.Todo Update(Guid id, Domains.Inctance todo);

        /// <summary>
        /// Удаление
        /// </summary>
        public bool Delete(Guid id);
    }
}
