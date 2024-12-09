using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.Repositories
{
    public interface ITurnRepository
    {
        public IEnumerable<Turn> GetAll();
        public Turn GetById(int id);
        public Turn AddTurn(Turn turn);

        public Turn UpdateTurn(int id, Turn turn);
        public void DeleteTurn(int id);
    }
}
