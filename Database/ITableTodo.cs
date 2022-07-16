using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface ITableTodo
    {
        public List<Domains.Todo> Select();
        public List<Domains.Todo> Select(Domains.Filter filter);

        public bool Insert(Domains.Todo todo);

        public bool Update(Domains.Todo todo);

        public bool Delete(Guid id);
    }
}
